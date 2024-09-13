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
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.HR
{
    public partial class Graph : Form
    {
        public Graph()
        {
            InitializeComponent();


            SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
            con.Open();

            //For Gender Chart
            SqlCommand cmdMale = new SqlCommand("SELECT COUNT(*) FROM Employee Where Gender = 'MALE'",con);
            int maleCount = (int)cmdMale.ExecuteScalar();
            
            SqlCommand cmdFemale = new SqlCommand("SELECT COUNT(*) FROM Employee Where Gender = 'FEMALE'",con);
            int femaleCount = (int)cmdFemale.ExecuteScalar();

            genderChart.Series["Series1"].Points.AddXY("MALE", maleCount);
            genderChart.Series["Series1"].Points.AddXY("FEMALE", femaleCount);

            genderChart.Titles.Add("GENDER DISTRIBUTION");


            //For Department Graph
            SqlCommand q1 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Department = 'Software'", con);
            int d1 = (int)q1.ExecuteScalar();

            SqlCommand q2 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Department = 'IT'", con);
            int d2 = (int)q2.ExecuteScalar();

            SqlCommand q3 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Department = 'Technician'", con);
            int d3 = (int)q3.ExecuteScalar();

            SqlCommand q4 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Department = 'Finance'", con);
            int d4 = (int)q4.ExecuteScalar();

            SqlCommand q5 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Department = 'HR'", con);
            int d5 = (int)q5.ExecuteScalar();

            SqlCommand q6 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Department = 'Management'", con);
            int d6 = (int)q6.ExecuteScalar();

            SqlCommand q7 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Department = 'Production'", con);
            int d7 = (int)q7.ExecuteScalar();

            departmentChart.Series["Series1"].Points.AddXY("Software", d1);
            departmentChart.Series["Series1"].Points.AddXY("IT", d2);
            departmentChart.Series["Series1"].Points.AddXY("Technician", d3);
            departmentChart.Series["Series1"].Points.AddXY("Finance", d4);
            departmentChart.Series["Series1"].Points.AddXY("HR", d5);
            departmentChart.Series["Series1"].Points.AddXY("Management", d6);
            departmentChart.Series["Series1"].Points.AddXY("Production", d7);

            departmentChart.Titles.Add("DEPARTMENT DISTRIBUTION");

            //FOR DEPARTMENT AND WAGE DISTRIBUTON CHART
            SqlCommand queryWageDepartment = new SqlCommand("SELECT SUM(Wage) AS WageProduction FROM Employee Where Department = 'Production'");
 

            //For Age Chart
            SqlCommand age1 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Age >  18 AND  Age <  25", con);
            int getAge1 = (int)age1.ExecuteScalar();

            SqlCommand age2 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Age >  25 AND  Age <  35", con);
            int getAge2 = (int)age2.ExecuteScalar();

            SqlCommand age3 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Age >  35 AND  Age <  45", con);
            int getAge3 = (int)age3.ExecuteScalar();

            SqlCommand age4 = new SqlCommand("SELECT COUNT(*) FROM Employee Where Age >  45 AND  Age <  55", con);
            int getAge4 = (int)age4.ExecuteScalar();

            ageChart.Series["Series1"].Points.AddXY("18-25", getAge1);
            ageChart.Series["Series1"].Points.AddXY("25-35", getAge2);
            ageChart.Series["Series1"].Points.AddXY("35-45", getAge3);
            ageChart.Series["Series1"].Points.AddXY("45-55", getAge4);

            ageChart.Titles.Add("AGE DISTRIBUTION");


            //Getting total employee number
            SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM Employee", con);
            int rowCount = (int)cmd.ExecuteScalar();
            totalEmployeeLbl.Text = rowCount.ToString();


            //Getting total wage of employees
            string sqlQuery = "SELECT SUM(Wage) AS TotalSum FROM Employee";

            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    float totalSum = Convert.ToSingle(result);
                    totalWageLbl.Text = totalSum.ToString() + " ₺";
                }
                else
                {
                    Console.WriteLine("No data found.");
                }
            }

            
            //AVERAGE WAGE
            string sqlQuery3 = "SELECT SUM(Wage) AS WageSum FROM Employee";

            using (SqlCommand command = new SqlCommand(sqlQuery3, con))
            {
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    float totalSum = Convert.ToSingle(result);
                    averageWageLbl.Text = (totalSum / rowCount) + " ₺";

                }
                else
                {
                    Console.WriteLine("No data found.");
                }
            }

            //AVERAGE AGE
            string sqlQuery2 = "SELECT SUM(Age) AS AgeSum FROM Employee";

            using (SqlCommand command = new SqlCommand(sqlQuery2, con))
            {
                object result = command.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    float totalSum = Convert.ToSingle(result);
                    averageAgeLbl.Text = (totalSum / rowCount).ToString();

                }
                else
                {
                    Console.WriteLine("No data found.");
                }
            }

            

            //con closed
            con.Close();

        }
    }
}
