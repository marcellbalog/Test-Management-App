
namespace Test_Management_App
{
	partial class AnalyticsForm
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.FolderComboBox = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
			this.SuspendLayout();
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(35, 47);
			this.chart1.Name = "chart1";
			this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.Red,
        System.Drawing.Color.LimeGreen};
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series1.IsValueShownAsLabel = true;
			series1.Legend = "Legend1";
			series1.Name = "Execution result";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(300, 300);
			this.chart1.TabIndex = 0;
			this.chart1.Text = "chart1";
			// 
			// FolderComboBox
			// 
			this.FolderComboBox.AllowDrop = true;
			this.FolderComboBox.BackColor = System.Drawing.SystemColors.Window;
			this.FolderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.FolderComboBox.FormattingEnabled = true;
			this.FolderComboBox.Location = new System.Drawing.Point(75, 3);
			this.FolderComboBox.MaxDropDownItems = 100;
			this.FolderComboBox.Name = "FolderComboBox";
			this.FolderComboBox.Size = new System.Drawing.Size(121, 21);
			this.FolderComboBox.TabIndex = 1;
			this.FolderComboBox.SelectedIndexChanged += new System.EventHandler(this.FolderComboBox_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(35, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(115, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Execution results";
			// 
			// chart2
			// 
			chartArea2.Name = "ChartArea1";
			this.chart2.ChartAreas.Add(chartArea2);
			legend2.Name = "Legend1";
			this.chart2.Legends.Add(legend2);
			this.chart2.Location = new System.Drawing.Point(409, 47);
			this.chart2.Name = "chart2";
			this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chart2.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.Khaki,
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))))};
			series2.ChartArea = "ChartArea1";
			series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
			series2.IsValueShownAsLabel = true;
			series2.Legend = "Legend1";
			series2.Name = "Execution result";
			this.chart2.Series.Add(series2);
			this.chart2.Size = new System.Drawing.Size(300, 300);
			this.chart2.TabIndex = 3;
			this.chart2.Text = "chart2";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label2.Location = new System.Drawing.Point(406, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(48, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Status";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(3, 8);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Select folder";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Silver;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.FolderComboBox);
			this.panel1.Location = new System.Drawing.Point(51, 20);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(203, 28);
			this.panel1.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.AutoScroll = true;
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Controls.Add(this.chart4);
			this.panel2.Controls.Add(this.chart3);
			this.panel2.Controls.Add(this.chart2);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.chart1);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Location = new System.Drawing.Point(12, 54);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(759, 784);
			this.panel2.TabIndex = 8;
			// 
			// chart3
			// 
			chartArea4.Name = "ChartArea1";
			this.chart3.ChartAreas.Add(chartArea4);
			legend4.Name = "Legend1";
			this.chart3.Legends.Add(legend4);
			this.chart3.Location = new System.Drawing.Point(35, 414);
			this.chart3.Name = "chart3";
			this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chart3.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.Red,
        System.Drawing.Color.LimeGreen};
			series4.ChartArea = "ChartArea1";
			series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
			series4.IsValueShownAsLabel = true;
			series4.Legend = "Legend1";
			series4.Name = "Test per person";
			this.chart3.Series.Add(series4);
			this.chart3.Size = new System.Drawing.Size(300, 300);
			this.chart3.TabIndex = 6;
			this.chart3.Text = "chart3";
			// 
			// chart4
			// 
			chartArea3.Name = "ChartArea1";
			this.chart4.ChartAreas.Add(chartArea3);
			legend3.Name = "Legend1";
			this.chart4.Legends.Add(legend3);
			this.chart4.Location = new System.Drawing.Point(409, 414);
			this.chart4.Name = "chart4";
			this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
			this.chart4.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224))))),
        System.Drawing.Color.Red,
        System.Drawing.Color.LimeGreen};
			series3.ChartArea = "ChartArea1";
			series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedArea;
			series3.IsValueShownAsLabel = true;
			series3.Legend = "Legend1";
			series3.Name = "Scheduled tests";
			this.chart4.Series.Add(series3);
			this.chart4.Size = new System.Drawing.Size(300, 300);
			this.chart4.TabIndex = 7;
			this.chart4.Text = "chart4";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label4.Location = new System.Drawing.Point(32, 385);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 17);
			this.label4.TabIndex = 8;
			this.label4.Text = "Test status per person";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label5.Location = new System.Drawing.Point(406, 385);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 17);
			this.label5.TabIndex = 9;
			this.label5.Text = "Scheduled tests";
			// 
			// AnalyticsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 848);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "AnalyticsForm";
			this.Text = "AnalyticsForm";
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.ComboBox FolderComboBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
	}
}