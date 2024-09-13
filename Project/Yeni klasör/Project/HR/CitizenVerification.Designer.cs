namespace Project.HR
{
    partial class CitizenVerification
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tcNoTb = new System.Windows.Forms.TextBox();
            this.birthYearTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.controlButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.situationLabel = new System.Windows.Forms.Label();
            this.situationColor = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tcNoTb
            // 
            this.tcNoTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.tcNoTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tcNoTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tcNoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcNoTb.ForeColor = System.Drawing.Color.White;
            this.tcNoTb.Location = new System.Drawing.Point(184, 146);
            this.tcNoTb.Multiline = true;
            this.tcNoTb.Name = "tcNoTb";
            this.tcNoTb.Size = new System.Drawing.Size(276, 25);
            this.tcNoTb.TabIndex = 53;
            this.tcNoTb.Text = "TC No";
            this.tcNoTb.Enter += new System.EventHandler(this.tcNoTb_Enter);
            // 
            // birthYearTb
            // 
            this.birthYearTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.birthYearTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthYearTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.birthYearTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.birthYearTb.ForeColor = System.Drawing.Color.White;
            this.birthYearTb.Location = new System.Drawing.Point(184, 303);
            this.birthYearTb.Multiline = true;
            this.birthYearTb.Name = "birthYearTb";
            this.birthYearTb.Size = new System.Drawing.Size(276, 25);
            this.birthYearTb.TabIndex = 52;
            this.birthYearTb.Text = "Birth Year";
            this.birthYearTb.Enter += new System.EventHandler(this.birthYearTb_Enter);
            // 
            // surnameTb
            // 
            this.surnameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.surnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTb.ForeColor = System.Drawing.Color.White;
            this.surnameTb.Location = new System.Drawing.Point(184, 250);
            this.surnameTb.Multiline = true;
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(276, 25);
            this.surnameTb.TabIndex = 51;
            this.surnameTb.Text = "Surname";
            this.surnameTb.Enter += new System.EventHandler(this.surnameTb_Enter);
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTb.ForeColor = System.Drawing.Color.White;
            this.nameTb.Location = new System.Drawing.Point(184, 197);
            this.nameTb.Multiline = true;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(276, 25);
            this.nameTb.TabIndex = 50;
            this.nameTb.Text = "Name";
            this.nameTb.Enter += new System.EventHandler(this.nameTb_Enter);
            // 
            // controlButton
            // 
            this.controlButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.controlButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.controlButton.Location = new System.Drawing.Point(184, 373);
            this.controlButton.Name = "controlButton";
            this.controlButton.Size = new System.Drawing.Size(276, 52);
            this.controlButton.TabIndex = 54;
            this.controlButton.Text = "Control";
            this.controlButton.UseVisualStyleBackColor = false;
            this.controlButton.Click += new System.EventHandler(this.controlButton_Click);
            this.controlButton.MouseEnter += new System.EventHandler(this.controlButton_MouseEnter);
            this.controlButton.MouseLeave += new System.EventHandler(this.controlButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(179, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 29);
            this.label1.TabIndex = 55;
            this.label1.Text = "Citizen Verification System";
            // 
            // situationLabel
            // 
            this.situationLabel.AutoSize = true;
            this.situationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.situationLabel.ForeColor = System.Drawing.Color.Black;
            this.situationLabel.Location = new System.Drawing.Point(179, 465);
            this.situationLabel.Name = "situationLabel";
            this.situationLabel.Size = new System.Drawing.Size(136, 26);
            this.situationLabel.TabIndex = 56;
            this.situationLabel.Text = "SITUATION";
            // 
            // situationColor
            // 
            this.situationColor.AutoSize = true;
            this.situationColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.situationColor.ForeColor = System.Drawing.Color.Black;
            this.situationColor.Location = new System.Drawing.Point(128, 444);
            this.situationColor.Name = "situationColor";
            this.situationColor.Size = new System.Drawing.Size(56, 76);
            this.situationColor.TabIndex = 57;
            this.situationColor.Text = "•";
            // 
            // CitizenVerification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(908, 583);
            this.Controls.Add(this.situationColor);
            this.Controls.Add(this.situationLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.controlButton);
            this.Controls.Add(this.tcNoTb);
            this.Controls.Add(this.birthYearTb);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.nameTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CitizenVerification";
            this.Text = "CitizenVerification";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tcNoTb;
        private System.Windows.Forms.TextBox birthYearTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.Button controlButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label situationLabel;
        private System.Windows.Forms.Label situationColor;
    }
}