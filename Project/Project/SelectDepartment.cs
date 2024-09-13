using Project.Finance;
using Project.HR;
using Project.Management;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class SelectDepartment : Form
    {
        public SelectDepartment()
        {
            InitializeComponent();
        }

        //go to management panel
        private void managementButton_Click(object sender, EventArgs e)
        {
            ManagementLogin management = new ManagementLogin();
            management.Show();
            this.Hide();
        }

        //go to hr panel
        private void hrButton_Click(object sender, EventArgs e)
        {
            HrLogin hrlogin = new HrLogin();
            hrlogin.Show();
            this.Hide();
        }

        //go to finance panel
        private void financeButton_Click(object sender, EventArgs e)
        {
            FinanceLogin financeLogin = new FinanceLogin();
            financeLogin.Show();
            this.Hide();
        }

        private void managementButton_MouseEnter(object sender, EventArgs e)
        {
            managementButton.BackColor = Color.Green;
        }

        private void managementButton_MouseLeave(object sender, EventArgs e)
        {
            managementButton.BackColor = Color.ForestGreen;
        }

        private void financeButton_MouseEnter(object sender, EventArgs e)
        {
            financeButton.BackColor = Color.Green;
        }

        private void financeButton_MouseLeave(object sender, EventArgs e)
        {
            financeButton.BackColor = Color.ForestGreen;
        }

        private void hrButton_MouseEnter(object sender, EventArgs e)
        {
            hrButton.BackColor = Color.Green;
        }

        private void hrButton_MouseLeave(object sender, EventArgs e)
        {
            hrButton.BackColor = Color.ForestGreen;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
