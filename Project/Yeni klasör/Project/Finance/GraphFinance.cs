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

namespace Project.Finance
{
    public partial class GraphFinance : Form
    {
        public GraphFinance()
        {
            InitializeComponent();
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");

                con.Open();

                //for Sale
                SqlCommand cmd = new SqlCommand("SELECT SUM(Totalprice) FROM Sale", con);

                float rowCount = cmd.ExecuteNonQuery();

                saleLbl.Text = "Total Amount of Sale: $" + rowCount.ToString();

                //for Purchase
                SqlCommand cmd2 = new SqlCommand("SELECT SUM(Totalprice) FROM Purchase", con);

                float rowCount2 = cmd2.ExecuteNonQuery();

                purchaseLbl.Text = "Total Amount of Purchase : $" + rowCount2.ToString();

                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Hata Oluştu");
            }
            
        }
    }
}
