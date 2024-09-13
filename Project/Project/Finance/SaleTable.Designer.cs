namespace Project.Finance
{
    partial class SaleTable
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
            this.deleteButtonSale = new System.Windows.Forms.Button();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.saleDataGridView = new System.Windows.Forms.DataGridView();
            this.createCsvButtonSale = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).BeginInit();
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
            "PRODUCT",
            "COUNT",
            "UNIT PRICE",
            "TOTAL PRICE",
            "MOVEMENT LOCATION",
            "ARRIVAL LOCATION",
            "CUSTOMER COMPANY",
            "COMPANY NUMBER",
            "TRANPORTER NAME",
            "TRANSPORTER NUMBER",
            "TRANSPORT TYPE",
            "TRANSPORT STATUS",
            "AGREEMENT DATE",
            "ESTIMATED DATE"});
            this.searchCb.Location = new System.Drawing.Point(25, 82);
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
            this.searchTb.Location = new System.Drawing.Point(249, 83);
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
            this.searchButton.Location = new System.Drawing.Point(674, 69);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(187, 44);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // deleteButtonSale
            // 
            this.deleteButtonSale.BackColor = System.Drawing.Color.Red;
            this.deleteButtonSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButtonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButtonSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButtonSale.ForeColor = System.Drawing.Color.White;
            this.deleteButtonSale.Location = new System.Drawing.Point(25, 405);
            this.deleteButtonSale.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButtonSale.Name = "deleteButtonSale";
            this.deleteButtonSale.Size = new System.Drawing.Size(187, 44);
            this.deleteButtonSale.TabIndex = 14;
            this.deleteButtonSale.Text = "DELETE PURCHASE";
            this.deleteButtonSale.UseVisualStyleBackColor = false;
            this.deleteButtonSale.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButtonSale.Enter += new System.EventHandler(this.deleteButton_Enter);
            this.deleteButtonSale.Leave += new System.EventHandler(this.deleteButton_Leave);
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(665, 15);
            this.tbRows.Margin = new System.Windows.Forms.Padding(2);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(78, 21);
            this.tbRows.TabIndex = 13;
            this.tbRows.Visible = false;
            // 
            // saleDataGridView
            // 
            this.saleDataGridView.AllowUserToAddRows = false;
            this.saleDataGridView.AllowUserToDeleteRows = false;
            this.saleDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.saleDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.saleDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.saleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.saleDataGridView.GridColor = System.Drawing.Color.White;
            this.saleDataGridView.Location = new System.Drawing.Point(25, 125);
            this.saleDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.saleDataGridView.Name = "saleDataGridView";
            this.saleDataGridView.ReadOnly = true;
            this.saleDataGridView.RowHeadersWidth = 51;
            this.saleDataGridView.RowTemplate.Height = 24;
            this.saleDataGridView.Size = new System.Drawing.Size(836, 264);
            this.saleDataGridView.TabIndex = 12;
            this.saleDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDataGridView_CellClick);
            this.saleDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.saleDataGridView_CellDoubleClick);
            // 
            // createCsvButtonSale
            // 
            this.createCsvButtonSale.BackColor = System.Drawing.Color.Blue;
            this.createCsvButtonSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createCsvButtonSale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createCsvButtonSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.createCsvButtonSale.ForeColor = System.Drawing.Color.White;
            this.createCsvButtonSale.Location = new System.Drawing.Point(674, 405);
            this.createCsvButtonSale.Name = "createCsvButtonSale";
            this.createCsvButtonSale.Size = new System.Drawing.Size(187, 44);
            this.createCsvButtonSale.TabIndex = 18;
            this.createCsvButtonSale.Text = "EXPORT CSV FILE";
            this.createCsvButtonSale.UseVisualStyleBackColor = false;
            this.createCsvButtonSale.Click += new System.EventHandler(this.createCsvButton_Click);
            // 
            // SaleTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 593);
            this.Controls.Add(this.createCsvButtonSale);
            this.Controls.Add(this.searchCb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButtonSale);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.saleDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleTable";
            ((System.ComponentModel.ISupportInitialize)(this.saleDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchCb;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButtonSale;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.DataGridView saleDataGridView;
        private System.Windows.Forms.Button createCsvButtonSale;
    }
}