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
    public partial class SaleTable : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-91IMOEI\\SQLEXPRESS;Initial Catalog=DatabaseBMS;Integrated Security=True;Pooling=False;Encrypt=True;TrustServerCertificate=true");
        public SaleTable()
        {
            InitializeComponent();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Sale", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                saleDataGridView.DataSource = dt;
                con.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("Occured a Error While Datas Loading!", "Warning", MessageBoxButtons.OK);
            }

        }

        

        private void saleDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //getting ID of selected row
            int index = e.RowIndex;
            DataGridViewRow selectedRows = saleDataGridView.Rows[index];
            tbRows.Text = selectedRows.Cells[0].Value.ToString();
        }

        private void deleteButton_Enter(object sender, EventArgs e)
        {
            deleteButtonSale.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void deleteButton_Leave(object sender, EventArgs e)
        {
            deleteButtonSale.BackColor = Color.Red;
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //this method is for deleting a selected row
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete Sale where Id =" + tbRows.Text, con);
            cmd.ExecuteNonQuery();

            //this method is refresh the table
            SqlCommand cmd2 = new SqlCommand("Select * From Sale", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd2);
            DataTable dt = new DataTable();
            da.Fill(dt);
            saleDataGridView.DataSource = dt;

            con.Close();
            MessageBox.Show("Sale Deleted Succesfully");
        }

        private void saleDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
             
            int index = e.RowIndex;
            DataGridViewRow selectedRows = saleDataGridView.Rows[index];
            tbRows.Text = selectedRows.Cells[0].Value.ToString();

            string id = tbRows.Text;

            UpdateSale updateSale = new UpdateSale(id);
            updateSale.Show();

            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

            try
            {
                //Shows all datas
                if (searchCb.SelectedItem.Equals("ALL DATAS"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Sale", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by id
                if (searchCb.SelectedItem.Equals("ID"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Id LIKE @Id", con);
                    sqlCommand.Parameters.AddWithValue("@Id", "%" + int.Parse(searchTb.Text) + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Product Name
                if (searchCb.SelectedItem.Equals("PRODUCT"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Product LIKE @Product", con);
                    sqlCommand.Parameters.AddWithValue("@Product", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //Filter by Count
                if (searchCb.SelectedItem.Equals("COUNT"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Sale Where Count LIKE @Count", con);
                    cmd.Parameters.AddWithValue("@Count", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Unit Price
                if (searchCb.SelectedItem.Equals("UNIT PRICE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Unitprice LIKE @Unitprice", con);
                    sqlCommand.Parameters.AddWithValue("@Unitprice", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Total Price
                if (searchCb.SelectedItem.Equals("TOTAL PRICE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Totalprice LIKE @Totalprice", con);
                    sqlCommand.Parameters.AddWithValue("@Totalprice", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //Filter by Movement Location
                if (searchCb.SelectedItem.Equals("MOVEMENT LOCATION"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Sale Where Movementlocation LIKE @Movementlocation", con);
                    cmd.Parameters.AddWithValue("@Movementlocation", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Arrival Location
                if (searchCb.SelectedItem.Equals("ARRIVAL LOCATION"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Arrivallocation LIKE @Arrivallocation", con);
                    sqlCommand.Parameters.AddWithValue("@Arrivallocation", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Customer Company
                if (searchCb.SelectedItem.Equals("CUSTOMER COMPANY"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Company LIKE @Company", con);
                    sqlCommand.Parameters.AddWithValue("@Company", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //Fiter by Company Number
                if (searchCb.SelectedItem.Equals("COMPANY NUMBER"))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand("Select * From Sale Where Companynumber LIKE @Companynumber", con);
                    cmd.Parameters.AddWithValue("@Companynumber", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Transporter Name
                if (searchCb.SelectedItem.Equals("TRANPORTER NAME"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Transportername LIKE @Transportername", con);
                    sqlCommand.Parameters.AddWithValue("@Transportername", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Transporter Number
                if (searchCb.SelectedItem.Equals("TRANSPORTER NUMBER"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Transporternumber LIKE @Transporternumber", con);
                    sqlCommand.Parameters.AddWithValue("@Transporternumber", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Transport Type
                if (searchCb.SelectedItem.Equals("TRANSPORT TYPE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Transporttype LIKE @Transporttype", con);
                    sqlCommand.Parameters.AddWithValue("@Transporttype", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Transport Status
                if (searchCb.SelectedItem.Equals("TRANSPORT STATUS"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Transportstatus LIKE @Transportstatus", con);
                    sqlCommand.Parameters.AddWithValue("@Transportstatus", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by Agreement Date
                if (searchCb.SelectedItem.Equals("AGREEMENT DATE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Agreementdate LIKE @Agreementdate", con);
                    sqlCommand.Parameters.AddWithValue("@Agreementdate", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

                //fiter by name
                if (searchCb.SelectedItem.Equals("ESTIMATED DATE"))
                {
                    con.Open();
                    SqlCommand sqlCommand = new SqlCommand("Select * From Sale Where Estimateddate LIKE @Estimateddate", con);
                    sqlCommand.Parameters.AddWithValue("@Estimateddate", "%" + searchTb.Text + "%");
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    saleDataGridView.DataSource = dt;
                    con.Close();
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Occured a Error While Datas Searching!", "Warning", MessageBoxButtons.OK);
            }
        }

        private void createCsvButton_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand sqlCmd = new SqlCommand("Select * from Sale", con);
            SqlDataReader reader = sqlCmd.ExecuteReader();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*",
                Title = "CSV dosyasını kaydet",
                FileName = "sales.csv"
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
