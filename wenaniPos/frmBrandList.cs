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
    public partial class frmBrandList : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;
        DBConnection dbcon = new DBConnection();
        string eTitle = "Wenani POS System";

        public frmBrandList()
        {        
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            loadRecords();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {    
                frmBrand frm = new frmBrand(this);
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;

                frm.lblID.Text = dataGridView1[1, e.RowIndex].Value.ToString();
                frm.txtBrand.Text = dataGridView1[2, e.RowIndex].Value.ToString();
                frm.ShowDialog();
            } else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this brand?", eTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("delete from tblBrand where id like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", connString);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Brand deleted successfuly", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connString.Close();
                    loadRecords();
                }
            }          
        }

        private void editPictureBox_Click(object sender, EventArgs e)
        {
            //frmBrand frm = new frmBrand(this);
            //frm.ShowDialog();
        }

        public void loadRecords()
        {
            connString.Open();
            int i = 0;
            dataGridView1.Rows.Clear();
            cm = new SqlCommand("select * from tblBrand order by brand", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView1.Rows.Add(i, dr["id"].ToString(), dr["brand"].ToString());
            }
            dr.Close();
            connString.Close();
        }

        private void editButton1_Click(object sender, EventArgs e)
        {    
            frmBrand frm = new frmBrand(this);
            frm.ShowDialog();
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmBrand frm = new frmBrand(this);
            frm.btnSave.Enabled = true;
            frm.btnUpdate.Enabled = false;
            frm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}