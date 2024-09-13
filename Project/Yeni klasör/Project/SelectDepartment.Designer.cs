namespace Project
{
    partial class SelectDepartment
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.financeButton = new System.Windows.Forms.Button();
            this.hrButton = new System.Windows.Forms.Button();
            this.managementButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.financeButton);
            this.panel1.Controls.Add(this.hrButton);
            this.panel1.Controls.Add(this.managementButton);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(423, 482);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::Project.Properties.Resources.pngwing_com__3__cutout;
            this.pictureBox1.Location = new System.Drawing.Point(360, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 55);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // financeButton
            // 
            this.financeButton.BackColor = System.Drawing.Color.ForestGreen;
            this.financeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.financeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.financeButton.ForeColor = System.Drawing.Color.White;
            this.financeButton.Location = new System.Drawing.Point(86, 313);
            this.financeButton.Name = "financeButton";
            this.financeButton.Size = new System.Drawing.Size(244, 50);
            this.financeButton.TabIndex = 2;
            this.financeButton.Text = "FINANCE";
            this.financeButton.UseVisualStyleBackColor = false;
            this.financeButton.Click += new System.EventHandler(this.financeButton_Click);
            this.financeButton.MouseEnter += new System.EventHandler(this.financeButton_MouseEnter);
            this.financeButton.MouseLeave += new System.EventHandler(this.financeButton_MouseLeave);
            // 
            // hrButton
            // 
            this.hrButton.BackColor = System.Drawing.Color.ForestGreen;
            this.hrButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hrButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hrButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hrButton.ForeColor = System.Drawing.Color.White;
            this.hrButton.Location = new System.Drawing.Point(86, 204);
            this.hrButton.Name = "hrButton";
            this.hrButton.Size = new System.Drawing.Size(244, 50);
            this.hrButton.TabIndex = 1;
            this.hrButton.Text = "HUMAN RESOURCES";
            this.hrButton.UseVisualStyleBackColor = false;
            this.hrButton.Click += new System.EventHandler(this.hrButton_Click);
            this.hrButton.MouseEnter += new System.EventHandler(this.hrButton_MouseEnter);
            this.hrButton.MouseLeave += new System.EventHandler(this.hrButton_MouseLeave);
            // 
            // managementButton
            // 
            this.managementButton.BackColor = System.Drawing.Color.ForestGreen;
            this.managementButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managementButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.managementButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.managementButton.ForeColor = System.Drawing.Color.White;
            this.managementButton.Location = new System.Drawing.Point(86, 95);
            this.managementButton.Name = "managementButton";
            this.managementButton.Size = new System.Drawing.Size(244, 50);
            this.managementButton.TabIndex = 0;
            this.managementButton.Text = "MANAGEMENT";
            this.managementButton.UseVisualStyleBackColor = false;
            this.managementButton.Click += new System.EventHandler(this.managementButton_Click);
            this.managementButton.MouseEnter += new System.EventHandler(this.managementButton_MouseEnter);
            this.managementButton.MouseLeave += new System.EventHandler(this.managementButton_MouseLeave);
            // 
            // SelectDepartment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(419, 480);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SelectDepartment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectDepartment";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button hrButton;
        private System.Windows.Forms.Button managementButton;
        private System.Windows.Forms.Button financeButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}