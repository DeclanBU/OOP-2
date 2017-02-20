using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS01_DBConnect
{
    public partial class frmStockReg : Form
    {
        public frmStockReg()
        {
            InitializeComponent();
        }

        private void frmStockReg_Load(object sender, EventArgs e)
        {
            txtStockNo.Text = Stock.nextStockNo().ToString("0000");
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            //validate Data


            //instantiate Stock Object
            Stock myStock = new Stock(Convert.ToInt32(txtStockNo.Text), txtDescription.Text, Convert.ToDecimal(txtCostPrice.Text), Convert.ToDecimal(txtSalePrice.Text), Convert.ToInt32(txtQuantity.Text));
            

            //Insert stock into stock table
            myStock.regStock();

            //Display confirmation message
            MessageBox.Show("Stock " + txtStockNo.Text + " Registered", "Confirmation",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //Reset UI
            txtDescription.Text = "";
            txtCostPrice.Text = "";
            txtSalePrice.Text = "";
            txtQuantity.Text = "";

            txtStockNo.Text = Stock.nextStockNo().ToString("0000");
            txtDescription.Focus();
        }

        
    }
}
