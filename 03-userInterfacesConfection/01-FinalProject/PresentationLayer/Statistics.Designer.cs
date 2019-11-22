namespace PresentationLayer
{
    partial class Statistics
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
            this.titleLbl = new System.Windows.Forms.Label();
            this.monthLbl = new System.Windows.Forms.Label();
            this.monthBox = new System.Windows.Forms.ComboBox();
            this.yearChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.monthChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.yearChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLbl
            // 
            this.titleLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleLbl.AutoSize = true;
            this.titleLbl.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.titleLbl.Location = new System.Drawing.Point(354, 9);
            this.titleLbl.Name = "titleLbl";
            this.titleLbl.Size = new System.Drawing.Size(296, 70);
            this.titleLbl.TabIndex = 6;
            this.titleLbl.Text = "Statistics";
            // 
            // monthLbl
            // 
            this.monthLbl.AutoSize = true;
            this.monthLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.monthLbl.Location = new System.Drawing.Point(305, 119);
            this.monthLbl.Name = "monthLbl";
            this.monthLbl.Size = new System.Drawing.Size(96, 29);
            this.monthLbl.TabIndex = 58;
            this.monthLbl.Text = "Month:";
            // 
            // monthBox
            // 
            this.monthBox.AccessibleName = "";
            this.monthBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.monthBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.monthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(252)))), ((int)(((byte)(250)))));
            this.monthBox.FormattingEnabled = true;
            this.monthBox.Location = new System.Drawing.Point(437, 116);
            this.monthBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(302, 37);
            this.monthBox.TabIndex = 59;
            this.monthBox.SelectedValueChanged += new System.EventHandler(this.FillCharts);
            // 
            // yearChart
            // 
            this.yearChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            this.yearChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.yearChart.BorderlineColor = System.Drawing.Color.Empty;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            chartArea1.Name = "ChartArea1";
            this.yearChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            legend1.Name = "Legend1";
            this.yearChart.Legends.Add(legend1);
            this.yearChart.Location = new System.Drawing.Point(505, 208);
            this.yearChart.Margin = new System.Windows.Forms.Padding(4);
            this.yearChart.Name = "yearChart";
            this.yearChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(61)))), ((int)(((byte)(72))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(119)))), ((int)(((byte)(83))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(203)))), ((int)(((byte)(216))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(149)))), ((int)(((byte)(114))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(71)))), ((int)(((byte)(135))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(207)))), ((int)(((byte)(236)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.yearChart.Series.Add(series1);
            this.yearChart.Size = new System.Drawing.Size(490, 442);
            this.yearChart.TabIndex = 60;
            this.yearChart.Text = "chart2";
            // 
            // monthChart
            // 
            this.monthChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            chartArea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(148)))), ((int)(((byte)(144)))));
            chartArea2.Name = "ChartArea1";
            this.monthChart.ChartAreas.Add(chartArea2);
            this.monthChart.Location = new System.Drawing.Point(5, 208);
            this.monthChart.Margin = new System.Windows.Forms.Padding(4);
            this.monthChart.Name = "monthChart";
            this.monthChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.monthChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(119)))), ((int)(((byte)(83)))))};
            this.monthChart.Size = new System.Drawing.Size(490, 442);
            this.monthChart.TabIndex = 61;
            this.monthChart.Text = "Grafico 1";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(116)))), ((int)(((byte)(225)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1000, 690);
            this.Controls.Add(this.monthChart);
            this.Controls.Add(this.yearChart);
            this.Controls.Add(this.monthBox);
            this.Controls.Add(this.monthLbl);
            this.Controls.Add(this.titleLbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Statistics";
            this.Text = "Statistics";
            ((System.ComponentModel.ISupportInitialize)(this.yearChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monthChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLbl;
        private System.Windows.Forms.Label monthLbl;
        private System.Windows.Forms.ComboBox monthBox;
        private System.Windows.Forms.DataVisualization.Charting.Chart yearChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart monthChart;
    }
}