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
    public partial class frmCategoryList : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string eTitle = "Wenani POS System";

        public frmCategoryList()
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
        }

        private void exitButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadCategory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connString.Open();
            cm = new SqlCommand("select * from tblCategory order by category", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            connString.Close();
        }

        private void editButton1_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory(this);
            frm.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                frmCategory frm = new frmCategory(this);
                frm.btnSave.Enabled = false;
                frm.btnUpdate.Enabled = true;
                frm.lblID.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                frm.txtCategory.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.ShowDialog();
            }
            else if (colName == "Delete")
            {
                if (MessageBox.Show("Are you sure you want to delete this category?", eTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("delete from tblCategory where id like '" + dataGridView1[1, e.RowIndex].Value.ToString() + "'", connString);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Category deleted successfully", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connString.Close();
                    loadCategory();
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            frmCategory frm = new frmCategory(this);
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
