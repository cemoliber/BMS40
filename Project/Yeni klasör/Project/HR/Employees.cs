using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.HR
{
    public class Employees
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }
        public string IdentificationNo { get; set; }
        public string Department { get; set; }
        public string Location { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime StartingDate { get; set; }

        string connectionString = "Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=LIBRARY;Integrated Security=True;TrustServerCertificate=True";
    }

}
/* ist<Employees> employeeList = new List<Employees>();


            SqlConnection con = new SqlConnection(connectionString);

            string selectSql = "Id,Name,Surname,Age,IdentificationNo,Department,Location,Phone,Gender,BloodGroup,Birthate,StartingDate";

            con.Open();

            SqlCommand cmd = new SqlCommand(selectSql, con);

            SqlDataReader dr = cmd.ExecuteReader();

            if (dr != null)
            {
                while (dr.Read())
                {
                    Employees employee = new Employees();

                    employee.Id = Convert.ToInt32(dr["Id"]);
                    employee.Name = dr["Name"].ToString();
                    employee.Surname = dr["Surname"].ToString();
                    employee.Age = Convert.ToInt32(dr["Age"]);
                    employee.IdentificationNo = dr["IdentificationNo"].ToString();
                    employee.Department = dr["Department"].ToString();
                    employee.Location = dr["Location"].ToString();
                    employee.Phone = dr["Phone"].ToString();
                    employee.Gender = dr["Gender"].ToString();
                    employee.BloodGroup = dr["BloodGroup"].ToString();
                    employee.BloodGroup = dr["BloodGroup"].ToString();

                    employeeList.Add(employee);
                }
                return employeeList;
            }*/