namespace Project.HR
{
    partial class HrPanel
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HrPanel));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.credentialVerification = new System.Windows.Forms.Button();
            this.allEmployeesButton = new System.Windows.Forms.Button();
            this.newEmployeeButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panelMain.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.centerPanel);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1560, 887);
            this.panelMain.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(222, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 59);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1264, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(417, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "HUMAN RESOURCES ADMIN PANEL";
            // 
            // centerPanel
            // 
            this.centerPanel.Location = new System.Drawing.Point(222, 56);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Size = new System.Drawing.Size(1338, 831);
            this.centerPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.credentialVerification);
            this.panel1.Controls.Add(this.allEmployeesButton);
            this.panel1.Controls.Add(this.newEmployeeButton);
            this.panel1.Controls.Add(this.graphButton);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 1043);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::Project.Properties.Resources.u_turn_cutout;
            this.pictureBox2.Location = new System.Drawing.Point(6, 821);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 55);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // credentialVerification
            // 
            this.credentialVerification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.credentialVerification.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.credentialVerification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.credentialVerification.ForeColor = System.Drawing.Color.White;
            this.credentialVerification.Location = new System.Drawing.Point(6, 530);
            this.credentialVerification.Name = "credentialVerification";
            this.credentialVerification.Size = new System.Drawing.Size(218, 51);
            this.credentialVerification.TabIndex = 5;
            this.credentialVerification.Text = "Verification";
            this.credentialVerification.UseVisualStyleBackColor = true;
            this.credentialVerification.Click += new System.EventHandler(this.credentialVerification_Click);
            // 
            // allEmployeesButton
            // 
            this.allEmployeesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.allEmployeesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allEmployeesButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.allEmployeesButton.ForeColor = System.Drawing.Color.White;
            this.allEmployeesButton.Location = new System.Drawing.Point(6, 442);
            this.allEmployeesButton.Name = "allEmployeesButton";
            this.allEmployeesButton.Size = new System.Drawing.Size(218, 51);
            this.allEmployeesButton.TabIndex = 4;
            this.allEmployeesButton.Text = "All Employees";
            this.allEmployeesButton.UseVisualStyleBackColor = true;
            this.allEmployeesButton.Click += new System.EventHandler(this.allEmployeesButton_Click);
            // 
            // newEmployeeButton
            // 
            this.newEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.newEmployeeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newEmployeeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.newEmployeeButton.ForeColor = System.Drawing.Color.White;
            this.newEmployeeButton.Location = new System.Drawing.Point(6, 354);
            this.newEmployeeButton.Name = "newEmployeeButton";
            this.newEmployeeButton.Size = new System.Drawing.Size(218, 51);
            this.newEmployeeButton.TabIndex = 3;
            this.newEmployeeButton.Text = "New Employee";
            this.newEmployeeButton.UseVisualStyleBackColor = true;
            this.newEmployeeButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // graphButton
            // 
            this.graphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.graphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.graphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.graphButton.ForeColor = System.Drawing.Color.White;
            this.graphButton.Location = new System.Drawing.Point(6, 266);
            this.graphButton.Name = "graphButton";
            this.graphButton.Size = new System.Drawing.Size(218, 51);
            this.graphButton.TabIndex = 2;
            this.graphButton.Text = "Graph";
            this.graphButton.UseVisualStyleBackColor = true;
            this.graphButton.Click += new System.EventHandler(this.graphButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Project.Properties.Resources.dolphin;
            this.pictureBox1.Location = new System.Drawing.Point(6, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // HrPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1560, 887);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HrPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HUMAN RESOURCES - BMS 4.0";
            this.panelMain.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button credentialVerification;
        private System.Windows.Forms.Button allEmployeesButton;
        private System.Windows.Forms.Button newEmployeeButton;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel panel2;
    }
}