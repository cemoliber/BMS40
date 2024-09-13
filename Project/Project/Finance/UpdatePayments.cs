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
    public partial class UpdatePayments : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
        public string id;

        public UpdatePayments(String Id)
        {
            InitializeComponent();
            id = Id;

            con.Open();

            string query = "SELECT * FROM Payments Where Id="+id;
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string data = reader["Paymentinstitution"].ToString();
                        paymentInstitutionTb.Text = data;

                        string data2 = reader["Amountpaid"].ToString();
                        amountPaidTb.Text = data2;

                        string data3 = reader["Billtype"].ToString();
                        billTypeCb.Text = data3;

                        string data4 = reader["Paymentmethod"].ToString();
                        paymentMethodCb.Text = data4;
                    }
                }
            }

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int intId = int.Parse(id);

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Payments set Paymentinstitution=@Paymentinstitution,Amountpaid=@Amountpaid,Billtype=@Billtype," +
                    "Paymentmethod=@Paymentmethod,Paymentdate=@Paymentdate,Paiddate=@Paiddate Where Id=" + intId, con);

                cmd.Parameters.AddWithValue("@Paymentinstitution", paymentInstitutionTb.Text);
                cmd.Parameters.AddWithValue("@Amountpaid", float.Parse(amountPaidTb.Text));
                cmd.Parameters.AddWithValue("@Billtype", billTypeCb.Text);
                cmd.Parameters.AddWithValue("@Paymentmethod", paymentMethodCb.Text);
                cmd.Parameters.AddWithValue("@Paymentdate", date1.Value);
                cmd.Parameters.AddWithValue("@Paiddate", date2.Value);

                int i = cmd.ExecuteNonQuery();

                MessageBox.Show("The Payment Updated", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Update Failed", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
