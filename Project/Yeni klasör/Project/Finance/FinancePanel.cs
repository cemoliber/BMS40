using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Finance
{
    public partial class FinancePanel : Form
    {
        public FinancePanel()
        {
            InitializeComponent();
        }

        public void AddControls(Form f)
        {
            mainPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            mainPanel.Controls.Add(f);
            f.Show();
        }


        private void purchaseButton_Click(object sender, EventArgs e)
        {
            //Opens Purchase page
            AddControls(new Purchase());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            //Turn off the application
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Sayfayı Kapatmak İstediğinizden Emin Misiniz?", "Departmandan Çıkış", MessageBoxButtons.YesNo);
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

        private void saleButton_Click(object sender, EventArgs e)
        {
            //Opens Sale page
            AddControls(new Sale());
        }

        private void paymentsButton_Click(object sender, EventArgs e)
        {
            //Opens Payments page
            AddControls(new Payments());
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            //Opens GraphFinance Page
            AddControls(new GraphFinance());
        }

        private void purchaseTableButton_Click(object sender, EventArgs e)
        {
            //Opens PurchaseTable Page
            AddControls(new PurchaseTable());
        }
    }
}
