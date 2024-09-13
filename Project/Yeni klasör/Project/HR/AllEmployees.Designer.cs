namespace Project.HR
{
    partial class AllEmployees
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.allEmployeesDataGridView = new System.Windows.Forms.DataGridView();
            this.tbRows = new System.Windows.Forms.TextBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.searchCb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // allEmployeesDataGridView
            // 
            this.allEmployeesDataGridView.AllowUserToAddRows = false;
            this.allEmployeesDataGridView.AllowUserToDeleteRows = false;
            this.allEmployeesDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.allEmployeesDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.allEmployeesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.allEmployeesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.allEmployeesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.allEmployeesDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.allEmployeesDataGridView.GridColor = System.Drawing.Color.White;
            this.allEmployeesDataGridView.Location = new System.Drawing.Point(12, 147);
            this.allEmployeesDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allEmployeesDataGridView.Name = "allEmployeesDataGridView";
            this.allEmployeesDataGridView.ReadOnly = true;
            this.allEmployeesDataGridView.RowHeadersWidth = 51;
            this.allEmployeesDataGridView.RowTemplate.Height = 24;
            this.allEmployeesDataGridView.Size = new System.Drawing.Size(935, 300);
            this.allEmployeesDataGridView.TabIndex = 0;
            this.allEmployeesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allEmployeesDataGridView_CellClick);
            this.allEmployeesDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.allEmployeesDataGridView_CellDoubleClick);
            // 
            // tbRows
            // 
            this.tbRows.Location = new System.Drawing.Point(957, 12);
            this.tbRows.Name = "tbRows";
            this.tbRows.Size = new System.Drawing.Size(100, 22);
            this.tbRows.TabIndex = 1;
            this.tbRows.Visible = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Red;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.Location = new System.Drawing.Point(12, 466);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(244, 50);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "DELETE EMPLOYEE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            this.deleteButton.Enter += new System.EventHandler(this.deleteButton_Enter);
            this.deleteButton.Leave += new System.EventHandler(this.deleteButton_Leave);
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.Teal;
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchButton.ForeColor = System.Drawing.Color.White;
            this.searchButton.Location = new System.Drawing.Point(703, 82);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(244, 50);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "SEARCH";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTb
            // 
            this.searchTb.BackColor = System.Drawing.Color.Teal;
            this.searchTb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.searchTb.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchTb.Location = new System.Drawing.Point(304, 100);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(244, 32);
            this.searchTb.TabIndex = 4;
            // 
            // searchCb
            // 
            this.searchCb.BackColor = System.Drawing.Color.Teal;
            this.searchCb.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.searchCb.FormattingEnabled = true;
            this.searchCb.Items.AddRange(new object[] {
            "ALL DATAS",
            "ID",
            "NAME",
            "SURNAME",
            "AGE",
            "IDENTIFICATION NO",
            "DEPARTMENT",
            "LOCATION",
            "PHONE",
            "GENDER",
            "BLOOD GROUP"});
            this.searchCb.Location = new System.Drawing.Point(12, 99);
            this.searchCb.Name = "searchCb";
            this.searchCb.Size = new System.Drawing.Size(244, 33);
            this.searchCb.TabIndex = 5;
            this.searchCb.Text = "ALL DATAS";
            // 
            // AllEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 693);
            this.Controls.Add(this.searchCb);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.tbRows);
            this.Controls.Add(this.allEmployeesDataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AllEmployees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AllEmployees";
            ((System.ComponentModel.ISupportInitialize)(this.allEmployeesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView allEmployeesDataGridView;
        private System.Windows.Forms.TextBox tbRows;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.ComboBox searchCb;
    }
}