namespace Project.Finance
{
    partial class PaymentsTable
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
            this.searchCb = new System.Windows.Forms.ComboBox();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.deleteButtonPayments = new System.Windows.Forms.Button();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.paymentDataGridView = new System.Windows.Forms.DataGridView();
            this.createCsvButtonPayments = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // searchCb
            // 
            this.searchCb.BackColor = System.Drawing.Color.Teal;
            this.searchCb.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchCb.FormattingEnabled = true;
            this.searchCb.Items.AddRange(new object[] {
            "ALL DATAS",
            "ID",
            "PAYMENT INSTITUON",
            "AMOUNT PAID",
            "BILL TYPE",
            "PAYMENT METHOD",
            "PAYMENT DATE",
            "PAID DATE"});
            this.searchCb.Location = new System.Drawing.Point(7, 101);
            this.searchCb.Margin = new System.Windows.Forms.Padding(2);
            this.searchCb.Name = "searchCb";
            this.searchCb.Size = new System.Drawing.Size(188, 33);
            this.searchCb.TabIndex = 17;
            this.searchCb.Text = "ALL DATAS";
            // 
            // searchTb
            // 
            this.searchTb.BackColor = System.Drawing.Color.Teal;
            this.searchTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTb.Location = new System.Drawing.Point(231, 102);
            this.searchTb.Margin = new System.Windows.Forms.Padding(2);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(188, 32);
            this.searchTb.TabIndex = 16;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Teal;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(655, 88);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(187, 44);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButtonPayments
            // 
            this.deleteButtonPayments.BackColor = System.Drawing.Color.Red;
            this.deleteButtonPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButtonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButtonPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButtonPayments.ForeColor = System.Drawing.Color.White;
            this.deleteButtonPayments.Location = new System.Drawing.Point(7, 424);
            this.deleteButtonPayments.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButtonPayments.Name = "deleteButtonPayments";
            this.deleteButtonPayments.Size = new System.Drawing.Size(187, 44);
            this.deleteButtonPayments.TabIndex = 14;
            this.deleteButtonPayments.Text = "DELETE PAYMENT";
            this.deleteButtonPayments.UseVisualStyleBackColor = false;
            this.deleteButtonPayments.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButtonPayments.Enter += new System.EventHandler(this.deleteButton_Enter);
            this.deleteButtonPayments.Leave += new System.EventHandler(this.deleteButton_Leave);
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(647, 34);
            this.tbRows.Margin = new System.Windows.Forms.Padding(2);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(78, 22);
            this.tbRows.TabIndex = 13;
            this.tbRows.Visible = false;
            // 
            // paymentDataGridView
            // 
            this.paymentDataGridView.AllowUserToAddRows = false;
            this.paymentDataGridView.AllowUserToDeleteRows = false;
            this.paymentDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.paymentDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.paymentDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.paymentDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.paymentDataGridView.GridColor = System.Drawing.Color.White;
            this.paymentDataGridView.Location = new System.Drawing.Point(7, 143);
            this.paymentDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.paymentDataGridView.Name = "paymentDataGridView";
            this.paymentDataGridView.ReadOnly = true;
            this.paymentDataGridView.RowHeadersWidth = 51;
            this.paymentDataGridView.RowTemplate.Height = 24;
            this.paymentDataGridView.Size = new System.Drawing.Size(836, 264);
            this.paymentDataGridView.TabIndex = 12;
            this.paymentDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentDataGridView_CellClick);
            this.paymentDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.paymentDataGridView_CellDoubleClick);
            // 
            // createCsvButtonPayments
            // 
            this.createCsvButtonPayments.BackColor = System.Drawing.Color.Blue;
            this.createCsvButtonPayments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCsvButtonPayments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCsvButtonPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createCsvButtonPayments.ForeColor = System.Drawing.Color.White;
            this.createCsvButtonPayments.Location = new System.Drawing.Point(655, 424);
            this.createCsvButtonPayments.Name = "createCsvButtonPayments";
            this.createCsvButtonPayments.Size = new System.Drawing.Size(188, 44);
            this.createCsvButtonPayments.TabIndex = 18;
            this.createCsvButtonPayments.Text = "EXPORT CSV FILE";
            this.createCsvButtonPayments.UseVisualStyleBackColor = false;
            this.createCsvButtonPayments.Click += new System.EventHandler(this.createCsvButton_Click);
            // 
            // PaymentsTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(918, 637);
            this.Controls.Add(this.createCsvButtonPayments);
            this.Controls.Add(this.searchCb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButtonPayments);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.paymentDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaymentsTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaymentsTable";
            ((System.ComponentModel.ISupportInitialize)(this.paymentDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchCb;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButtonPayments;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.DataGridView paymentDataGridView;
        private System.Windows.Forms.Button createCsvButtonPayments;
    }
}