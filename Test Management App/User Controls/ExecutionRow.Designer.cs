
namespace Test_Management_App
{
	partial class ExecutionRow
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.labelID = new System.Windows.Forms.Label();
			this.labelDate = new System.Windows.Forms.Label();
			this.labelTime = new System.Windows.Forms.Label();
			this.PictureResult = new System.Windows.Forms.PictureBox();
			this.labelResult = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.PictureResult)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(22, 14);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(18, 13);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID";
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(70, 14);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(61, 13);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "2001.01.01";
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(175, 14);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(49, 13);
			this.labelTime.TabIndex = 2;
			this.labelTime.Text = "00:00:00";
			// 
			// PictureResult
			// 
			this.PictureResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PictureResult.BackColor = System.Drawing.Color.WhiteSmoke;
			this.PictureResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PictureResult.Location = new System.Drawing.Point(325, 7);
			this.PictureResult.Name = "PictureResult";
			this.PictureResult.Size = new System.Drawing.Size(25, 25);
			this.PictureResult.TabIndex = 42;
			this.PictureResult.TabStop = false;
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(269, 14);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(37, 13);
			this.labelResult.TabIndex = 43;
			this.labelResult.Text = "Result";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.AliceBlue;
			this.panel1.Controls.Add(this.labelResult);
			this.panel1.Controls.Add(this.labelDate);
			this.panel1.Controls.Add(this.PictureResult);
			this.panel1.Controls.Add(this.labelID);
			this.panel1.Controls.Add(this.labelTime);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(368, 42);
			this.panel1.TabIndex = 44;
			this.panel1.Click += new System.EventHandler(this.panel1_Click);
			// 
			// ExecutionRow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "ExecutionRow";
			this.Size = new System.Drawing.Size(374, 48);
			((System.ComponentModel.ISupportInitialize)(this.PictureResult)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label labelTime;
		public System.Windows.Forms.PictureBox PictureResult;
		private System.Windows.Forms.Label labelResult;
		private System.Windows.Forms.Panel panel1;
	}
}
