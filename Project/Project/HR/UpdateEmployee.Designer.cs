namespace Project.HR
{
    partial class UpdateEmployee
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
            this.updateButton = new System.Windows.Forms.Button();
            this.locationTb = new System.Windows.Forms.TextBox();
            this.phoneTb = new System.Windows.Forms.TextBox();
            this.IdTb = new System.Windows.Forms.TextBox();
            this.ageTb = new System.Windows.Forms.TextBox();
            this.surnameTb = new System.Windows.Forms.TextBox();
            this.nameTb = new System.Windows.Forms.TextBox();
            this.startingDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.birthDate = new System.Windows.Forms.DateTimePicker();
            this.bloodGroupCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.genderCb = new System.Windows.Forms.ComboBox();
            this.wageTb = new System.Windows.Forms.TextBox();
            this.departmentCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.DarkGreen;
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(59, 463);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(242, 47);
            this.updateButton.TabIndex = 67;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // locationTb
            // 
            this.locationTb.BackColor = System.Drawing.Color.Black;
            this.locationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.locationTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.locationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.locationTb.ForeColor = System.Drawing.Color.White;
            this.locationTb.Location = new System.Drawing.Point(59, 307);
            this.locationTb.Multiline = true;
            this.locationTb.Name = "locationTb";
            this.locationTb.Size = new System.Drawing.Size(276, 25);
            this.locationTb.TabIndex = 66;
            this.locationTb.Text = "Location";
            this.locationTb.Enter += new System.EventHandler(this.locationTb_Enter);
            // 
            // phoneTb
            // 
            this.phoneTb.BackColor = System.Drawing.Color.Black;
            this.phoneTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.phoneTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.phoneTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.phoneTb.ForeColor = System.Drawing.Color.White;
            this.phoneTb.Location = new System.Drawing.Point(59, 360);
            this.phoneTb.Multiline = true;
            this.phoneTb.Name = "phoneTb";
            this.phoneTb.Size = new System.Drawing.Size(276, 25);
            this.phoneTb.TabIndex = 65;
            this.phoneTb.Text = "Phone";
            this.phoneTb.Enter += new System.EventHandler(this.phoneTb_Enter);
            // 
            // IdTb
            // 
            this.IdTb.BackColor = System.Drawing.Color.Black;
            this.IdTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IdTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.IdTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.IdTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.IdTb.Location = new System.Drawing.Point(59, 201);
            this.IdTb.Multiline = true;
            this.IdTb.Name = "IdTb";
            this.IdTb.Size = new System.Drawing.Size(276, 25);
            this.IdTb.TabIndex = 63;
            this.IdTb.Text = "Identification No";
            this.IdTb.Enter += new System.EventHandler(this.IdTb_Enter);
            // 
            // ageTb
            // 
            this.ageTb.BackColor = System.Drawing.Color.Black;
            this.ageTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ageTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ageTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ageTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.ageTb.Location = new System.Drawing.Point(59, 148);
            this.ageTb.Multiline = true;
            this.ageTb.Name = "ageTb";
            this.ageTb.Size = new System.Drawing.Size(276, 25);
            this.ageTb.TabIndex = 62;
            this.ageTb.Text = "Age";
            this.ageTb.Enter += new System.EventHandler(this.ageTb_Enter);
            // 
            // surnameTb
            // 
            this.surnameTb.BackColor = System.Drawing.Color.Black;
            this.surnameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.surnameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.surnameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surnameTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.surnameTb.Location = new System.Drawing.Point(59, 95);
            this.surnameTb.Multiline = true;
            this.surnameTb.Name = "surnameTb";
            this.surnameTb.Size = new System.Drawing.Size(276, 25);
            this.surnameTb.TabIndex = 61;
            this.surnameTb.Text = "Surname";
            this.surnameTb.Enter += new System.EventHandler(this.surnameTb_Enter);
            // 
            // nameTb
            // 
            this.nameTb.BackColor = System.Drawing.Color.Black;
            this.nameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nameTb.ForeColor = System.Drawing.Color.Gainsboro;
            this.nameTb.Location = new System.Drawing.Point(59, 42);
            this.nameTb.Multiline = true;
            this.nameTb.Name = "nameTb";
            this.nameTb.Size = new System.Drawing.Size(276, 25);
            this.nameTb.TabIndex = 60;
            this.nameTb.Text = "Name";
            this.nameTb.Enter += new System.EventHandler(this.nameTb_Enter);
            // 
            // startingDate
            // 
            this.startingDate.Location = new System.Drawing.Point(402, 283);
            this.startingDate.Name = "startingDate";
            this.startingDate.Size = new System.Drawing.Size(218, 22);
            this.startingDate.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(398, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "STARTING DATE";
            // 
            // birthDate
            // 
            this.birthDate.Location = new System.Drawing.Point(402, 183);
            this.birthDate.Name = "birthDate";
            this.birthDate.Size = new System.Drawing.Size(218, 22);
            this.birthDate.TabIndex = 57;
            // 
            // bloodGroupCb
            // 
            this.bloodGroupCb.BackColor = System.Drawing.Color.Black;
            this.bloodGroupCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bloodGroupCb.ForeColor = System.Drawing.Color.White;
            this.bloodGroupCb.FormattingEnabled = true;
            this.bloodGroupCb.Items.AddRange(new object[] {
            "A+",
            "A-",
            "B+",
            "B-",
            "AB+",
            "AB-",
            "0+",
            "0-"});
            this.bloodGroupCb.Location = new System.Drawing.Point(398, 101);
            this.bloodGroupCb.Name = "bloodGroupCb";
            this.bloodGroupCb.Size = new System.Drawing.Size(276, 28);
            this.bloodGroupCb.TabIndex = 56;
            this.bloodGroupCb.Text = "Blood Group";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(398, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "BIRTH DATE";
            // 
            // genderCb
            // 
            this.genderCb.BackColor = System.Drawing.Color.Black;
            this.genderCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.genderCb.ForeColor = System.Drawing.Color.White;
            this.genderCb.FormattingEnabled = true;
            this.genderCb.Items.AddRange(new object[] {
            "MALE",
            "FEMALE"});
            this.genderCb.Location = new System.Drawing.Point(398, 48);
            this.genderCb.Name = "genderCb";
            this.genderCb.Size = new System.Drawing.Size(276, 28);
            this.genderCb.TabIndex = 54;
            this.genderCb.Text = "Gender";
            // 
            // wageTb
            // 
            this.wageTb.BackColor = System.Drawing.Color.Black;
            this.wageTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.wageTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.wageTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.wageTb.ForeColor = System.Drawing.Color.White;
            this.wageTb.Location = new System.Drawing.Point(59, 408);
            this.wageTb.Multiline = true;
            this.wageTb.Name = "wageTb";
            this.wageTb.Size = new System.Drawing.Size(276, 25);
            this.wageTb.TabIndex = 68;
            this.wageTb.Text = "Wage";
            this.wageTb.Enter += new System.EventHandler(this.wageTb_Enter);
            // 
            // departmentCb
            // 
            this.departmentCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.departmentCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.departmentCb.ForeColor = System.Drawing.Color.White;
            this.departmentCb.FormattingEnabled = true;
            this.departmentCb.Items.AddRange(new object[] {
            "Software",
            "IT",
            "Technician",
            "Finance",
            "HR",
            "Management",
            "Production"});
            this.departmentCb.Location = new System.Drawing.Point(59, 256);
            this.departmentCb.Name = "departmentCb";
            this.departmentCb.Size = new System.Drawing.Size(276, 28);
            this.departmentCb.TabIndex = 69;
            this.departmentCb.Text = "Department";
            // 
            // UpdateEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 562);
            this.Controls.Add(this.departmentCb);
            this.Controls.Add(this.wageTb);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.locationTb);
            this.Controls.Add(this.phoneTb);
            this.Controls.Add(this.IdTb);
            this.Controls.Add(this.ageTb);
            this.Controls.Add(this.surnameTb);
            this.Controls.Add(this.nameTb);
            this.Controls.Add(this.startingDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.birthDate);
            this.Controls.Add(this.bloodGroupCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.genderCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "UpdateEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.TextBox locationTb;
        private System.Windows.Forms.TextBox phoneTb;
        private System.Windows.Forms.TextBox IdTb;
        private System.Windows.Forms.TextBox ageTb;
        private System.Windows.Forms.TextBox surnameTb;
        private System.Windows.Forms.TextBox nameTb;
        private System.Windows.Forms.DateTimePicker startingDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker birthDate;
        private System.Windows.Forms.ComboBox bloodGroupCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox genderCb;
        private System.Windows.Forms.TextBox wageTb;
        private System.Windows.Forms.ComboBox departmentCb;
    }
}