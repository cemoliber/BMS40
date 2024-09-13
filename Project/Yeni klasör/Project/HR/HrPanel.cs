using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HR
{
    public partial class HrPanel : Form
    {
        public void AddControls(Form f)
        {
            centerPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            centerPanel.Controls.Add(f);
            f.Show();
        }

        public HrPanel()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddControls(new NewEmployee());
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
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
            }else
            {
                //dont to anything
            }
            
        }

        private void credentialVerification_Click(object sender, EventArgs e)
        {
          
            AddControls(new CitizenVerification());
        }

        private void allEmployeesButton_Click(object sender, EventArgs e)
        {
            AddControls(new AllEmployees());
        }

        private void graphButton_Click(object sender, EventArgs e)
        {
            AddControls(new Graph());
        }
    }
}
