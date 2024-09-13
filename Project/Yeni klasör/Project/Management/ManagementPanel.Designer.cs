namespace Project.Management
{
    partial class ManagementPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManagementPanel));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.turnbackButton = new System.Windows.Forms.PictureBox();
            this.credentialVerification = new System.Windows.Forms.Button();
            this.financeGraphButton = new System.Windows.Forms.Button();
            this.hrGraphButton = new System.Windows.Forms.Button();
            this.graphButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.sidebarTimer = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panelMain.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnbackButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.panel2);
            this.panelMain.Controls.Add(this.panel1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1470, 879);
            this.panelMain.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Controls.Add(this.turnbackButton);
            this.panel1.Controls.Add(this.credentialVerification);
            this.panel1.Controls.Add(this.financeGraphButton);
            this.panel1.Controls.Add(this.hrGraphButton);
            this.panel1.Controls.Add(this.graphButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(224, 1043);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1174, -1);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(72, 60);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // turnbackButton
            // 
            this.turnbackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.turnbackButton.Image = global::Project.Properties.Resources.u_turn_cutout;
            this.turnbackButton.Location = new System.Drawing.Point(6, 821);
            this.turnbackButton.Name = "turnbackButton";
            this.turnbackButton.Size = new System.Drawing.Size(56, 55);
            this.turnbackButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.turnbackButton.TabIndex = 6;
            this.turnbackButton.TabStop = false;
            this.turnbackButton.Click += new System.EventHandler(this.turnbackButton_Click);
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
            // 
            // financeGraphButton
            // 
            this.financeGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.financeGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.financeGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.financeGraphButton.ForeColor = System.Drawing.Color.White;
            this.financeGraphButton.Location = new System.Drawing.Point(6, 442);
            this.financeGraphButton.Name = "financeGraphButton";
            this.financeGraphButton.Size = new System.Drawing.Size(218, 51);
            this.financeGraphButton.TabIndex = 4;
            this.financeGraphButton.Text = "Finance Graph";
            this.financeGraphButton.UseVisualStyleBackColor = true;
            // 
            // hrGraphButton
            // 
            this.hrGraphButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hrGraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hrGraphButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.hrGraphButton.ForeColor = System.Drawing.Color.White;
            this.hrGraphButton.Location = new System.Drawing.Point(6, 354);
            this.hrGraphButton.Name = "hrGraphButton";
            this.hrGraphButton.Size = new System.Drawing.Size(218, 51);
            this.hrGraphButton.TabIndex = 3;
            this.hrGraphButton.Text = "HR Graph";
            this.hrGraphButton.UseVisualStyleBackColor = true;
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
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(35, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "MANAGEMENT";
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(224, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1338, 59);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1281, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(57, 59);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(417, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(437, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "BUSINESS MANAGEMENT SYSTEM";
            // 
            // ManagementPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1470, 879);
            this.Controls.Add(this.panelMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManagementPanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManagementPanel";
            this.panelMain.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnbackButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox turnbackButton;
        private System.Windows.Forms.Button credentialVerification;
        private System.Windows.Forms.Button financeGraphButton;
        private System.Windows.Forms.Button hrGraphButton;
        private System.Windows.Forms.Button graphButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer sidebarTimer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}