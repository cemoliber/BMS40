using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HR
{
    public partial class NewEmployee : Form
    {
        public NewEmployee()
        {
            InitializeComponent();
        }

        private void saveButton_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void saveButton_MouseEnter(object sender, EventArgs e)
        {
            saveButton.BackColor = Color.LimeGreen;
        }

        private void saveButton_MouseLeave(object sender, EventArgs e)
        {
            saveButton.BackColor = Color.DarkGreen;
        }

        private void nameTb_Enter(object sender, EventArgs e)
        {
            if(nameTb.Text == "Name")
            {
                nameTb.Text = "";
                nameTb.ForeColor = Color.White;
            }
        }

        private void nameTb_Leave(object sender, EventArgs e)
        {
            if (nameTb.Text == " ")
            {
                nameTb.Text = "Name";
                nameTb.ForeColor = Color.DimGray;
            }
        }

        private void surnameTb_Enter(object sender, EventArgs e)
        {
            if (surnameTb.Text == "Surname")
            {
                surnameTb.Text = "";
                surnameTb.ForeColor = Color.White;
            }
        }

        private void surnameTb_Leave(object sender, EventArgs e)
        {
            if (surnameTb.Text == "")
            {
                surnameTb.Text = "Surname";
                surnameTb.ForeColor = Color.DimGray;
            }
        }

        private void ageTb_Enter(object sender, EventArgs e)
        {
            if (ageTb.Text == "Age")
            {
                ageTb.Text = "";
                ageTb.ForeColor = Color.White;
            }
        }

        private void ageTb_Leave(object sender, EventArgs e)
        {
            if (ageTb.Text == "")
            {
                ageTb.Text = "Age";
                ageTb.ForeColor = Color.DimGray;
            }
        }

        private void IdTb_Enter(object sender, EventArgs e)
        {
            if (IdTb.Text == "Identification No")
            {
                IdTb.Text = "";
                IdTb.ForeColor = Color.White;
            }
        }

        private void IdTb_Leave(object sender, EventArgs e)
        {
            if (IdTb.Text == "")
            {
                IdTb.Text = "Identification No";
                IdTb.ForeColor = Color.DimGray;
            }
        }

        private void departmentTb_Enter(object sender, EventArgs e)
        {
            if (departmentTb.Text == "Department")
            {
                departmentTb.Text = "";
                departmentTb.ForeColor = Color.White;
            }
        }

        private void departmentTb_Leave(object sender, EventArgs e)
        {
            if (departmentTb.Text == "")
            {
                departmentTb.Text = "Department";
                departmentTb.ForeColor = Color.DimGray;
            }
        }

        private void locationTb_Enter(object sender, EventArgs e)
        {
            if (locationTb.Text == "Location")
            {
                locationTb.Text = "";
                locationTb.ForeColor = Color.White;
            }
        }

        private void locationTb_Leave(object sender, EventArgs e)
        {
            if (locationTb.Text == "")
            {
                locationTb.Text = "Location";
                locationTb.ForeColor = Color.DimGray;
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

        private void phoneTb_Leave(object sender, EventArgs e)
        {
            if (phoneTb.Text == "")
            {
                phoneTb.Text = "Phone";
                phoneTb.ForeColor = Color.DimGray;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //this method for Create a new data column for Employee table
            try
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
                con.Open();

                SqlCommand cmd = new SqlCommand("insert into Employee values (@Name,@Surname,@Age,@IdentificationNo,@Department,@Location,@Phone,@Gender,@BloodGroup,@Birthdate,@Startingdate,@Wage)", con);

                cmd.Parameters.AddWithValue("@Name", nameTb.Text);
                cmd.Parameters.AddWithValue("@Surname", surnameTb.Text);
                cmd.Parameters.AddWithValue("@Age", int.Parse(ageTb.Text));
                cmd.Parameters.AddWithValue("@IdentificationNo", IdTb.Text);
                cmd.Parameters.AddWithValue("@Department", departmentTb.Text);
                cmd.Parameters.AddWithValue("@Location", locationTb.Text);
                cmd.Parameters.AddWithValue("@Phone", phoneTb.Text);
                cmd.Parameters.AddWithValue("@Gender", genderCb.Text);
                cmd.Parameters.AddWithValue("@BloodGroup", bloodGroupCb.Text);
                cmd.Parameters.AddWithValue("@Birthdate", birthDate.Value);
                cmd.Parameters.AddWithValue("@Startingdate", startingDate.Value);
                cmd.Parameters.AddWithValue("@Wage", float.Parse(wageTb.Text));

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("New Employee Added", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                MessageBox.Show("Record Can Not Added", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void wageTb_Enter(object sender, EventArgs e)
        {
            if (phoneTb.Text == "Wage")
            {
                phoneTb.Text = "";
                phoneTb.ForeColor = Color.White;
            }
        }

        private void wageTb_Leave(object sender, EventArgs e)
        {
            if (phoneTb.Text == "")
            {
                phoneTb.Text = "Wage";
                phoneTb.ForeColor = Color.White;
            }
        }
    }
}
