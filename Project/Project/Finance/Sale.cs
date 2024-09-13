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
    public partial class Sale : Form
    {
        public Sale()
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
                SqlCommand cmd = new SqlCommand("insert into Sale values (@Product,@Count,@Unitprice,@Totalprice,@Movementlocation,@Arrivallocation,@Customercompany,@Companynumber,@Transportername,@Transporternumber,@Tranporttype,@Transportstatus,@Agreementdate,@Estimateddate)", con);

                cmd.Parameters.AddWithValue("@Product", productTypeCb.Text);
                cmd.Parameters.AddWithValue("@Count", countTb.Text);
                cmd.Parameters.AddWithValue("@Unitprice", float.Parse(unitPriceTb.Text));
                cmd.Parameters.AddWithValue("@Totalprice", float.Parse(totalPriceTb.Text));
                cmd.Parameters.AddWithValue("@Movementlocation", movementLocationTb.Text);
                cmd.Parameters.AddWithValue("@Arrivallocation", arrivalLocationTb.Text);
                cmd.Parameters.AddWithValue("@Customercompany", customerCompanyTb.Text);
                cmd.Parameters.AddWithValue("@Companynumber", customerContactNumberTb.Text);
                cmd.Parameters.AddWithValue("@Transportername", transporterNameTb.Text);
                cmd.Parameters.AddWithValue("@Transporternumber", transporterContactNoTb.Text);
                cmd.Parameters.AddWithValue("@Tranporttype", transferTypeCb.Text);
                cmd.Parameters.AddWithValue("@Transportstatus", transportStatusCb.Text);
                cmd.Parameters.AddWithValue("@Agreementdate", agreementDate.Value);
                cmd.Parameters.AddWithValue("@Estimateddate", estimatedArrivalDate.Value);

                cmd.ExecuteNonQuery();
                con.Close();

                //shows message for user
                MessageBox.Show("New Sales Data Added", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void countTb_Enter(object sender, EventArgs e)
        {
            if (countTb.Text == "Count")
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
            if (arrivalLocationTb.Text == "Arrival location")
            {
                arrivalLocationTb.Text = "";
            }
        }

        private void customerCompanyTb_Enter(object sender, EventArgs e)
        {
            if (customerCompanyTb.Text == "Customer Company")
            {
                customerCompanyTb.Text = "";
            }
        }

        private void customerContactNumberTb_Enter(object sender, EventArgs e)
        {
            if (customerContactNumberTb.Text == "Company Contact Number")
            {
                customerContactNumberTb.Text = "";
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

        private void countTb_Leave(object sender, EventArgs e)
        {
            if (countTb.Text == "")
            {
                countTb.Text = "Count";
            }
        }

        private void unitPriceTb_Leave(object sender, EventArgs e)
        {
            if (unitPriceTb.Text == "")
            {
                unitPriceTb.Text = "Unit Price";
            }
        }

        private void totalPriceTb_Leave(object sender, EventArgs e)
        {
            if (totalPriceTb.Text == "")
            {
                totalPriceTb.Text = "Total Price";
            }
        }

        private void movementLocationTb_Leave(object sender, EventArgs e)
        {
            if (movementLocationTb.Text == "")
            {
                movementLocationTb.Text = "Movement Location";
            }
        }

        private void arrivalLocationTb_Leave(object sender, EventArgs e)
        {
            if (arrivalLocationTb.Text == "")
            {
                arrivalLocationTb.Text = "Arrival location";
            }
        }

        private void customerCompanyTb_Leave(object sender, EventArgs e)
        {
            if (customerCompanyTb.Text == "")
            {
                customerCompanyTb.Text = "Customer Company";
            }
        }

        private void customerContactNumberTb_Leave(object sender, EventArgs e)
        {
            if (customerContactNumberTb.Text == "")
            {
                customerContactNumberTb.Text = "Company Contact Number";
            }
        }

        private void transporterNameTb_Leave(object sender, EventArgs e)
        {
            if (transporterNameTb.Text == "")
            {
                transporterNameTb.Text = "Transporter Name";
            }
        }

        private void transporterContactNoTb_Leave(object sender, EventArgs e)
        {
            if (transporterContactNoTb.Text == "")
            {
                transporterContactNoTb.Text = "Transporter Contact Number";
            }
        }
    }
}
