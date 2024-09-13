namespace Project.HR
{
    partial class Graph
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.genderChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.departmentChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.averageWageLbl = new System.Windows.Forms.Label();
            this.totalWageLbl = new System.Windows.Forms.Label();
            this.totalEmployeeLbl = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.averageAgeLbl = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.departmentWageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentChart)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentWageChart)).BeginInit();
            this.SuspendLayout();
            // 
            // genderChart
            // 
            chartArea1.Name = "ChartArea1";
            this.genderChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.genderChart.Legends.Add(legend1);
            this.genderChart.Location = new System.Drawing.Point(0, 369);
            this.genderChart.Name = "genderChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.genderChart.Series.Add(series1);
            this.genderChart.Size = new System.Drawing.Size(362, 191);
            this.genderChart.TabIndex = 0;
            // 
            // ageChart
            // 
            chartArea2.Name = "ChartArea1";
            this.ageChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ageChart.Legends.Add(legend2);
            this.ageChart.Location = new System.Drawing.Point(531, 119);
            this.ageChart.Name = "ageChart";
            this.ageChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.ageChart.Series.Add(series2);
            this.ageChart.Size = new System.Drawing.Size(496, 211);
            this.ageChart.TabIndex = 1;
            this.ageChart.Text = "chart1";
            // 
            // departmentChart
            // 
            chartArea3.Name = "ChartArea1";
            this.departmentChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.departmentChart.Legends.Add(legend3);
            this.departmentChart.Location = new System.Drawing.Point(12, 119);
            this.departmentChart.Name = "departmentChart";
            this.departmentChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.departmentChart.Series.Add(series3);
            this.departmentChart.Size = new System.Drawing.Size(448, 211);
            this.departmentChart.TabIndex = 2;
            this.departmentChart.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(422, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Average Wage";
            // 
            // averageWageLbl
            // 
            this.averageWageLbl.AutoSize = true;
            this.averageWageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.averageWageLbl.ForeColor = System.Drawing.Color.White;
            this.averageWageLbl.Location = new System.Drawing.Point(480, 49);
            this.averageWageLbl.Name = "averageWageLbl";
            this.averageWageLbl.Size = new System.Drawing.Size(97, 29);
            this.averageWageLbl.TabIndex = 1;
            this.averageWageLbl.Text = "100000";
            // 
            // totalWageLbl
            // 
            this.totalWageLbl.AutoSize = true;
            this.totalWageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalWageLbl.ForeColor = System.Drawing.Color.White;
            this.totalWageLbl.Location = new System.Drawing.Point(277, 49);
            this.totalWageLbl.Name = "totalWageLbl";
            this.totalWageLbl.Size = new System.Drawing.Size(97, 29);
            this.totalWageLbl.TabIndex = 1;
            this.totalWageLbl.Text = "100000";
            // 
            // totalEmployeeLbl
            // 
            this.totalEmployeeLbl.AutoSize = true;
            this.totalEmployeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.totalEmployeeLbl.ForeColor = System.Drawing.Color.White;
            this.totalEmployeeLbl.Location = new System.Drawing.Point(65, 49);
            this.totalEmployeeLbl.Name = "totalEmployeeLbl";
            this.totalEmployeeLbl.Size = new System.Drawing.Size(97, 29);
            this.totalEmployeeLbl.TabIndex = 1;
            this.totalEmployeeLbl.Text = "100000";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.DarkBlue;
            this.panel5.Controls.Add(this.label1);
            this.panel5.Controls.Add(this.averageAgeLbl);
            this.panel5.Controls.Add(this.totalEmployeeLbl);
            this.panel5.Controls.Add(this.totalWageLbl);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Controls.Add(this.averageWageLbl);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label5);
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1041, 96);
            this.panel5.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(637, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "Avg. Employee Age";
            // 
            // averageAgeLbl
            // 
            this.averageAgeLbl.AutoSize = true;
            this.averageAgeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.averageAgeLbl.ForeColor = System.Drawing.Color.White;
            this.averageAgeLbl.Location = new System.Drawing.Point(709, 49);
            this.averageAgeLbl.Name = "averageAgeLbl";
            this.averageAgeLbl.Size = new System.Drawing.Size(97, 29);
            this.averageAgeLbl.TabIndex = 24;
            this.averageAgeLbl.Text = "100000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(231, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "Total Wage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(3, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Employee Count";
            // 
            // departmentWageChart
            // 
            chartArea4.Name = "ChartArea1";
            this.departmentWageChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.departmentWageChart.Legends.Add(legend4);
            this.departmentWageChart.Location = new System.Drawing.Point(531, 336);
            this.departmentWageChart.Name = "departmentWageChart";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.departmentWageChart.Series.Add(series4);
            this.departmentWageChart.Size = new System.Drawing.Size(463, 255);
            this.departmentWageChart.TabIndex = 35;
            this.departmentWageChart.Text = "chart1";
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1039, 663);
            this.Controls.Add(this.departmentWageChart);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.departmentChart);
            this.Controls.Add(this.ageChart);
            this.Controls.Add(this.genderChart);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Graph";
            this.Text = "Graph";
            ((System.ComponentModel.ISupportInitialize)(this.genderChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentChart)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.departmentWageChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart genderChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart ageChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart departmentChart;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label averageWageLbl;
        private System.Windows.Forms.Label totalWageLbl;
        private System.Windows.Forms.Label totalEmployeeLbl;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label averageAgeLbl;
        private System.Windows.Forms.DataVisualization.Charting.Chart departmentWageChart;
    }
}