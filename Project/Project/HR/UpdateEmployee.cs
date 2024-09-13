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
    public partial class UpdateEmployee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
        public string id;

        public UpdateEmployee(string Id)
        {
            InitializeComponent();
            id = Id;

            con.Open();

            string query = "SELECT * FROM Employee Where Id=" + id;
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        string data = reader["Name"].ToString();
                        nameTb.Text = data;

                        string data2 = reader["Surname"].ToString();
                        surnameTb.Text = data2;

                        string data3 = reader["Age"].ToString();
                        ageTb.Text = data3;

                        string data4 = reader["IdentificationNo"].ToString();
                        IdTb.Text = data4;

                        string data5 = reader["Department"].ToString();
                        departmentCb.Text = data5;

                        string data6 = reader["Location"].ToString();
                        locationTb.Text = data6;

                        string data7 = reader["Phone"].ToString();
                        phoneTb.Text = data7;

                        string data8 = reader["Gender"].ToString();
                        genderCb.Text = data8;

                        string data10 = reader["Wage"].ToString();
                        wageTb.Text = data10;
                    }
                }
            }
            con.Close();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                int intId = int.Parse(id);

                con.Open();
                SqlCommand cmd = new SqlCommand("Update Employee set Name=@Name,Surname=@Surname,Age=@Age,IdentificationNo=@IdentificationNo,Department=@Department,Location=@Location,Phone=@Phone,Gender=@Gender,BloodGroup=@BloodGroup,Wage=@Wage Where Id=" + intId, con);
                cmd.Parameters.AddWithValue("@Name", nameTb.Text);
                cmd.Parameters.AddWithValue("@Surname", surnameTb.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(ageTb.Text));
                cmd.Parameters.AddWithValue("@IdentificationNo", IdTb.Text);
                cmd.Parameters.AddWithValue("@Department", departmentCb.Text);
                cmd.Parameters.AddWithValue("@Location", locationTb.Text);
                cmd.Parameters.AddWithValue("@Phone", phoneTb.Text);
                cmd.Parameters.AddWithValue("@Gender", genderCb.Text);
                cmd.Parameters.AddWithValue("@BloodGroup", bloodGroupCb.Text);
                cmd.Parameters.AddWithValue("@Wage", float.Parse(wageTb.Text));

                int i = cmd.ExecuteNonQuery();

                MessageBox.Show("The Employee Updated", "SUCCES", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Record Update Failed", "FAIL", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
            
        }

        private void nameTb_Enter(object sender, EventArgs e)
        {
            if (nameTb.Text == "Name")
            {
                nameTb.Text = "";
            }
        }

        private void surnameTb_Enter(object sender, EventArgs e)
        {
            if (surnameTb.Text == "Surname")
            {
                surnameTb.Text = "";
            }
        }

        private void ageTb_Enter(object sender, EventArgs e)
        {
            if (ageTb.Text == "Age")
            {
                ageTb.Text = "";
            }
        }

        private void IdTb_Enter(object sender, EventArgs e)
        {
            if (IdTb.Text == "Identification No")
            {
                IdTb.Text = "";
            }
        }


        private void locationTb_Enter(object sender, EventArgs e)
        {
            if (locationTb.Text == "Location")
            {
                locationTb.Text = "";
            }
        }

        private void phoneTb_Enter(object sender, EventArgs e)
        {
            if (phoneTb.Text == "Phone")
            {
                phoneTb.Text = "";
                phoneTb.ForeColor = Color.White;
            }
        }

        private void wageTb_Enter(object sender, EventArgs e)
        {
            if (wageTb.Text == "Wage")
            {
                wageTb.Text = "";
                wageTb.ForeColor = Color.White;
            }
        }
    }
}
