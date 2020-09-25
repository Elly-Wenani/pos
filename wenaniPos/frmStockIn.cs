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
    public partial class frmStockIn : Form
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        DBConnection dbcon = new DBConnection();
        SqlDataReader dr;
        string eTitle = "Wenani POS System";

        public frmStockIn()
        {
            InitializeComponent();
            connString = new SqlConnection(dbcon.MyConnection());
            //loadStockIn();
            loadStockInRecords();
        }

        //Loading products in frmStock
        public void loadStockInRecords()
        {
            connString.Open();
            int i = 0;
            dataGridView2.Rows.Clear();
            cm = new SqlCommand("select * from tblStockIn", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i += 1;
                dataGridView2.Rows.Add(i, dr["id"].ToString(), dr["refNo"].ToString(), dr["proCode"].ToString(), dr["proDesc"].ToString(), dr["qty"].ToString(), dr["sDate"].ToString(), dr["stockInBy"].ToString());
            }
            dr.Close();
            connString.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockIn_Load(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dataGridView2.Columns[e.ColumnIndex].Name;
            if (colName == "colDelete")
            {
               if (MessageBox.Show("Are you sure you want to delete this record?", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                  {
                    connString.Open();
                    cm = new SqlCommand("delete from tblStockIn where id like '" + dataGridView2[1, e.RowIndex].Value.ToString() + "'", connString);
                    cm.ExecuteNonQuery();
                    MessageBox.Show("Record deleted successfully", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    connString.Close();
                    loadStockInRecords();
                    //loadStockIn();
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        public void loadStockIn()
        {
            int i = 0;
            dataGridView2.Rows.Clear();
            connString.Open();
            cm = new SqlCommand("Select * from tblStockIn where refNo like '" + txtRefNo.Text + "'and status like 'pending'", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView2.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());
            }
            dr.Close();
            connString.Close();
        }

        private void txtRefNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtStockInBy_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSearchProductStonkin frm = new frmSearchProductStonkin(this);
            loadStockInRecords();
            frm.loadProduct();
            frm.ShowDialog();
        }

        public void Clear()
        {
            txtStockInBy.Clear();
            txtRefNo.Clear();
            dDate.Value = DateTime.Now;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView2.Rows.Count > 0)
                {
                    if (MessageBox.Show("Are you sure you want to save this record?", eTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        for (int i = 0; i < dataGridView2.Rows.Count; i++)
                        {
                            //update tblProduct qty
                            connString.Open();
                            cm = new SqlCommand("update tblProduct set qty = @qty + " + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + " + where proCode like '" + dataGridView2.Rows[i].Cells[3].Value.ToString() + "'", connString);
                            //cm.Parameters.AddWithValue("@qty", dataGridView2.Rows[i].Cells[7].Value.ToString());
                            cm.ExecuteNonQuery();
                            connString.Close();
                            
                            //update tblStockIn qty
                            connString.Open();
                            cm = new SqlCommand("update tblStockIn set qty = qty + " + int.Parse(dataGridView2.Rows[i].Cells[5].Value.ToString()) + ", status = 'pending' where id like '" + dataGridView2.Rows[i].Cells[1].Value.ToString() + "'", connString);
                            //cm.Parameters.AddWithValue("@qty", dataGridView2.Rows[i].Cells[5].Value.ToString());
                            cm.ExecuteNonQuery();
                            connString.Close();
                            
                        }
                        Clear();
                        loadStockIn();
                        loadStockInRecords();
                    }
                }
            }
            catch (Exception ex)
            {
                connString.Close();
                MessageBox.Show(ex.Message, eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                loadStockInRecords();

            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadStockInRecords();
        }

        private void loadStockInHistory()
        {
            int i = 0;
            dataGridView1.Rows.Clear();
            connString.Open();
            cm = new SqlCommand("Select * from tblStockIn where cast(sDate as date) between'" + date1.Value.ToShortDateString() + "' and '" + date2.Value.ToShortDateString() + "' and status like 'pending'", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView1.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), DateTime.Parse( dr[5].ToString()).ToShortDateString(), dr[6].ToString());
            }
            dr.Close();
            connString.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnLoadRecords_Click(object sender, EventArgs e)
        {
            loadStockInHistory();
        }
    }
}
