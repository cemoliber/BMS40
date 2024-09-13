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
            this.deleteButton = new System.Windows.Forms.Button();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.purchaseDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).BeginInit();
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
            "COMPANY",
            "COMPANY NUMBER",
            "TRANPORTER NAME",
            "TRANSPORTER NUMBER",
            "TRANSPORT TYPE",
            "TRANSPORT STATUS",
            "AGREEMENT DATE",
            "ESTIMATED DATE"});
            this.searchCb.Location = new System.Drawing.Point(29, 88);
            this.searchCb.Margin = new System.Windows.Forms.Padding(2);
            this.searchCb.Name = "searchCb";
            this.searchCb.Size = new System.Drawing.Size(214, 33);
            this.searchCb.TabIndex = 17;
            this.searchCb.Text = "ALL DATAS";
            // 
            // searchTb
            // 
            this.searchTb.BackColor = System.Drawing.Color.Teal;
            this.searchTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTb.Location = new System.Drawing.Point(285, 89);
            this.searchTb.Margin = new System.Windows.Forms.Padding(2);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(214, 32);
            this.searchTb.TabIndex = 16;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Teal;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(770, 74);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(214, 47);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(29, 432);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(214, 47);
            this.deleteButton.TabIndex = 14;
            this.deleteButton.Text = "DELETE PURCHASE";
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(760, 16);
            this.tbRows.Margin = new System.Windows.Forms.Padding(2);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(88, 22);
            this.tbRows.TabIndex = 13;
            this.tbRows.Visible = false;
            // 
            // purchaseDataGridView
            // 
            this.purchaseDataGridView.AllowUserToAddRows = false;
            this.purchaseDataGridView.AllowUserToDeleteRows = false;
            this.purchaseDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.purchaseDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.purchaseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.purchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.purchaseDataGridView.GridColor = System.Drawing.Color.White;
            this.purchaseDataGridView.Location = new System.Drawing.Point(29, 133);
            this.purchaseDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.purchaseDataGridView.Name = "purchaseDataGridView";
            this.purchaseDataGridView.ReadOnly = true;
            this.purchaseDataGridView.RowHeadersWidth = 51;
            this.purchaseDataGridView.RowTemplate.Height = 24;
            this.purchaseDataGridView.Size = new System.Drawing.Size(955, 282);
            this.purchaseDataGridView.TabIndex = 12;
            // 
            // SaleTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1101, 633);
            this.Controls.Add(this.searchCb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.purchaseDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SaleTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SaleTable";
            ((System.ComponentModel.ISupportInitialize)(this.purchaseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox searchCb;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.DataGridView purchaseDataGridView;
    }
}