using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Previsione
{
    class Controller
    {
        Model M = new Model();
        public delegate void viewEventHandler(object sender, string textToWrite); // questo gestisce l'evento
        public event viewEventHandler FlushText; // questo genera l'evento

        public Controller()
        {
            M.FlushText += controllerViewEventHandler;
        }

        private void controllerViewEventHandler(object sender, string textToWrite)
        {
            FlushText(this, textToWrite);
        }

        public void readView(bool isSQLLite, string idCliente)
        {
            /*String s;
            if (isSQLLite)
                s = " con sqlite";
            else
                s = " NON con sqlite";
            FlushText(this, "Devo leggere la view " + s);*/

            String connString;
            if (isSQLLite)
            {
                connString = ConfigurationManager.ConnectionStrings["SQLiteConn"].ConnectionString;
            }
            else
            {
                connString = ConfigurationManager.ConnectionStrings["LocalDbConn"].ConnectionString;

            }

            M.readView(connString, isSQLLite, idCliente);
        }

        public void readViaFactory(bool isSQLLite, string idCliente)
        {
            /*String s;
            if (isSQLLite)
                s = " con sqlite";
            else
                s = " NON con sqlite";
            FlushText(this, "Devo leggere con la factory" + s);*/

            String fact, connString;

            if (isSQLLite)
            {
                connString = ConfigurationManager.ConnectionStrings["SQLiteConnLab"].ConnectionString;
                fact = "System.Data.SQLite";
            }
            else
            {
                connString = ConfigurationManager.ConnectionStrings["LocalDbConn"].ConnectionString;
                fact = "System.Data.SqlClient";

            }

            M.readViaFactory(connString, fact, idCliente);
        }

        public void previsione(bool isSQLLite, string id)
        {
            /*String s;
            if (isSQLLite)
                s = " con sqlite";
            else
                s = " NON con sqlite";
            FlushText(this, "Prevedi!" + s);*/

            M.previsione();
        }
    }
}
