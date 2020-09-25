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
    public partial class frmLookUp : Form
    {
        frmPOS f;
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string eTitle = "Wenani POS System";

        public frmLookUp(frmPOS frm)
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            f = frm;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void loadRecords()
        {
            connString.Open();
            int i = 0;
            dataGridView1.Rows.Clear();
            cm = new SqlCommand("select * from tblProduct", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr["proCode"].ToString(), dr["barCode"].ToString(), dr["proDesc"].ToString(), dr["braId"].ToString(), dr["catId"].ToString(), dr["price"].ToString(), dr["qty"].ToString());
            }
            dr.Close();
            connString.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            //This code is supposed to load products when searching
            //for products to add to cart but it is not working
            //as expected


            /*frmLookUp frm = new frmLookUp(f);
            frm.loadRecords();*/

            loadRecords();
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            //frmLookUp frm = new frmLookUp(f);
            //frm.loadRecords();
            //loadRecords();
        }

        //Loading products to cart when searching a product by name
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "Select")
            {
                frmQty frm = new frmQty(f);
                //frm.productDetails(dr["proCode"].ToString(), dr["proDesc"].ToString(), double.Parse(dr["price"].ToString()), lblTransactionNo.Text);
                frm.productDetails(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString(), Double.Parse(dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString()), f.lblTransactionNo.Text);
                frm.ShowDialog();
            }
        }
    }
}
