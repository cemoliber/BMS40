using Project.Finance;
using Project.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Management
{
    public partial class ManagementPanel : Form
    {

        public ManagementPanel()
        {
            InitializeComponent();

            AddControls(new GraphFinance2());
        }


        public void AddControls(Form f)
        {
            mainPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turnbackButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are You Sure?", "Turn Off Department", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                SelectDepartment selectDepartment = new SelectDepartment();
                selectDepartment.Show();
                this.Hide();
            }
            else
            {
                //dont to anything
            }
        }

        private void financeGraphButton_Click(object sender, EventArgs e)
        {
            //Opens GraphFinance Page
            AddControls(new GraphFinance2());
        }

        private void hrGraphButton_Click(object sender, EventArgs e)
        {
            //Opens Grahp HR Page
            AddControls(new Graph());
        }

        private void saleTableButton_Click(object sender, EventArgs e)
        {
            //Opens Sale Table Page
            AddControls(new SaleTable());
        }

        private void purchaseTableButton_Click(object sender, EventArgs e)
        {
            //Opens Purchase Table Page
            AddControls(new PurchaseTable());
        }

        private void paymentsTableButton_Click(object sender, EventArgs e)
        {
            //Opens Payments Table Page
            AddControls(new PaymentsTable());
        }

        private void allEmployeesButton_Click(object sender, EventArgs e)
        {
            //Open All Employees Page
            AddControls(new AllEmployees());
        }
    }
}
