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
    public partial class frmLogin : Form
    {
        SqlCommand cm = new SqlCommand();
        string eTitle = "Wenani POS";

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text == "admin")
            {
                Form1 frm = new Form1();
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Incorect user name or password", eTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
