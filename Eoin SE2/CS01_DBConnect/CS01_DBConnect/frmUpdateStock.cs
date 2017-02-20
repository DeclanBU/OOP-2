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
    public partial class frmUpdateStock : Form
    {
        public frmUpdateStock()
        {
            InitializeComponent();
            grpStockDetails.Visible = false;
            grdUpdate.Visible = false;
        }
        
        private void frmUpdateStock_Load(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            fillGrid();
            

            grdUpdate.Visible = true;
        }

        public void fillGrid()
        {

            int NextProductId;

            //Create database connection string

            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            //OracleConnection myConn = new OracleConnection(DBConnectHome.oradb);


            //Define SQL query
            String strSQL = "SELECT * FROM STOCK WHERE Description LIKE '" + txtDescription.Text +"%'";
           // String strSQL = "SELECT * FROM STOCK";
            //Define Oracle command
            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //Open DB connection
            myConn.Open();

            //create OracleDataAdapter
            OracleDataAdapter da = new OracleDataAdapter(cmd);
            DataSet ds = new DataSet();

            da.Fill(ds, "Stock");
            grdUpdate.DataSource = ds.Tables["Stock"];
           
            //Close DB
            myConn.Close();
            //return ds;
        }

        private void grdUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // get data for selected stock
            // display data 
            grpStockDetails.Visible = true;



            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = grdUpdate.Rows[grdUpdate.CurrentCell.RowIndex].Cells[0].Value.ToString();

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        

    }


    }
}
