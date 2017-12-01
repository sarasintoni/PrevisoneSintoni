using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Previsione
{
    public partial class View : Form
    {
        Controller C = new Controller();
        public View()
        {
            InitializeComponent();
            C.FlushText += viewEventHandler; // associo il codice all'handler nella applogic
            string sdb = ConfigurationManager.AppSettings["isSQLite"];
            if (sdb == "1")
                rbSQLite.Checked = true;
            else
                rbSQLServer.Checked = true;
        }
        private void viewEventHandler(object sender, string textToWrite)
        {
            txtConsole.AppendText(textToWrite + Environment.NewLine);
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (normalRead.Checked)
                C.readView(rbSQLite.Checked, clientID.Text);
            else
                C.readViaFactory(rbSQLite.Checked, clientID.Text);
        }

        private void btnPrevisione_Click(object sender, EventArgs e)
        {
            C.previsione(rbSQLite.Checked, clientID.Text);
        }
    }

}
