using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace CS01_DBConnect
{
    public partial class frmConnect : Form
    {
        OracleConnection conn = new OracleConnection(DBConnect.oradb);
        public frmConnect()
        {
            InitializeComponent();
        }

        private void frmConnect_Load(object sender, EventArgs e)
        {
            try
            {

                Stock myStock = new Stock();
                DataSet myDS = new DataSet();

                grdData.DataSource = myStock.getStock(myDS).Tables["Pat"];

               
            }
            catch (OracleException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    
        private void btnTest_Click(object sender, EventArgs e)
        {

        }
    }
}
