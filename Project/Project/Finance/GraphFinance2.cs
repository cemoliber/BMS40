using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project.Finance
{
    public partial class GraphFinance2 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
        public GraphFinance2()
        {
            InitializeComponent();
            
            con.Open();

            //changing color of buttons when clicked
            lastSevenButton.Click += new EventHandler(lastSevenButton_Click);
            lastThirtyButton.Click += new EventHandler(lastThirtyButton_Click);
            thisYearButton.Click += new EventHandler(thisYearButton_Click);
            customButton.Click += new EventHandler(customButton_Click);

            //clear the charts
            transportTypeChart.Series["Series1"].Points.Clear();
            transportStatusChart.Series["Series1"].Points.Clear();

            float totalRevenue2 = 0;
            float totalCount2 = 0;

            //For total revenue
            string sqlQuery = "SELECT SUM(Totalprice) AS totalRevenue FROM Sale";

            using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
            {
                object result = cmd.ExecuteScalar();

                if(result != DBNull.Value)
                {
                    float totalRevenue = Convert.ToSingle(result);
                    totalRevenue2 = totalRevenue;
                    totalRevenueLbl.Text = totalRevenue.ToString() + " ₺";
                }else
                {
                    Console.WriteLine("No Data Found");
                }
            }

            //For total selling counts
            string sqlQuery2 = "SELECT SUM(Count) AS totalCount FROM Sale";

            using (SqlCommand cmd = new SqlCommand(sqlQuery2, con))
            {
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    float totalCount = Convert.ToSingle(result);
                    totalCount2 = totalCount;
                    totalSellingsLbl.Text = totalCount.ToString();
                }
                else
                {
                    Console.WriteLine("No Data Found");
                }
            }

            //revenue from per unit
            float revenuePerUnit = 0;
            revenuePerUnit = totalRevenue2 / totalCount2;
            revenuePerUnitLbl.Text = revenuePerUnit.ToString() + " ₺";

            //TOTAL PAİD COUNT
            string sqlQuery3 = "SELECT SUM(AmountPaid) AS totalPayments FROM Payments";

            using (SqlCommand cmd = new SqlCommand(sqlQuery3, con))
            {
                object result = cmd.ExecuteScalar();

                if (result != DBNull.Value)
                {
                    float totalCount = Convert.ToSingle(result);
                    totalCount2 = totalCount;
                    amountPaidLbl.Text = totalCount.ToString() + " ₺";
                }
                else
                {
                    Console.WriteLine("No Data Found");
                }
            }

            //TRANSPORT TYPE PYRAMID CHART
            //For Department Graph
            SqlCommand q1 = new SqlCommand("SELECT COUNT(*) FROM Sale Where Transporttype = 'PLANE'", con);
            int d1 = (int)q1.ExecuteScalar();

            SqlCommand q2 = new SqlCommand("SELECT COUNT(*) FROM Sale Where Transporttype = 'SHIP'", con);
            int d2 = (int)q2.ExecuteScalar();

            SqlCommand q3 = new SqlCommand("SELECT COUNT(*) FROM Sale Where Transporttype = 'TRUCK'", con);
            int d3 = (int)q3.ExecuteScalar();

            SqlCommand q4 = new SqlCommand("SELECT COUNT(*) FROM Sale Where Transporttype = 'TRAIN'", con);
            int d4 = (int)q4.ExecuteScalar();

            transportTypeChart.Series["Series1"].Points.AddXY("PLANE", d1);
            transportTypeChart.Series["Series1"].Points.AddXY("SHIP", d2);
            transportTypeChart.Series["Series1"].Points.AddXY("TRUCK", d3);
            transportTypeChart.Series["Series1"].Points.AddXY("TRAIN", d4);


            transportTypeChart.Titles.Add("TRANSPORT TYPE DISTRIBUTION");

            //TRANSPORT STATUS GRAPH
            //For Department Graph
            SqlCommand a1 = new SqlCommand("SELECT COUNT(*) FROM Sale Where Transportstatus = 'PENDING'", con);
            int b1 = (int)a1.ExecuteScalar();

            SqlCommand a2 = new SqlCommand("SELECT COUNT(*) FROM Sale Where Transportstatus = 'IN MOTION'", con);
            int b2 = (int)a2.ExecuteScalar();

            SqlCommand a3 = new SqlCommand("SELECT COUNT(*) FROM Sale Where Transportstatus = 'TRANSFER DONE'", con);
            int b3 = (int)a3.ExecuteScalar();

            transportStatusChart.Series["Series1"].Points.AddXY("PENDING", b1);
            transportStatusChart.Series["Series1"].Points.AddXY("IN MOTION", b2);
            transportStatusChart.Series["Series1"].Points.AddXY("TRANSFER DONE", b3);

            transportStatusChart.Titles.Add("TRANSPORT STATUS DISTRIBUTION");


            //calculating time between two date
            string query = "SELECT CAST(Agreementdate AS DATE) AS agreementDate, CAST(Estimateddate AS DATE) AS estimatedDate FROM Sale Where Transportstatus = 'TRANSFER DONE'";

            SqlCommand query2 = new SqlCommand("SELECT COUNT(*) FROM Sale Where Transportstatus = 'TRANSFER DONE'", con);
            int rowCount = (int)query2.ExecuteScalar();

            Console.WriteLine("AAAA: " + rowCount);

            int totalDaysDifference = 0;

            // SQL sorgusunu çalıştır
            using (SqlCommand command = new SqlCommand(query, con))
            {
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {

                        // Her kayıt için tarihleri al
                        DateTime agreementDate = reader.GetDateTime(reader.GetOrdinal("agreementDate"));
                        DateTime estimatedDate = reader.GetDateTime(reader.GetOrdinal("estimatedDate"));

                        // Tarih farkını hesapla
                        TimeSpan timeDifference = estimatedDate - agreementDate;
                        totalDaysDifference = timeDifference.Days;

                    }
                }
            }

            float performanceData = 0;
            performanceData = totalDaysDifference / rowCount;

            transportationPerformanceLbl.Text = performanceData.ToString();


            con.Close();

    }

        //REVENUE BY LAST 7 DAYS
        private void lastSevenButton_Click(object sender, EventArgs e)
        {
            //change color of button when clicked
            lastSevenButton.BackColor = Color.White;
            lastSevenButton.ForeColor = Color.Black;

            //other buttons
            lastThirtyButton.BackColor = Color.DarkBlue;
            lastThirtyButton.ForeColor = Color.White;
            thisYearButton.BackColor = Color.DarkBlue;
            thisYearButton.ForeColor = Color.White;
            customButton.BackColor = Color.DarkBlue;
            customButton.ForeColor = Color.White;

            con.Open();
            revenueChart.Series["Series1"].Points.Clear();

            DateTime currentDate = DateTime.Now;
            DateTime sevenDaysAgo = currentDate.AddDays(-7);

            // SQL sorgusu
            string sqlQuery = @"
            SELECT 
                CAST(Agreementdate AS DATE) AS SaleDate, 
                SUM(Totalprice) AS TotalSales 
            FROM Sale 
            WHERE Agreementdate BETWEEN @StartDate AND @EndDate 
            GROUP BY CAST(Agreementdate AS DATE)
            ORDER BY SaleDate";


            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                command.Parameters.AddWithValue("@StartDate", sevenDaysAgo);
                command.Parameters.AddWithValue("@EndDate", currentDate);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0); // 0. sütun SaleDate
                        double totalSales = reader.GetDouble(1); // 1. sütun TotalSales
                        revenueChart.Series["Series1"].Points.AddXY(date, totalSales);
                    }
                }
            }


            // Chart ayarları
            revenueChart.Series["Series1"].ChartType = SeriesChartType.SplineArea;
            revenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            revenueChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            revenueChart.ChartAreas[0].AxisX.Interval = 1;
            revenueChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            revenueChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // Grafiği yeniden çiz
            revenueChart.Invalidate();

            con.Close();
        }

        //REVENUE BY LAST 30 DAYS
        private void lastThirtyButton_Click(object sender, EventArgs e)
        {

            //change color of button when clicked
            lastThirtyButton.BackColor = Color.White;
            lastThirtyButton.ForeColor = Color.Black;

            //other buttons
            lastSevenButton.BackColor = Color.DarkBlue;
            lastSevenButton.ForeColor = Color.White;
            thisYearButton.BackColor = Color.DarkBlue;
            thisYearButton.ForeColor = Color.White;
            customButton.BackColor = Color.DarkBlue;
            customButton.ForeColor = Color.White;

            con.Open();
            revenueChart.Series["Series1"].Points.Clear();

            DateTime currentDate = DateTime.Now;
            DateTime sevenDaysAgo = currentDate.AddDays(-30);

            // SQL sorgusu
            string sqlQuery = @"
            SELECT 
                CAST(Agreementdate AS DATE) AS SaleDate, 
                SUM(Totalprice) AS TotalSales 
            FROM Sale 
            WHERE Agreementdate BETWEEN @StartDate AND @EndDate 
            GROUP BY CAST(Agreementdate AS DATE)
            ORDER BY SaleDate";


            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                command.Parameters.AddWithValue("@StartDate", sevenDaysAgo);
                command.Parameters.AddWithValue("@EndDate", currentDate);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0); // 0. sütun SaleDate
                        double totalSales = reader.GetDouble(1); // 1. sütun TotalSales
                        revenueChart.Series["Series1"].Points.AddXY(date, totalSales);
                    }
                }
            }


            // Chart ayarları
            revenueChart.Series["Series1"].ChartType = SeriesChartType.SplineArea;
            revenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            revenueChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Days;
            revenueChart.ChartAreas[0].AxisX.Interval = 3;
            revenueChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            revenueChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // Grafiği yeniden çiz
            revenueChart.Invalidate();

            con.Close();
        }

        //REVENUE BY LAST 365 DAYS
        private void thisYearButton_Click(object sender, EventArgs e)
        {
            //change color of button when clicked
            thisYearButton.BackColor = Color.White;
            thisYearButton.ForeColor = Color.Black;

            //other buttons
            lastSevenButton.BackColor = Color.DarkBlue;
            lastSevenButton.ForeColor = Color.White;
            lastThirtyButton.BackColor = Color.DarkBlue;
            lastThirtyButton.ForeColor = Color.White;
            customButton.BackColor = Color.DarkBlue;
            customButton.ForeColor = Color.White;


            con.Open();
            revenueChart.Series["Series1"].Points.Clear();

            DateTime currentDate = DateTime.Now;
            DateTime sevenDaysAgo = currentDate.AddDays(-365);

            // SQL sorgusu
            string sqlQuery = @"
            SELECT 
                CAST(Agreementdate AS DATE) AS SaleDate, 
                SUM(Totalprice) AS TotalSales 
            FROM Sale 
            WHERE Agreementdate BETWEEN @StartDate AND @EndDate 
            GROUP BY CAST(Agreementdate AS DATE)
            ORDER BY SaleDate";


            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                command.Parameters.AddWithValue("@StartDate", sevenDaysAgo);
                command.Parameters.AddWithValue("@EndDate", currentDate);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0); // 0. sütun SaleDate
                        double totalSales = reader.GetDouble(1); // 1. sütun TotalSales
                        revenueChart.Series["Series1"].Points.AddXY(date, totalSales);
                    }
                }
            }


            // Chart ayarları
            revenueChart.Series["Series1"].ChartType = SeriesChartType.SplineArea;
            revenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            revenueChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            revenueChart.ChartAreas[0].AxisX.Interval = 1;
            revenueChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            revenueChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // Grafiği yeniden çiz
            revenueChart.Invalidate();

            con.Close();
        }

        //REVENUE BY CUSTOM DAYS
        private void customButton_Click(object sender, EventArgs e)
        {
            //change color of button when clicked
            customButton.BackColor = Color.White;
            customButton.ForeColor = Color.Black;

            //other buttons
            lastSevenButton.BackColor = Color.DarkBlue;
            lastSevenButton.ForeColor = Color.White;
            lastThirtyButton.BackColor = Color.DarkBlue;
            lastThirtyButton.ForeColor = Color.White;
            thisYearButton.BackColor = Color.DarkBlue;
            thisYearButton.ForeColor = Color.White;

            con.Open();
            revenueChart.Series["Series1"].Points.Clear();

            DateTime startDate = startDatePicker.Value;
            DateTime endDate = endDatePicker.Value;

            // SQL sorgusu
            string sqlQuery = @"
            SELECT 
                CAST(Agreementdate AS DATE) AS SaleDate, 
                SUM(Totalprice) AS TotalSales 
            FROM Sale 
            WHERE Agreementdate BETWEEN @StartDate AND @EndDate 
            GROUP BY CAST(Agreementdate AS DATE)
            ORDER BY SaleDate";


            using (SqlCommand command = new SqlCommand(sqlQuery, con))
            {
                command.Parameters.AddWithValue("@StartDate", startDate);
                command.Parameters.AddWithValue("@EndDate", endDate);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        DateTime date = reader.GetDateTime(0); // 0. sütun SaleDate
                        double totalSales = reader.GetDouble(1); // 1. sütun TotalSales
                        revenueChart.Series["Series1"].Points.AddXY(date, totalSales);
                    }
                }
            }


            // Chart ayarları
            revenueChart.Series["Series1"].ChartType = SeriesChartType.SplineArea;
            revenueChart.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy-MM-dd";
            revenueChart.ChartAreas[0].AxisX.IntervalType = DateTimeIntervalType.Months;
            revenueChart.ChartAreas[0].AxisX.Interval = 1;
            revenueChart.ChartAreas[0].AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            revenueChart.ChartAreas[0].AxisY.MajorGrid.LineColor = System.Drawing.Color.LightGray;

            // Grafiği yeniden çiz
            revenueChart.Invalidate();

            con.Close();
        }
    }
}
