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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Project.Finance
{
    public partial class FinanceLogin : Form
    {
        private SoundPlayer _soundPlayer;
        private SoundPlayer _soundPlayer2;
        public FinanceLogin()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("loginSound.wav");
            _soundPlayer2 = new SoundPlayer("error.wav");
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            String username = "a";
            String password = "a";

            if (username == usernameTb.Text.ToString() && password == passwordTb.Text.ToString())
            {
                _soundPlayer.Play();
                FinancePanel financePanel = new FinancePanel();
                financePanel.Show();
                this.Hide();
            }
            else
            {
                _soundPlayer2.Play();
                MessageBox.Show("Kullanıcı Adı Veya Şifre Yanlış!", "Dikkat", MessageBoxButtons.OK);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void turnBack_Click(object sender, EventArgs e)
        {
            SelectDepartment selectDepartment = new SelectDepartment();
            selectDepartment.Show();
            this.Hide();
        }

        private void loginButton_Enter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void loginButton_Leave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
        }
    }
}
