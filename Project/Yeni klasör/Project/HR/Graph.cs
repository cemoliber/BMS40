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

namespace Project.HR
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();
            // getting employee number
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");

            con.Open();
            //Getting total employee number
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employee", con);
            int rowCount = (int)cmd.ExecuteScalar();
            totalEmployeeLbl.Text = "Number Of Employees: " + rowCount;

            
            //Getting total wage of employees

            string sql = "SELECT SUM(Wage) FROM Employee";

            using (SqlCommand cmd2 = new SqlCommand(sql, con))
            {
                using (SqlDataReader reader = cmd2.ExecuteReader())
                {
                    // Veri okunduğu sürece döngü
                    while (reader.Read())
                    {
                        // floatColumn adındaki sütundaki değeri al
                        float floatValue = reader.GetFloat(reader.GetOrdinal("Wage"));
                        totalWageLbl.Text = "Total Wage: $" + floatValue;
                    }
                }
            }

            con.Close();
        }
    }
}
