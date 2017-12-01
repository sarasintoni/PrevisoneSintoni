using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previsione
{
    class Model
    {
        public delegate void viewEventHandler(object sender, string textToWrite); // questo gestisce l'evento
        public event viewEventHandler FlushText;
        private List<int> values;

        public void readView(string sqLiteConnString, bool isSQLite, string idCliente)
        {
            values = new List<int>();
            IDbConnection conn = null;
            try
            {
                if (isSQLite)
                    conn = new SQLiteConnection(sqLiteConnString);
                else
                {
                    conn = new SqlConnection(sqLiteConnString);
                }

                conn.Open();
                IDbCommand com = conn.CreateCommand();
                string queryText = "SELECT val from histordini where idserie =  @id";
                com.CommandText = queryText;

                IDbDataParameter param = com.CreateParameter();
                param.DbType = DbType.Int32;
                param.ParameterName = "@id";
                param.Value = Int32.Parse(idCliente);
                com.Parameters.Add(param);
                using (IDataReader reader = com.ExecuteReader())
                {

                    while (reader.Read()) {
                        int v = Convert.ToInt32(reader["val"]);
                        FlushText(this, "VAL = " + v.ToString());
                        values.Add(v);
                    }
                }

      
                conn.Close();
            }
            catch (Exception ex)
            {
                FlushText(this, ex.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }

        public void readViaFactory(string connString, string factory, string idCliente)
        {
            values = new List<int>();
            DbProviderFactory dbFactory = DbProviderFactories.GetFactory(factory);
            using (DbConnection conn = dbFactory.CreateConnection())
            {
                try
                {
                    conn.ConnectionString = connString;
                    conn.Open();
                    DbDataAdapter dbAdapter = dbFactory.CreateDataAdapter();
                    DbCommand dbCommand = conn.CreateCommand();

                    string queryText = "SELECT val from histordini where idserie =  @id";
                    dbCommand.CommandText = queryText;

                    IDbDataParameter param = dbCommand.CreateParameter();
                    param.DbType = DbType.Int32;
                    param.ParameterName = "@id";
                    param.Value = Int32.Parse(idCliente);
                    dbCommand.Parameters.Add(param);
                    using (IDataReader reader = dbCommand.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int v = Convert.ToInt32(reader["val"]);
                            FlushText(this, "VAL = " + v.ToString());
                            values.Add(v);
                        }
                    }

                }
                catch (Exception ex)
                {
                    FlushText(this, "Error: " + ex.Message);
                }
                finally
                {
                    if (conn.State == ConnectionState.Open) conn.Close();
                }
            }
        }

        public void previsione()
        {
            if (values == null)
                FlushText(this, "Leggi i dati prima!!");
            else
            {
                Sarima s = new Sarima(values,6);
                FlushText(this, "Predict value = " + s.predict());
            }
             
        }
    }
}
