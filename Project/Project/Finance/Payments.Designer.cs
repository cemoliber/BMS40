namespace Project.Finance
{
    partial class Payments
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
            this.saveButton = new System.Windows.Forms.Button();
            this.amountPaidTb = new System.Windows.Forms.TextBox();
            this.paymentInstitutionTb = new System.Windows.Forms.TextBox();
            this.date2 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.date1 = new System.Windows.Forms.DateTimePicker();
            this.paymentMethodCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.billTypeCb = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(43, 258);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(229, 35);
            this.saveButton.TabIndex = 101;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.Enter += new System.EventHandler(this.saveButton_Enter);
            this.saveButton.Leave += new System.EventHandler(this.saveButton_Leave);
            // 
            // amountPaidTb
            // 
            this.amountPaidTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.amountPaidTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.amountPaidTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amountPaidTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.amountPaidTb.ForeColor = System.Drawing.Color.White;
            this.amountPaidTb.Location = new System.Drawing.Point(43, 90);
            this.amountPaidTb.Multiline = true;
            this.amountPaidTb.Name = "amountPaidTb";
            this.amountPaidTb.Size = new System.Drawing.Size(276, 25);
            this.amountPaidTb.TabIndex = 96;
            this.amountPaidTb.Text = "Amount Paid";
            this.amountPaidTb.Enter += new System.EventHandler(this.amountPaidTb_Enter);
            this.amountPaidTb.Leave += new System.EventHandler(this.amountPaidTb_Leave);
            // 
            // paymentInstitutionTb
            // 
            this.paymentInstitutionTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.paymentInstitutionTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.paymentInstitutionTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.paymentInstitutionTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paymentInstitutionTb.ForeColor = System.Drawing.Color.White;
            this.paymentInstitutionTb.Location = new System.Drawing.Point(43, 37);
            this.paymentInstitutionTb.Multiline = true;
            this.paymentInstitutionTb.Name = "paymentInstitutionTb";
            this.paymentInstitutionTb.Size = new System.Drawing.Size(276, 25);
            this.paymentInstitutionTb.TabIndex = 95;
            this.paymentInstitutionTb.Text = "Payment Institution";
            this.paymentInstitutionTb.Enter += new System.EventHandler(this.paymentInstitutionTb_Enter);
            this.paymentInstitutionTb.Leave += new System.EventHandler(this.paymentInstitutionTb_Leave);
            // 
            // date2
            // 
            this.date2.CustomFormat = "dd-MM-yyyy";
            this.date2.Location = new System.Drawing.Point(431, 271);
            this.date2.Name = "date2";
            this.date2.Size = new System.Drawing.Size(218, 22);
            this.date2.TabIndex = 93;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(427, 248);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 92;
            this.label1.Text = "Paid Date";
            // 
            // date1
            // 
            this.date1.CustomFormat = "dd-MM-yyyy";
            this.date1.Location = new System.Drawing.Point(431, 195);
            this.date1.Name = "date1";
            this.date1.Size = new System.Drawing.Size(218, 22);
            this.date1.TabIndex = 91;
            // 
            // paymentMethodCb
            // 
            this.paymentMethodCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.paymentMethodCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paymentMethodCb.ForeColor = System.Drawing.Color.White;
            this.paymentMethodCb.FormattingEnabled = true;
            this.paymentMethodCb.Items.AddRange(new object[] {
            "ONLİNE",
            "CASH"});
            this.paymentMethodCb.Location = new System.Drawing.Point(431, 90);
            this.paymentMethodCb.Name = "paymentMethodCb";
            this.paymentMethodCb.Size = new System.Drawing.Size(276, 28);
            this.paymentMethodCb.TabIndex = 90;
            this.paymentMethodCb.Text = "Payment Method";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(427, 172);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(151, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Payment Due Date";
            // 
            // billTypeCb
            // 
            this.billTypeCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.billTypeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.billTypeCb.ForeColor = System.Drawing.Color.White;
            this.billTypeCb.FormattingEnabled = true;
            this.billTypeCb.Items.AddRange(new object[] {
            "ELECTRICITY BILL",
            "WATER BILL",
            "NATURAL GAS BILL",
            "INTERNET BILL",
            "TELEPHONE BILL",
            "MAINTENANCE SERVICE",
            "INCOME TAX",
            "VEHICLE TAX",
            "PENALTY PAYMENT"});
            this.billTypeCb.Location = new System.Drawing.Point(431, 34);
            this.billTypeCb.Name = "billTypeCb";
            this.billTypeCb.Size = new System.Drawing.Size(276, 28);
            this.billTypeCb.TabIndex = 88;
            this.billTypeCb.Text = "Bill Type";
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 613);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.amountPaidTb);
            this.Controls.Add(this.paymentInstitutionTb);
            this.Controls.Add(this.date2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.date1);
            this.Controls.Add(this.paymentMethodCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.billTypeCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payments";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox amountPaidTb;
        private System.Windows.Forms.TextBox paymentInstitutionTb;
        private System.Windows.Forms.DateTimePicker date2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date1;
        private System.Windows.Forms.ComboBox paymentMethodCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox billTypeCb;
    }
}