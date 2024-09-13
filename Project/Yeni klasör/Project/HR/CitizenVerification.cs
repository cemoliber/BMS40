using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.HR
{
    public partial class CitizenVerification : Form
    {
        public CitizenVerification()
        {
            InitializeComponent();
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            long no = long.Parse(tcNoTb.Text);
            int year = int.Parse(birthYearTb.Text);
            bool situation;

            try
            {
                using(TcVerification.KPSPublicSoapClient service = new
                    TcVerification.KPSPublicSoapClient()) {
                    situation = service.TCKimlikNoDogrula(no, nameTb.Text, surnameTb.Text, year);

                
                };
            }
            catch (Exception)
            {

                throw;
            }

            if(situation == true)
            {
                string message = "CITIZEN INFORMATION IS CORRECT.";
                situationLabel.ForeColor = System.Drawing.Color.Green;
                situationColor.ForeColor = System.Drawing.Color.Green;
                if (situationLabel != null)
                {
                    situationLabel.Text = "";            
                    situationLabel.Text = message;
                }
                else
                {
                    situationLabel.Text = message;
                }
                
            }
            else
            {
                string message2 = "CITIZEN INFORMATION IS NOT CORRECT.";
                situationLabel.ForeColor = System.Drawing.Color.Red;
                situationColor.ForeColor = System.Drawing.Color.Red;
                if (situationLabel != null)
                {
                    situationLabel.Text = "";
                    situationLabel.Text = message2;
                }
                else
                {
                    situationLabel.Text = message2;
                }
            }
        }

        private void tcNoTb_Enter(object sender, EventArgs e)
        {
            if (tcNoTb.Text == "TC No")
            {
                tcNoTb.Text = "";
                tcNoTb.ForeColor = Color.White;
            }
        }

        private void nameTb_Enter(object sender, EventArgs e)
        {
            if (nameTb.Text == "Name")
            {
                nameTb.Text = "";
                nameTb.ForeColor = Color.White;
            }
        }

        private void surnameTb_Enter(object sender, EventArgs e)
        {
            if (surnameTb.Text == "Surname")
            {
                surnameTb.Text = "";
                surnameTb.ForeColor = Color.White;
            }
        }

        private void birthYearTb_Enter(object sender, EventArgs e)
        {
            if (birthYearTb.Text == "Birth Year")
            {
                birthYearTb.Text = "";
                birthYearTb.ForeColor = Color.White;
            }
        }

        private void controlButton_MouseEnter(object sender, EventArgs e)
        {
            controlButton.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
        }

        private void controlButton_MouseLeave(object sender, EventArgs e)
        {
            controlButton.BackColor = Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
        }
    }
}
