namespace Project.Finance
{
    partial class Purchase
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
            this.arrivalLocationTb = new System.Windows.Forms.TextBox();
            this.companyTb = new System.Windows.Forms.TextBox();
            this.movementLocationTb = new System.Windows.Forms.TextBox();
            this.totalPriceTb = new System.Windows.Forms.TextBox();
            this.unitPriceTb = new System.Windows.Forms.TextBox();
            this.countTb = new System.Windows.Forms.TextBox();
            this.productTypeTb = new System.Windows.Forms.TextBox();
            this.estimatedArrivalDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.agreementDate = new System.Windows.Forms.DateTimePicker();
            this.transportStatusCb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.transferTypeCb = new System.Windows.Forms.ComboBox();
            this.companyContactNumberTb = new System.Windows.Forms.TextBox();
            this.transporterNameTb = new System.Windows.Forms.TextBox();
            this.transporterContactNoTb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkGreen;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.Location = new System.Drawing.Point(28, 481);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(229, 35);
            this.saveButton.TabIndex = 67;
            this.saveButton.Text = "SAVE";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            this.saveButton.Enter += new System.EventHandler(this.saveButton_Enter);
            this.saveButton.Leave += new System.EventHandler(this.saveButton_Leave);
            // 
            // arrivalLocationTb
            // 
            this.arrivalLocationTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.arrivalLocationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arrivalLocationTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.arrivalLocationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.arrivalLocationTb.ForeColor = System.Drawing.Color.White;
            this.arrivalLocationTb.Location = new System.Drawing.Point(28, 286);
            this.arrivalLocationTb.Multiline = true;
            this.arrivalLocationTb.Name = "arrivalLocationTb";
            this.arrivalLocationTb.Size = new System.Drawing.Size(276, 25);
            this.arrivalLocationTb.TabIndex = 66;
            this.arrivalLocationTb.Text = "Arrival location";
            this.arrivalLocationTb.Enter += new System.EventHandler(this.arrivalLocationTb_Enter);
            // 
            // companyTb
            // 
            this.companyTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.companyTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyTb.ForeColor = System.Drawing.Color.White;
            this.companyTb.Location = new System.Drawing.Point(28, 339);
            this.companyTb.Multiline = true;
            this.companyTb.Name = "companyTb";
            this.companyTb.Size = new System.Drawing.Size(276, 25);
            this.companyTb.TabIndex = 65;
            this.companyTb.Text = "Company";
            this.companyTb.Enter += new System.EventHandler(this.companyTb_Enter);
            // 
            // movementLocationTb
            // 
            this.movementLocationTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.movementLocationTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.movementLocationTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.movementLocationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.movementLocationTb.ForeColor = System.Drawing.Color.White;
            this.movementLocationTb.Location = new System.Drawing.Point(28, 233);
            this.movementLocationTb.Multiline = true;
            this.movementLocationTb.Name = "movementLocationTb";
            this.movementLocationTb.Size = new System.Drawing.Size(276, 25);
            this.movementLocationTb.TabIndex = 64;
            this.movementLocationTb.Text = "Movement Location";
            this.movementLocationTb.Enter += new System.EventHandler(this.movementLocationTb_Enter);
            // 
            // totalPriceTb
            // 
            this.totalPriceTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.totalPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.totalPriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalPriceTb.ForeColor = System.Drawing.Color.White;
            this.totalPriceTb.Location = new System.Drawing.Point(28, 180);
            this.totalPriceTb.Multiline = true;
            this.totalPriceTb.Name = "totalPriceTb";
            this.totalPriceTb.Size = new System.Drawing.Size(276, 25);
            this.totalPriceTb.TabIndex = 63;
            this.totalPriceTb.Text = "Total Price";
            this.totalPriceTb.Enter += new System.EventHandler(this.totalPriceTb_Enter);
            // 
            // unitPriceTb
            // 
            this.unitPriceTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.unitPriceTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.unitPriceTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitPriceTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.unitPriceTb.ForeColor = System.Drawing.Color.White;
            this.unitPriceTb.Location = new System.Drawing.Point(28, 127);
            this.unitPriceTb.Multiline = true;
            this.unitPriceTb.Name = "unitPriceTb";
            this.unitPriceTb.Size = new System.Drawing.Size(276, 25);
            this.unitPriceTb.TabIndex = 62;
            this.unitPriceTb.Text = "Unit Price";
            this.unitPriceTb.Enter += new System.EventHandler(this.unitPriceTb_Enter);
            // 
            // countTb
            // 
            this.countTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.countTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.countTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.countTb.ForeColor = System.Drawing.Color.White;
            this.countTb.Location = new System.Drawing.Point(28, 74);
            this.countTb.Multiline = true;
            this.countTb.Name = "countTb";
            this.countTb.Size = new System.Drawing.Size(276, 25);
            this.countTb.TabIndex = 61;
            this.countTb.Text = "Count / KG";
            this.countTb.Enter += new System.EventHandler(this.countTb_Enter);
            // 
            // productTypeTb
            // 
            this.productTypeTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.productTypeTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.productTypeTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productTypeTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.productTypeTb.ForeColor = System.Drawing.Color.White;
            this.productTypeTb.Location = new System.Drawing.Point(28, 21);
            this.productTypeTb.Multiline = true;
            this.productTypeTb.Name = "productTypeTb";
            this.productTypeTb.Size = new System.Drawing.Size(276, 25);
            this.productTypeTb.TabIndex = 60;
            this.productTypeTb.Text = "Product Type";
            this.productTypeTb.Enter += new System.EventHandler(this.productTypeTb_Enter);
            // 
            // estimatedArrivalDate
            // 
            this.estimatedArrivalDate.CustomFormat = "dd-MM-yyyy";
            this.estimatedArrivalDate.Location = new System.Drawing.Point(416, 392);
            this.estimatedArrivalDate.Name = "estimatedArrivalDate";
            this.estimatedArrivalDate.Size = new System.Drawing.Size(218, 22);
            this.estimatedArrivalDate.TabIndex = 59;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(412, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Estimated Arrival Date";
            // 
            // agreementDate
            // 
            this.agreementDate.CustomFormat = "dd-MM-yyyy";
            this.agreementDate.Location = new System.Drawing.Point(416, 316);
            this.agreementDate.Name = "agreementDate";
            this.agreementDate.Size = new System.Drawing.Size(218, 22);
            this.agreementDate.TabIndex = 57;
            // 
            // transportStatusCb
            // 
            this.transportStatusCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.transportStatusCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transportStatusCb.ForeColor = System.Drawing.Color.White;
            this.transportStatusCb.FormattingEnabled = true;
            this.transportStatusCb.Items.AddRange(new object[] {
            "PENDING",
            "IN MOTION",
            "TRANSFER DONE"});
            this.transportStatusCb.Location = new System.Drawing.Point(416, 177);
            this.transportStatusCb.Name = "transportStatusCb";
            this.transportStatusCb.Size = new System.Drawing.Size(276, 28);
            this.transportStatusCb.TabIndex = 56;
            this.transportStatusCb.Text = "Transport Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(412, 293);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 20);
            this.label8.TabIndex = 55;
            this.label8.Text = "Agreement Date";
            // 
            // transferTypeCb
            // 
            this.transferTypeCb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.transferTypeCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transferTypeCb.ForeColor = System.Drawing.Color.White;
            this.transferTypeCb.FormattingEnabled = true;
            this.transferTypeCb.Items.AddRange(new object[] {
            "TRUCK",
            "SHIP",
            "PLANE",
            "TRAIN"});
            this.transferTypeCb.Location = new System.Drawing.Point(416, 124);
            this.transferTypeCb.Name = "transferTypeCb";
            this.transferTypeCb.Size = new System.Drawing.Size(276, 28);
            this.transferTypeCb.TabIndex = 54;
            this.transferTypeCb.Text = "Transport Type";
            // 
            // companyContactNumberTb
            // 
            this.companyContactNumberTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.companyContactNumberTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.companyContactNumberTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.companyContactNumberTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyContactNumberTb.ForeColor = System.Drawing.Color.White;
            this.companyContactNumberTb.Location = new System.Drawing.Point(28, 392);
            this.companyContactNumberTb.Multiline = true;
            this.companyContactNumberTb.Name = "companyContactNumberTb";
            this.companyContactNumberTb.Size = new System.Drawing.Size(276, 25);
            this.companyContactNumberTb.TabIndex = 68;
            this.companyContactNumberTb.Text = "Company Contact Number";
            this.companyContactNumberTb.Enter += new System.EventHandler(this.companyContactNumberTb_Enter);
            // 
            // transporterNameTb
            // 
            this.transporterNameTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.transporterNameTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transporterNameTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transporterNameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transporterNameTb.ForeColor = System.Drawing.Color.White;
            this.transporterNameTb.Location = new System.Drawing.Point(416, 21);
            this.transporterNameTb.Multiline = true;
            this.transporterNameTb.Name = "transporterNameTb";
            this.transporterNameTb.Size = new System.Drawing.Size(276, 25);
            this.transporterNameTb.TabIndex = 69;
            this.transporterNameTb.Text = "Transporter Name";
            this.transporterNameTb.Enter += new System.EventHandler(this.transporterNameTb_Enter);
            // 
            // transporterContactNoTb
            // 
            this.transporterContactNoTb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.transporterContactNoTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.transporterContactNoTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.transporterContactNoTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.transporterContactNoTb.ForeColor = System.Drawing.Color.White;
            this.transporterContactNoTb.Location = new System.Drawing.Point(416, 74);
            this.transporterContactNoTb.Multiline = true;
            this.transporterContactNoTb.Name = "transporterContactNoTb";
            this.transporterContactNoTb.Size = new System.Drawing.Size(276, 25);
            this.transporterContactNoTb.TabIndex = 70;
            this.transporterContactNoTb.Text = "Transporter Contact Number";
            this.transporterContactNoTb.Enter += new System.EventHandler(this.transporterContactNoTb_Enter);
            // 
            // Purchase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(912, 607);
            this.Controls.Add(this.transporterContactNoTb);
            this.Controls.Add(this.transporterNameTb);
            this.Controls.Add(this.companyContactNumberTb);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.arrivalLocationTb);
            this.Controls.Add(this.companyTb);
            this.Controls.Add(this.movementLocationTb);
            this.Controls.Add(this.totalPriceTb);
            this.Controls.Add(this.unitPriceTb);
            this.Controls.Add(this.countTb);
            this.Controls.Add(this.productTypeTb);
            this.Controls.Add(this.estimatedArrivalDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.agreementDate);
            this.Controls.Add(this.transportStatusCb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.transferTypeCb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Purchase";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Company Contact Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox arrivalLocationTb;
        private System.Windows.Forms.TextBox companyTb;
        private System.Windows.Forms.TextBox movementLocationTb;
        private System.Windows.Forms.TextBox totalPriceTb;
        private System.Windows.Forms.TextBox unitPriceTb;
        private System.Windows.Forms.TextBox countTb;
        private System.Windows.Forms.TextBox productTypeTb;
        private System.Windows.Forms.DateTimePicker estimatedArrivalDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker agreementDate;
        private System.Windows.Forms.ComboBox transportStatusCb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox transferTypeCb;
        private System.Windows.Forms.TextBox companyContactNumberTb;
        private System.Windows.Forms.TextBox transporterNameTb;
        private System.Windows.Forms.TextBox transporterContactNoTb;
    }
}