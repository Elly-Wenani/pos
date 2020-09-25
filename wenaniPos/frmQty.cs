using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace wenaniPos
{
    public partial class frmQty : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        private String pCode;
        private String pDesc;
        private double price;
        private String transNo;
        string eTitle = "Wenani POS System";
        frmPOS fPOS;

        public frmQty(frmPOS frmpos)
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            fPOS = frmpos;
        }

        private void frmQty_Load(object sender, EventArgs e)
        {
           
        }

        public void productDetails(String pCode, String proDesc, double price, String transNo)
        {
            this.pCode = pCode;
            this.pDesc = proDesc;
            this.price = price;
            this.transNo = transNo;
        }

        private void txtQty_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtQty_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar == 13) && (txtQty.Text != String.Empty))
                {
                    connString.Open();
                    cm = new SqlCommand("INSERT INTO tblCart(transNo, proCode, proDesc, price, qty, sDate) VALUES (@transNo, @proCode, @proDesc, @price, @qty, @sDate)", connString);
                    cm.Parameters.AddWithValue("@transNo", transNo);
                    cm.Parameters.AddWithValue("@proCode", pCode);
                    cm.Parameters.AddWithValue("@proDesc", pDesc);
                    cm.Parameters.AddWithValue("@price", price);
                    cm.Parameters.AddWithValue("@qty", int.Parse(txtQty.Text));
                    cm.Parameters.AddWithValue("@sDate", DateTime.Now);
                    cm.ExecuteNonQuery();
                    connString.Close();

                    fPOS.txtSearch.Clear();
                    fPOS.txtSearch.Focus();
                    fPOS.loadCart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                connString.Close();
                MessageBox.Show(ex.Message, eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
