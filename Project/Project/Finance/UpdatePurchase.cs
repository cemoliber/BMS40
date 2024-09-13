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
    public partial class UpdatePurchase : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
        public string id;

        public UpdatePurchase(String Id)
        {
            InitializeComponent();

            id=Id;

            con.Open();

            string query = "SELECT * FROM Purchase Where Id=" + id;
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string data = reader["Product"].ToString();
                        productTypeTb.Text = data;

                        string data2 = reader["Count"].ToString();
                        countTb.Text = data2;

                        string data3 = reader["Unitprice"].ToString();
                        unitPriceTb.Text = data3;

                        string data4 = reader["Totalprice"].ToString();
                        totalPriceTb.Text = data4;

                        string data5 = reader["Movementlocation"].ToString();
                        movementLocationTb.Text = data5;

                        string data6 = reader["Arrivallocation"].ToString();
                        arrivalLocationTb.Text = data6;

                        string data7 = reader["Company"].ToString();
                        companyTb.Text = data7;

                        string data8 = reader["Companynumber"].ToString();
                        companyContactNumberTb.Text = data8;

                        string data9 = reader["Transportername"].ToString();
                        transporterNameTb.Text = data9;

                        string data10 = reader["Transporternumber"].ToString();
                        transporterContactNoTb.Text = data10;

                        string data11 = reader["Transporttype"].ToString();
                        transferTypeCb.Text = data11;

                        string data12 = reader["Transportstatus"].ToString();
                        transportStatusCb.Text = data12;
                    }
                }
            }
            con.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                int intId = int.Parse(id);

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Purchase set Product=@Product,Count=@Count,Unitprice=@Unitprice,Totalprice=@Totalprice,Movementlocation=@Movementlocation," +
                    "Arrivallocation=@Arrivallocation,Company=@Company,Companynumber=@Companynumber,Transportername=@Transportername,Transporternumber=@Transporternumber," +
                    "Transporttype=@Transporttype,Transportstatus=@Transportstatus," +
                    "Agreementdate=@Agreementdate,Estimateddate=@Estimateddate Where Id=" + intId, con);

                cmd.Parameters.AddWithValue("@Product", productTypeTb.Text);
                cmd.Parameters.AddWithValue("@Count", float.Parse(countTb.Text));
                cmd.Parameters.AddWithValue("@Unitprice", float.Parse(unitPriceTb.Text));
                cmd.Parameters.AddWithValue("@Totalprice", float.Parse(totalPriceTb.Text));
                cmd.Parameters.AddWithValue("@Movementlocation", movementLocationTb.Text);
                cmd.Parameters.AddWithValue("@Arrivallocation", arrivalLocationTb.Text);
                cmd.Parameters.AddWithValue("@Company", companyTb.Text);
                cmd.Parameters.AddWithValue("@Companynumber", companyContactNumberTb.Text);
                cmd.Parameters.AddWithValue("@Transportername", transporterNameTb.Text);
                cmd.Parameters.AddWithValue("@Transporternumber", transporterContactNoTb.Text);
                cmd.Parameters.AddWithValue("@Transporttype", transferTypeCb.Text);
                cmd.Parameters.AddWithValue("@Transportstatus", transportStatusCb.Text);
                cmd.Parameters.AddWithValue("@Agreementdate", agreementDate.Value);
                cmd.Parameters.AddWithValue("@Estimateddate", estimatedArrivalDate.Value);

                int i = cmd.ExecuteNonQuery();

                MessageBox.Show("The Employee Updated", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Update Failed", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void productTypeTb_Enter(object sender, EventArgs e)
        {
            if (productTypeTb.Text == "Product Type")
            {
                productTypeTb.Text = "";
            }
        }

        private void countTb_Enter(object sender, EventArgs e)
        {
            if (countTb.Text == "Count / KG")
            {
                countTb.Text = "";
            }
        }

        private void unitPriceTb_Enter(object sender, EventArgs e)
        {
            if (unitPriceTb.Text == "Unit Price")
            {
                unitPriceTb.Text = "";
            }
        }

        private void totalPriceTb_Enter(object sender, EventArgs e)
        {
            if (totalPriceTb.Text == "Total Price")
            {
                totalPriceTb.Text = "";
            }
        }

        private void movementLocationTb_Enter(object sender, EventArgs e)
        {
            if (movementLocationTb.Text == "Movement Location")
            {
                movementLocationTb.Text = "";
            }
        }

        private void arrivalLocationTb_Enter(object sender, EventArgs e)
        {
            if (arrivalLocationTb.Text == "Arrival Location")
            {
                arrivalLocationTb.Text = "";
            }
        }

        private void companyTb_Enter(object sender, EventArgs e)
        {
            if (companyTb.Text == "Company")
            {
                companyTb.Text = "";
            }
        }

        private void companyContactNumberTb_Enter(object sender, EventArgs e)
        {
            if (companyContactNumberTb.Text == "Company Contact Number")
            {
                companyContactNumberTb.Text = "";
            }
        }

        private void transporterNameTb_Enter(object sender, EventArgs e)
        {
            if (transporterNameTb.Text == "Transporter Name")
            {
                transporterNameTb.Text = "";
            }
        }

        private void transporterContactNoTb_Enter(object sender, EventArgs e)
        {
            if (transporterContactNoTb.Text == "Transporter Contact Number")
            {
                transporterContactNoTb.Text = "";
            }
        }
    }
}
