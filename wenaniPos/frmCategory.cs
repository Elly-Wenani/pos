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
    public partial class frmCategory : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmCategoryList flist;

        public frmCategory(frmCategoryList frm)
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            flist = frm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void Clear()
        {
            //btnSave.Enabled = true;
            //btnUpdate.Enabled = false;
            txtCategory.Clear();
            txtCategory.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this category?", "Saving Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("INSERT INTO tblCategory(category) VALUES (@category)", connString);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    connString.Close();
                    MessageBox.Show("Category Saved!");
                    Clear();
                    flist.loadCategory();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Category not saved!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //frm.btnSave.Enable = false;
            try
            {
                if (MessageBox.Show("Are you sure you want to update this category?", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("update tblCategory set category = @category where id like '" + lblID.Text + "'", connString);
                    cm.Parameters.AddWithValue("@category", txtCategory.Text);
                    cm.ExecuteNonQuery();
                    connString.Close();
                    MessageBox.Show("Category updated successfully.");
                    Clear();
                    flist.loadCategory();
                    this.Dispose();
                }

            }
            catch (Exception)
            {

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Clear();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
