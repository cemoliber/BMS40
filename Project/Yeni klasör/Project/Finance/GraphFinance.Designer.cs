namespace Project.Finance
{
    partial class GraphFinance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GraphFinance));
            this.paymentPb = new System.Windows.Forms.PictureBox();
            this.purchasePb = new System.Windows.Forms.PictureBox();
            this.salePb = new System.Windows.Forms.PictureBox();
            this.saleLbl = new System.Windows.Forms.Label();
            this.paymentLbl = new System.Windows.Forms.Label();
            this.purchaseLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.paymentPb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.salePb)).BeginInit();
            this.SuspendLayout();
            // 
            // paymentPb
            // 
            this.paymentPb.Image = ((System.Drawing.Image)(resources.GetObject("paymentPb.Image")));
            this.paymentPb.Location = new System.Drawing.Point(614, 64);
            this.paymentPb.Name = "paymentPb";
            this.paymentPb.Size = new System.Drawing.Size(170, 177);
            this.paymentPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paymentPb.TabIndex = 0;
            this.paymentPb.TabStop = false;
            // 
            // purchasePb
            // 
            this.purchasePb.Image = ((System.Drawing.Image)(resources.GetObject("purchasePb.Image")));
            this.purchasePb.Location = new System.Drawing.Point(354, 64);
            this.purchasePb.Name = "purchasePb";
            this.purchasePb.Size = new System.Drawing.Size(170, 177);
            this.purchasePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.purchasePb.TabIndex = 1;
            this.purchasePb.TabStop = false;
            // 
            // salePb
            // 
            this.salePb.Image = ((System.Drawing.Image)(resources.GetObject("salePb.Image")));
            this.salePb.Location = new System.Drawing.Point(94, 64);
            this.salePb.Name = "salePb";
            this.salePb.Size = new System.Drawing.Size(170, 177);
            this.salePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.salePb.TabIndex = 2;
            this.salePb.TabStop = false;
            // 
            // saleLbl
            // 
            this.saleLbl.AutoSize = true;
            this.saleLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.saleLbl.Location = new System.Drawing.Point(90, 269);
            this.saleLbl.Name = "saleLbl";
            this.saleLbl.Size = new System.Drawing.Size(57, 23);
            this.saleLbl.TabIndex = 3;
            this.saleLbl.Text = "label1";
            // 
            // paymentLbl
            // 
            this.paymentLbl.AutoSize = true;
            this.paymentLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.paymentLbl.Location = new System.Drawing.Point(610, 269);
            this.paymentLbl.Name = "paymentLbl";
            this.paymentLbl.Size = new System.Drawing.Size(60, 23);
            this.paymentLbl.TabIndex = 4;
            this.paymentLbl.Text = "label2";
            // 
            // purchaseLbl
            // 
            this.purchaseLbl.AutoSize = true;
            this.purchaseLbl.Font = new System.Drawing.Font("Impact", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.purchaseLbl.Location = new System.Drawing.Point(350, 269);
            this.purchaseLbl.Name = "purchaseLbl";
            this.purchaseLbl.Size = new System.Drawing.Size(60, 23);
            this.purchaseLbl.TabIndex = 5;
            this.purchaseLbl.Text = "label3";
            // 
            // GraphFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(963, 680);
            this.Controls.Add(this.purchaseLbl);
            this.Controls.Add(this.paymentLbl);
            this.Controls.Add(this.saleLbl);
            this.Controls.Add(this.salePb);
            this.Controls.Add(this.purchasePb);
            this.Controls.Add(this.paymentPb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GraphFinance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GraphFinance";
            ((System.ComponentModel.ISupportInitialize)(this.paymentPb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.purchasePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.salePb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox paymentPb;
        private System.Windows.Forms.PictureBox purchasePb;
        private System.Windows.Forms.PictureBox salePb;
        private System.Windows.Forms.Label saleLbl;
        private System.Windows.Forms.Label paymentLbl;
        private System.Windows.Forms.Label purchaseLbl;
    }
}