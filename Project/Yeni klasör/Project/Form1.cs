using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Project
{
    public partial class Form1 : Form
    {
        private SoundPlayer _soundPlayer;
        public Form1()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("loginIntro.wav");
            _soundPlayer.Play();
            progressBar1.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            percentLbl.Text = progressBar1.Value.ToString() + "%";
            timer1.Enabled = true;
            progressBar1.Increment(3);    
            if (progressBar1.Value == 100)
            {
                timer1.Enabled = false;
                SelectDepartment departments = new SelectDepartment();
                departments.Show();
                this.Hide();
            }
        }
    }
}
