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
    public partial class frmProductList : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string eTitle = "Wenani POS System";

        public frmProductList()
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            loadRecords();
     
        }

        //Loading products in the product list
        public void loadRecords()
        {
            connString.Open();
            int i = 0;
            dataGridView1.Rows.Clear();
            cm = new SqlCommand("select * from tblProduct", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["proCode"].ToString(), dr["barCode"].ToString(), dr["proDesc"].ToString(), dr["braId"].ToString(), dr["catId"].ToString(), dr["price"].ToString(), dr["qty"].ToString());
            }
            dr.Close();
            connString.Close();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void editButton1_Click(object sender, EventArgs e)
        {
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            loadRecords();
        }

        //Editing and deleting data from product list table
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmProduct frm = new frmProduct(this);
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.txtPCode.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtBarcode.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.txtDesc.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
                frm.txtPrice.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                frm.comboBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
                frm.comboBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this record?", eTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("delete from tblProduct where proCode like '" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", connString);                  
                    cm.ExecuteNonQuery();
                    connString.Close();
                    MessageBox.Show("Brand deleted successfuly", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);   
                    loadRecords();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct(this);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
