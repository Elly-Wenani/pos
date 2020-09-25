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
    public partial class frmSettle : Form
    {
        frmPOS fPos;
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string eTitle = "Wenani POS System";

        public frmSettle(frmPOS fp)
        {
            InitializeComponent();
            fPos = fp;
            connString = new SqlConnection(dbcon.MyConnection());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double sale = Double.Parse(txtSale.Text);
                double cash = Double.Parse(txtCash.Text);
                double change = cash - sale;
                txtChange.Text = change.ToString("#,##0.00");
            }
            catch (Exception ex)
            {
                txtChange.Text = "0:00";
            }
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn7.Text;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txtCash.Clear();
            txtCash.Focus();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn9.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn6.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn0.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn2.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn3.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtCash.Text += btn00.Text;
        }

            // When bntEnter is pressed, it computes the amount
            // of total payment from the cart and dispalys the balance
            // to be given back.

            // qty row is also decreased by each amount of products purchased
        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                if ((Double.Parse(txtChange.Text) < 0) || (txtCash.Text == String.Empty))
                {
                    MessageBox.Show("Insufficient funds. Enter the correct amount", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCash.Clear();
                    txtCash.Focus();
                    return;
                }
                else
                {
                    //Boolean saved = false;
                    for (int i = 0; i < fPos.dataGridView1.Rows.Count; i++)
                    {
                        connString.Open();
                        cm = new SqlCommand("Update tblProduct set qty = qty - " + int.Parse(fPos.dataGridView1.Rows[i].Cells[5].Value.ToString()) + " where proCode = '" + fPos.dataGridView1.Rows[i].Cells[2].Value.ToString() + "'", connString);
                        cm.ExecuteNonQuery();
                        connString.Close();

                        connString.Open();
                        cm = new SqlCommand("Update tblCart set status = 'Sold' where id = '" + fPos.dataGridView1.Rows[i].Cells[1].Value.ToString() + "'", connString);
                        cm.ExecuteNonQuery();
                        connString.Close();
                        //saved = true;
                    }
                    MessageBox.Show("Payment Successfully Saved", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fPos.getTransNo();
                    fPos.loadCart();
                    this.Dispose();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Enter the correct amount", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCash.Clear();
                txtCash.Focus();
            }
        }
    }
}
