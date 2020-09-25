using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace wenaniPos
{
    public class DBConnection
    {
        SqlConnection connString = new SqlConnection();
        SqlCommand cm = new SqlCommand();
        SqlDataReader dr;

        public string MyConnection()
        {
            string connString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\DevTech\Project\big\big\wenaniPos\wenaniPos\wenaniDB.mdf;Integrated Security=True";
            return connString;
        }

        public double getVal()
        {
            double vat=0;
            connString.ConnectionString = MyConnection();
            connString.Open();
            cm = new SqlCommand("Select * from tblVat", connString);
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                vat = Double.Parse(dr["vat"].ToString());
            }
            dr.Close();
            connString.Close();
            return vat;
        }

    }
}
