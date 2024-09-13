using Project.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.Management
{
    public partial class ManagementLogin : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer2;
        public ManagementLogin()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("loginIntro.wav");
            _soundPlayer2 = new SoundPlayer("error.wav");
        }

        private void turnoffButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turnBack_Click(object sender, EventArgs e)
        {
            SelectDepartment selectDepartment = new SelectDepartment();
            selectDepartment.Show();
            this.Hide();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = "a";
            String password = "a";

            if (username == usernameTb.Text.ToString() && password == passwordTb.Text.ToString())
            {
                _soundPlayer.Play();
                ManagementPanel managementPanel = new ManagementPanel();
                managementPanel.Show();
                this.Hide();
            }
            else
            {
                _soundPlayer2.Play();
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış!", "Dikkat", MessageBoxButtons.OK);
            }
        }
    }
}
