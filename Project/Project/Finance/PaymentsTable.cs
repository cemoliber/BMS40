using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Finance
{
    public partial class PaymentsTable : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");

        public PaymentsTable()
        {
            InitializeComponent();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Payments", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                paymentDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Occured a Error While Datas Loading!", "Warning", MessageBoxButtons.OK);
            }

        }


        private void paymentDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting ID of selected row
            int index = e.RowIndex;
            DataGridViewRow selectedRows = paymentDataGridView.Rows[index];
            tbRows.Text = selectedRows.Cells[0].Value.ToString();
        }

        private void deleteButton_Enter(object sender, EventArgs e)
        {
            deleteButtonPayments.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void deleteButton_Leave(object sender, EventArgs e)
        {
            deleteButtonPayments.BackColor = Color.Red;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //this method is for deleting a selected row
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Payments where Id =" + tbRows.Text, con);
            cmd.ExecuteNonQuery();

            //this method is refresh the table
            SqlCommand cmd2 = new SqlCommand("Select * From Payments", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            paymentDataGridView.DataSource = dt;

            con.Close();
            MessageBox.Show("Payment Deleted Succesfully");
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {

                //Shows all datas
                if (searchCb.SelectedItem.Equals("ALL DATAS"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Payments", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    con.Close();
                }
                
                //fiter by id
                if (searchCb.SelectedItem.Equals("ID"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Payments Where Id LIKE @Id", con);
                    sqlCommand.Parameters.AddWithValue("@Id", "%" + int.Parse(searchTb.Text) + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Product Name
                if (searchCb.SelectedItem.Equals("PAYMENT INSTITUON"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Payments Where Paymentinstitution LIKE @Paymentinstitution", con);
                    sqlCommand.Parameters.AddWithValue("@Paymentinstitution", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    con.Close();
                }

                //Filter by Count
                if (searchCb.SelectedItem.Equals("AMOUNT PAID"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Payments Where Amountpaid LIKE @Amountpaid", con);
                    cmd.Parameters.AddWithValue("@Amountpaid", "%" + float.Parse(searchTb.Text) + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Unit Price
                if (searchCb.SelectedItem.Equals("BILL TYPE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Payments Where Billtype LIKE @Billtype", con);
                    sqlCommand.Parameters.AddWithValue("@Billtype", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Total Price
                if (searchCb.SelectedItem.Equals("PAYMENT METHOD"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Payments Where Paymentmethod LIKE @Paymentmethod", con);
                    sqlCommand.Parameters.AddWithValue("@Paymentmethod", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    con.Close();
                }

                //Filter by Movement Location
                if (searchCb.SelectedItem.Equals("PAYMENT DATE"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Payments Where Paymentdate LIKE @Paymentdate", con);
                    cmd.Parameters.AddWithValue("@Paymentdate", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Arrival Location
                if (searchCb.SelectedItem.Equals("PAID DATE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Payments Where Paiddate LIKE @Paiddate", con);
                    sqlCommand.Parameters.AddWithValue("@Paiddate", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    paymentDataGridView.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Occured a Error While Datas Searching!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void paymentDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRows = paymentDataGridView.Rows[index];
            tbRows.Text = selectedRows.Cells[0].Value.ToString();

            string id = tbRows.Text;

            UpdatePayments update = new UpdatePayments(id);
            update.Show();
        }

        private void createCsvButton_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand sqlCmd = new SqlCommand("Select * from Payments", con);
            SqlDataReader reader = sqlCmd.ExecuteReader();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "CSV dosyasını kaydet",
                FileName = "payments.csv"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                using (StreamWriter sw = new StreamWriter(fileName))
                {
                    object[] output = new object[reader.FieldCount];

                    // Başlıkları yazma
                    for (int i = 0; i < reader.FieldCount; i++)
                        output[i] = reader.GetName(i);

                    sw.WriteLine(string.Join(",", output));

                    // Verileri yazma
                    while (reader.Read())
                    {
                        reader.GetValues(output);
                        sw.WriteLine(string.Join(",", output));
                    }
                }

                MessageBox.Show("CSV dosyası başarıyla kaydedildi.");
            }

            reader.Close();
            con.Close();
        }
    }
}
