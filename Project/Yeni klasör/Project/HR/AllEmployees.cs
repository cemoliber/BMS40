using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Project.HR
{
    public partial class AllEmployees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
        public AllEmployees()
        {
            InitializeComponent();
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Employee", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                allEmployeesDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                //Shows warning message for user while occured any error
                MessageBox.Show("Occured a Error While Datas Loading!", "Warning", MessageBoxButtons.OK);
            }
            
        }

        private void allEmployeesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting ID of selected row
            int index = e.RowIndex;
            DataGridViewRow selectedRows = allEmployeesDataGridView.Rows[index];
            tbRows.Text = selectedRows.Cells[0].Value.ToString();
        }

        private void deleteButton_Enter(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void deleteButton_Leave(object sender, EventArgs e)
        {
            deleteButton.BackColor = Color.Red;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //this method is for deleting a selected row
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Employee where Id ="+tbRows.Text,con);
            cmd.ExecuteNonQuery();

            //this method is refresh the table
            SqlCommand cmd2 = new SqlCommand("Select * From Employee", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            allEmployeesDataGridView.DataSource = dt;

            con.Close();
            MessageBox.Show("Employee Deleted Succesfully");

        }

        private void allEmployeesDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRows = allEmployeesDataGridView.Rows[index];
            tbRows.Text = selectedRows.Cells[0].Value.ToString();

            string id = tbRows.Text;

            UpdateEmployee updateEmployee = new UpdateEmployee(id);
            updateEmployee.Show();
        }

        //filtering process
        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
              
                //Shows all datas
                if (searchCb.SelectedItem.Equals("ALL DATAS"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Employee", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by id
                if (searchCb.SelectedItem.Equals("ID"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where Id LIKE @Id", con);
                    sqlCommand.Parameters.AddWithValue("@Id", "%" + int.Parse(searchTb.Text) + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by name
                if (searchCb.SelectedItem.Equals("NAME"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where Name LIKE @Name", con);
                    sqlCommand.Parameters.AddWithValue("@Name", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by surname
                if (searchCb.SelectedItem.Equals("SURNAME"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where Surname LIKE @Surname", con);
                    sqlCommand.Parameters.AddWithValue("@Surname", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                if (searchCb.SelectedItem.Equals("AGE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where Age LIKE @Age", con);
                    sqlCommand.Parameters.AddWithValue("@Age", "%" + int.Parse(searchTb.Text) + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by id no
                if (searchCb.SelectedItem.Equals("IDENTIFICATION NO"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where IdentificationNo LIKE @IdentificationNo", con);
                    sqlCommand.Parameters.AddWithValue("@IdentificationNo", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by department
                if (searchCb.SelectedItem.Equals("DEPARTMENT"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where Department LIKE @Department", con);
                    sqlCommand.Parameters.AddWithValue("@Department", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by location
                if (searchCb.SelectedItem.Equals("LOCATION"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where Location LIKE @Location", con);
                    sqlCommand.Parameters.AddWithValue("@Location", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by phone
                if (searchCb.SelectedItem.Equals("PHONE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where Phone LIKE @Phone", con);
                    sqlCommand.Parameters.AddWithValue("@Phone", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by gender
                if (searchCb.SelectedItem.Equals("GENDER"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where Gender LIKE @Gender", con);
                    sqlCommand.Parameters.AddWithValue("@Gender", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by blood group
                if (searchCb.SelectedItem.Equals("BLOOD GROUP"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Employee Where BloodGroup LIKE @BloodGroup", con);
                    sqlCommand.Parameters.AddWithValue("@BloodGroup", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    allEmployeesDataGridView.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Record Can Not Found", "NO DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
