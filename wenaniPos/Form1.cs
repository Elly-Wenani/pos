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

    public partial class Form1 : Form
    {

        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();

        public Form1()
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            //connString.Open();
            MessageBox.Show("DB Connected Successfully!");
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmProductList frm = new frmProductList();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            //frm.loadProduct();
            frm.Show();
        }

        //This is sopposed to be btnCategory

        private void button3_Click(object sender, EventArgs e)
        {
            frmCategoryList frm = new frmCategoryList();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.loadCategory();
            frm.Show();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void IbName_Click(object sender, EventArgs e)
        {

        }

        private void btnBrand_Click(object sender, EventArgs e)
        {
            frmBrandList frm = new frmBrandList();
            frm.TopLevel = false;
            panel3.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPOS frm = new frmPOS();
            frm.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void btnStockIn_Click(object sender, EventArgs e)
        {
            frmStockIn frm = new frmStockIn();
            //frm.TopLevel = false;
            frm.BringToFront();
            //frm.Show();
            //frm.loadProduct();
            frm.ShowDialog();

            

        }
    }
}
