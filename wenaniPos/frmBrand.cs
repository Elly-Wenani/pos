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
using System.Web;
using System.Configuration;

namespace wenaniPos
{
    public partial class frmBrand : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        frmBrandList frmList;
        string eTitle = "Wenani POS System";


        public frmBrand(frmBrandList flist)
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection()); 
            frmList = flist;
        }

        public frmBrand()
        {
        }

        private void frmBrand_Load(object sender, EventArgs e)
        {
           
        }
        
        private void Clear()
        {
            //btnSave.Enabled = true;
            //btnUpdate.Enabled = false;
            txtBrand.Clear();
            txtBrand.Focus();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this brand?", eTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connString.Open();                   
                    cm = new SqlCommand ("INSERT INTO tblBrand(brand) VALUES (@brand)", connString);
                    cm.Parameters.AddWithValue ("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    connString.Close();
                    MessageBox.Show("Brand Saved!");
                    Clear();
                    frmList.loadRecords();

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
   
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to update this brand", "Update Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("update tblBrand set brand = @brand where id like '" + lblID.Text + "'", connString);
                    cm.Parameters.AddWithValue("@brand", txtBrand.Text);
                    cm.ExecuteNonQuery();
                    connString.Close();
                    MessageBox.Show("Brand updated successfully.");
                    Clear();
                    frmList.loadRecords();
                    this.Dispose();
                }

            }catch(Exception)
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