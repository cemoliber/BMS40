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
    public partial class Payments : Form
    {
        public Payments()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //this method for Create a new data column for Sale table
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into Sale Payment (@Paymentinstitution,@Amountpaid,@Billtype,@Paymentmethod,@Paymentdate,@Paiddate)", con);

                cmd.Parameters.AddWithValue("@Paymentinstitution", paymentInstitutionTb.Text);
                cmd.Parameters.AddWithValue("@Amountpaid", amountPaidTb.Text);
                cmd.Parameters.AddWithValue("@Billtype", billTypeCb.Text);
                cmd.Parameters.AddWithValue("@Paymentmethod", paymentMethodCb.Text);
                cmd.Parameters.AddWithValue("@Paymentdate", date1.Value);
                cmd.Parameters.AddWithValue("@Paiddate", date2.Value);

                cmd.ExecuteNonQuery();
                con.Close();

                //shows message for user
                MessageBox.Show("New Payment Data Added", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                //shows message for user
                MessageBox.Show("Record Can Not Added", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveButton_Enter(object sender, EventArgs e)
        {
            saveButton.BackColor = Color.LimeGreen;
        }

        private void saveButton_Leave(object sender, EventArgs e)
        {
            saveButton.BackColor = Color.DarkGreen;
        }
    }
}
