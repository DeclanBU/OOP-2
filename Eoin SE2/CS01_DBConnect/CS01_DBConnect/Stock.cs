//Eoin McGrath
//26/01/2017

using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;

namespace CS01_DBConnect
{
    class Stock
    {
        //instance variables
        private int stock_No;
        private string description;
        private decimal cost_Price;
        private decimal sale_Price;
        private int qty;
        private char status;

        //no arguement constructor
        public Stock()
        {
            stock_No = 0;
            description = " ";
            cost_Price = 0;
            sale_Price = 0;
            qty = 0;
            status = ' ';
        }

        public Stock(int Stock_No, String Description, Decimal Cost_Price, Decimal Sale_Price, int Qty)
        {
            stock_No = Stock_No;
            description = Description;
            cost_Price = Cost_Price;
            sale_Price = Sale_Price;
            qty = Qty;
            status = 'R';
        }

        //method to retrieve all stock from stock table
        public DataSet getStock(DataSet ds)
        {
            // Connect to DB
            OracleConnection conn = new OracleConnection(DBConnect.oradb);
            conn.Open();

            //Def sql Query

            String strSQL = "SELECT stock_No, description From Stock Order BY Stock_No";
            OracleCommand cmd = new OracleCommand(strSQL, conn);

            //Ex Query

            OracleDataAdapter da = new OracleDataAdapter(cmd);
        
            da.Fill(ds, "Pat");


            conn.Close();
            return ds;
        }

        public static int nextStockNo()
        {
            //variables to hold value to be returned
            int intNextStockNo;

            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define the SQL query to get MAX stock_No used
            String strSQL ="SELECT MAX(STOCK_NO) from STOCK";

            OracleCommand cmd = new OracleCommand(strSQL, myConn);

            //execute the SQL query
            OracleDataReader dr = cmd.ExecuteReader();

            //read the first(only) value returned by query
            //If first stockNo, assignm value 1, otherwise add 1 to MAX value
            dr.Read();

            if (dr.IsDBNull(0))
                intNextStockNo = 1;
            else
                intNextStockNo = Convert.ToInt32(dr.GetValue(0)) + 1;

            //close DB Connection
            myConn.Close();

            //return next StockNo
            return intNextStockNo;
        }

        public void regStock()
        {
            //Connect to the DB
            OracleConnection myConn = new OracleConnection(DBConnect.oradb);
            myConn.Open();

            //Define SQL Query
            String strSQL = "INSERT INTO STOCK VALUES(" + this.stock_No + ",'" + this.description + "'," + this.cost_Price +"," + this.sale_Price + "," + this.qty + ",'" + this.status+ "')";

            //Execute SQL Query 
            OracleCommand cmd = new OracleCommand(strSQL, myConn);
            cmd.ExecuteNonQuery();

            //Close DB
            myConn.Close();
        }
    }
}
