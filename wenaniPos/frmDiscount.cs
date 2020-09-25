using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wenaniPos
{
    public partial class frmDiscount : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string eTitle = "Wenani POS System";
        frmPOS f;

        public frmDiscount(frmPOS frm)
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        //Code to calculate the discount when percentage is entered in txtPercentage
        private void txtPercentage_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double discount = Double.Parse(txtPrice.Text) * Double.Parse(txtPercentage.Text);
                txtAmount.Text = discount.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtAmount.Text = "0.00";
            }
        }

        //Reducing the added discount amount from the original total
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Add discount?", eTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("Update tblCart set discount = @discount where id = @id", connString);
                    cm.Parameters.AddWithValue("discount", Double.Parse(txtAmount.Text));
                    cm.Parameters.AddWithValue("id", int.Parse(lblID.Text));
                    cm.ExecuteNonQuery();
                    f.loadCart();
                    this.Dispose();
                    connString.Close();
                }
            }
            catch (Exception ex)
            {
                connString.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
