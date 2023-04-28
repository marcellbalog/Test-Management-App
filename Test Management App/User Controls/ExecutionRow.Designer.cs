
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
			((System.ComponentModel.ISupportInitialize)(this.PictureResult)).BeginInit();
			this.SuspendLayout();
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Location = new System.Drawing.Point(17, 10);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(18, 13);
			this.labelID.TabIndex = 0;
			this.labelID.Text = "ID";
			// 
			// labelDate
			// 
			this.labelDate.AutoSize = true;
			this.labelDate.Location = new System.Drawing.Point(65, 10);
			this.labelDate.Name = "labelDate";
			this.labelDate.Size = new System.Drawing.Size(30, 13);
			this.labelDate.TabIndex = 1;
			this.labelDate.Text = "Date";
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Location = new System.Drawing.Point(125, 10);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(76, 13);
			this.labelTime.TabIndex = 2;
			this.labelTime.Text = "Execution time";
			// 
			// PictureResult
			// 
			this.PictureResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.PictureResult.BackColor = System.Drawing.Color.WhiteSmoke;
			this.PictureResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PictureResult.Location = new System.Drawing.Point(320, 3);
			this.PictureResult.Name = "PictureResult";
			this.PictureResult.Size = new System.Drawing.Size(25, 25);
			this.PictureResult.TabIndex = 42;
			this.PictureResult.TabStop = false;
			// 
			// labelResult
			// 
			this.labelResult.AutoSize = true;
			this.labelResult.Location = new System.Drawing.Point(264, 10);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new System.Drawing.Size(37, 13);
			this.labelResult.TabIndex = 43;
			this.labelResult.Text = "Result";
			// 
			// ExecutionRow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.labelResult);
			this.Controls.Add(this.PictureResult);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.labelDate);
			this.Controls.Add(this.labelID);
			this.Name = "ExecutionRow";
			this.Size = new System.Drawing.Size(374, 38);
			((System.ComponentModel.ISupportInitialize)(this.PictureResult)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelDate;
		private System.Windows.Forms.Label labelTime;
		public System.Windows.Forms.PictureBox PictureResult;
		private System.Windows.Forms.Label labelResult;
	}
}
