using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace wenaniPos
{
    public partial class frmSearchProductStonkin : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string eTitle = "Wenani POS System";
        frmStockIn sList;

        public frmSearchProductStonkin(frmStockIn fList)
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            loadProduct();
            sList = fList;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void loadProduct()
        {
            connString.Open();
            int i = 0;
            dataGridView1.Rows.Clear();
            //connString.Open();
            cm = new SqlCommand("select proCode, proDesc, qty from tblProduct where proDesc like '%" + txtSearch.Text + "%' order by proDesc", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
            dr.Close();
            connString.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView1.Columns[e.ColumnIndex].Name;
            if (colName == "colSelect")
            {
                if (sList.txtRefNo.Text == string.Empty)
                {
                    MessageBox.Show("Please enter refference number", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sList.txtRefNo.Focus();
                    return;
                }

                if (sList.txtStockInBy.Text == string.Empty)
                {
                    MessageBox.Show("Please enter stock in by", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    sList.txtStockInBy.Focus();
                    return;
                }

                if (MessageBox.Show("Add this item?", eTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    connString.Open();
                    cm = new SqlCommand("INSERT INTO tblStockIn (refNo, proCode, proDesc, qty, sDate, stockInBy) VALUES (@refNo, @proCode, @proDesc, @qty, @sDate, @stockInBy)", connString);
                    cm.Parameters.AddWithValue("@refNo", sList.txtRefNo.Text);
                    cm.Parameters.AddWithValue("@proCode", dataGridView1[1, e.RowIndex].Value.ToString());  /*dataGridView1.Rows[e.ColumnIndex].Cells[1].Value.ToString());*/
                    cm.Parameters.AddWithValue("@proDesc", dataGridView1[2, e.RowIndex].Value.ToString());  /*dataGridView1.Rows[e.ColumnIndex].Cells[2].Value.ToString());*/
                    cm.Parameters.AddWithValue("@qty", dataGridView1[3, e.RowIndex].Value.ToString());     
                    cm.Parameters.AddWithValue("@sDate", sList.dDate.Value);
                    cm.Parameters.AddWithValue("@stockInBy", sList.txtStockInBy.Text);
                    cm.ExecuteNonQuery();
                    connString.Close();

                    MessageBox.Show("Successfully Added", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    sList.loadStockIn();
                }
            }

        }

        private void txtSearch_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadProduct();
        }
    }
}
