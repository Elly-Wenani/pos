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
    public partial class frmPOS : Form
    {
        string id;
        string price;
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string eTitle = "Wenani POS System";

        public frmPOS()
        {
            InitializeComponent();
            lblDate.Text = DateTime.Now.ToLongDateString();
            connString = new SqlConnection(dbcon.MyConnection());
            this.KeyPreview = true;
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            getTransNo();
            txtSearch.Enabled = true;
            txtSearch.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (lblTransactionNo.Text == "000000000000") { return; }
            frmLookUp frm = new frmLookUp(this);
            frm.loadRecords();
            frm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmDiscount frm = new frmDiscount(this);
            frm.lblID.Text = id;
            frm.txtPrice.Text = price;
            frm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSettle frm = new frmSettle(this);
            frm.txtSale.Text = lblDisplayTotal.Text;
            frm.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        //Removing items from cart
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                if (MessageBox.Show("Remove item?", eTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("Delete from tblCart where id like'" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() +"'", connString);
                    cm.ExecuteNonQuery();
                    connString.Close();

                    MessageBox.Show("Item removed", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadCart();
                }
            }
        }

        //The code to get the total sales
        public void getCartTotal()
        {
            double discount = Double.Parse(lblDiscount.Text);
            double sales = Double.Parse(lblTotalSales.Text);
            double vat = sales * dbcon.getVal();
            double vatable = sales - vat;
            lblVat.Text = vat.ToString("#,##0.00");
            lblVatable.Text = vatable.ToString("#,##0.00");
            lblDisplayTotal.Text = sales.ToString("#,##0.00");
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
        //code to get transacton number
        public void getTransNo()
        {
            try
            {
                string sDate = DateTime.Now.ToString("yyyyMMdd");
                string transno;
                int count;
                connString.Open();
                cm = new SqlCommand("select top 1 transNo from tblCart where transNo like '" + sDate + "%' order by id desc", connString);
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lblTransactionNo.Text = sDate + (count + 1);                  
                }
                else
                {
                    transno = sDate + "1001";
                    lblTransactionNo.Text = transno;
                }
                dr.Close();
                connString.Close();
            }
            catch (Exception ex)
            {
                connString.Close();
                MessageBox.Show(ex.Message, eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            
        }

        //code to search products from tblProduct using barcode in txtSearch
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text == String.Empty)
                {
                    return;
                }
                else
                {
                    connString.Open();
                    cm = new SqlCommand("select * from tblProduct where barCode like'" + txtSearch.Text + "'", connString);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        frmQty frm = new frmQty(this);
                        frm.productDetails(dr["proCode"].ToString(), dr["proDesc"].ToString(), double.Parse(dr["price"].ToString()), lblTransactionNo.Text);
                        dr.Close();
                        connString.Close();
                        frm.ShowDialog();
                    }
                    else
                    {
                        dr.Close();
                        connString.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                connString.Close();
                MessageBox.Show(ex.Message, eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public void loadCart()
        {
            try
            {
                Boolean hasRecord = false;
                dataGridView1.Rows.Clear();
                int i = 0;
                double total = 0;
                double discount = 0;
                connString.Open();
                cm = new SqlCommand("select * from tblCart  where transNo like '" + lblTransactionNo.Text + "' and status like 'pending'", connString);
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    //frm.txtPCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                    i++;
                    total += Double.Parse(dr["total"].ToString());
                    discount += Double.Parse(dr["discount"].ToString());
                    dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["proCode"].ToString(), dr["proDesc"].ToString(), dr["price"].ToString(), dr["qty"].ToString(), dr["discount"].ToString(), Double.Parse(dr["total"].ToString()).ToString("#,##0.00"));
                    hasRecord = true;
                }
                dr.Close();
                connString.Close();
                lblTotalSales.Text = total.ToString("#,##0.00");
                lblDiscount.Text = discount.ToString("#,##0.00");
                getCartTotal();

                //If the cart has products, then btnSettle and btnDiscount
                //will be enabled, else they will always be disabled
                if (hasRecord == true)
                {
                    btnSettle.Enabled = true;
                    btnDiscount.Enabled = true;
                }
                else
                {
                    btnSettle.Enabled = false;
                    btnDiscount.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                connString.Close();
                MessageBox.Show(ex.Message, eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.CurrentRow.Index;
            id = dataGridView1[1, i].Value.ToString();
            price = dataGridView1[3, i].Value.ToString();
        }

        private void lblTime_Click(object sender, EventArgs e)
        {

        }

        //Displays time on frmPOS
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:MM:ss tt");
            lblDate1.Text = DateTime.Now.ToLongDateString();
        }
    }
}
