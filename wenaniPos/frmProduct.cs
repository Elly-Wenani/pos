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
    public partial class frmProduct : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        frmProductList frmList;

        public frmProduct(frmProductList flist)
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            frmList = flist;
        }

        // Loading tblBrand data to comboBox1
        public void fillComboBrand()
        {
            connString.Open();
            comboBox1.Items.Clear();
            SqlCommand cm = connString.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from tblBrand";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                comboBox1.Items.Add(dr["brand"].ToString());
            }
            connString.Close();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            fillComboBrand();
            fillComboCategory();
        }

        // Loading tblCategory data to comboBox2
        public void fillComboCategory()
        {
            connString.Open();
            comboBox2.Items.Clear();
            SqlCommand cm = connString.CreateCommand();
            cm.CommandType = CommandType.Text;
            cm.CommandText = "select * from tblCategory";
            cm.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cm);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
              {
                    comboBox2.Items.Add(dr["category"].ToString());
              }
            connString.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        //Inserting data into tblProduct
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this product?", "Save Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string braId = ""; string catId = "";
                    connString.Open();
                    cm = new SqlCommand("Select id from tblBrand where brand like '" + comboBox1.Text + "'", connString);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        braId = dr[0].ToString();
                    }
                    dr.Close();
                    //connString.Close();

                    //connString.Open();
                    cm = new SqlCommand("Select id from tblCategory where category like '" + comboBox2.Text + "'", connString);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        catId = dr[0].ToString();
                    }
                    dr.Close();
                    //connString.Close();


                    //connString.Open();                  
                    cm = new SqlCommand("INSERT INTO tblProduct(proCode, barCode, proDesc, braId, catId, price) VALUES (@proCode, @barCode, @proDesc, @braId, @catId, @price)", connString);
                    cm.Parameters.AddWithValue("@proCode",  txtPCode.Text);
                    cm.Parameters.AddWithValue("@barCode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@proDesc", txtDesc.Text);
                    cm.Parameters.AddWithValue("@braId", comboBox1.Text);
                    cm.Parameters.AddWithValue("@catId", comboBox2.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.ExecuteNonQuery();
                    //connString.Close();
                    MessageBox.Show("Product Saved!");
                    Clear();
                    frmList.loadRecords();
                    connString.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Product not Saved!");
            }
        }


        public void Clear()
        {
            txtPrice.Clear();
            txtPCode.Clear();
            txtDesc.Clear();
            txtBarcode.Clear();
            comboBox1.Text = "";
            comboBox2.Text = "";
            txtPCode.Focus();
            //btnSave.Enabled = true;
            //btnUpdate.Enabled = false;
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {   //Trying to make the price in txtPrice to have the currency sign
            //string myString = string.Format("{0:C}", txtPrice);
        }

        // Accepting numbers only on txtPrice
        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {     
            if (e.KeyChar == 46)
            {
                // Accept . charactor
            }

            else if (e.KeyChar == 8)
            {
                // Accept backspace
            }

            else if ((e.KeyChar < 48) || (e.KeyChar > 57)) // ascii code 48-59 between 0 - 9
            {
                e.Handled = true;
            }

        }

        private void txtPCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this product?", "Update Product", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string braId = ""; string catId = "";
                    connString.Open();
                    cm = new SqlCommand("Select id from tblBrand where brand like '" + comboBox1.Text + "'", connString);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        braId = dr[0].ToString();
                    }
                    dr.Close();
                    //connString.Close();

                    //connString.Open();
                    cm = new SqlCommand("Select id from tblCategory where category like '" + comboBox2.Text + "'", connString);
                    dr = cm.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        catId = dr[0].ToString();
                    }
                    dr.Close();
                    //connString.Close();


                    //connString.Open();
                    cm = new SqlCommand("update tblProduct set proCode = @proCode, barCode = @barCode, proDesc = @proDesc, braId = @braId, catId = @catId, price = @price where proCode like @proCode", connString);
                    cm.Parameters.AddWithValue("@proCode", txtPCode.Text);
                    cm.Parameters.AddWithValue("@barCode", txtBarcode.Text);
                    cm.Parameters.AddWithValue("@proDesc", txtDesc.Text);
                    cm.Parameters.AddWithValue("@braId", comboBox1.Text);
                    cm.Parameters.AddWithValue("@catId", comboBox2.Text);
                    cm.Parameters.AddWithValue("@price", txtPrice.Text);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Product Updated!");
                    Clear();
                    frmList.loadRecords();
                    this.Dispose();
                    connString.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Product Not Updated!");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDesc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBarcode_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Clear();
        }
    }
}
