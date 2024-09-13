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
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turnbackButton_Click(object sender, EventArgs e)
        {
            SelectDepartment selectDepartment = new SelectDepartment();
            selectDepartment.Show();
            this.Hide();
        }
    }
}
