
namespace Test_Management_App
{
	partial class TestRow
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.TestResult = new System.Windows.Forms.PictureBox();
			this.TestStatus = new System.Windows.Forms.Label();
			this.TestOwner = new System.Windows.Forms.Label();
			this.TestName = new System.Windows.Forms.Label();
			this.TestID = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TestResult)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.Lavender;
			this.panel1.Controls.Add(this.TestResult);
			this.panel1.Controls.Add(this.TestStatus);
			this.panel1.Controls.Add(this.TestOwner);
			this.panel1.Controls.Add(this.TestName);
			this.panel1.Controls.Add(this.TestID);
			this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(642, 38);
			this.panel1.TabIndex = 40;
			this.panel1.Click += new System.EventHandler(this.TestRow_Click);
			// 
			// TestResult
			// 
			this.TestResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TestResult.BackColor = System.Drawing.Color.WhiteSmoke;
			this.TestResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TestResult.Location = new System.Drawing.Point(598, 6);
			this.TestResult.Name = "TestResult";
			this.TestResult.Size = new System.Drawing.Size(25, 25);
			this.TestResult.TabIndex = 41;
			this.TestResult.TabStop = false;
			// 
			// TestStatus
			// 
			this.TestStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TestStatus.AutoSize = true;
			this.TestStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TestStatus.Location = new System.Drawing.Point(478, 10);
			this.TestStatus.Name = "TestStatus";
			this.TestStatus.Size = new System.Drawing.Size(36, 17);
			this.TestStatus.TabIndex = 3;
			this.TestStatus.Text = "DEV";
			// 
			// TestOwner
			// 
			this.TestOwner.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TestOwner.AutoSize = true;
			this.TestOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TestOwner.Location = new System.Drawing.Point(287, 10);
			this.TestOwner.Name = "TestOwner";
			this.TestOwner.Size = new System.Drawing.Size(112, 17);
			this.TestOwner.TabIndex = 2;
			this.TestOwner.Text = "Team Member A";
			// 
			// TestName
			// 
			this.TestName.AutoSize = true;
			this.TestName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TestName.Location = new System.Drawing.Point(84, 10);
			this.TestName.Name = "TestName";
			this.TestName.Size = new System.Drawing.Size(140, 17);
			this.TestName.TabIndex = 1;
			this.TestName.Text = "Sample Test Name 2";
			// 
			// TestID
			// 
			this.TestID.AutoSize = true;
			this.TestID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TestID.Location = new System.Drawing.Point(16, 10);
			this.TestID.Name = "TestID";
			this.TestID.Size = new System.Drawing.Size(25, 17);
			this.TestID.TabIndex = 0;
			this.TestID.Text = "T2";
			// 
			// TestRow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.panel1);
			this.Name = "TestRow";
			this.Size = new System.Drawing.Size(642, 37);
			this.Click += new System.EventHandler(this.TestRow_Click);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TestResult)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.PictureBox TestResult;
		public System.Windows.Forms.Label TestStatus;
		public System.Windows.Forms.Label TestOwner;
		public System.Windows.Forms.Label TestName;
		public System.Windows.Forms.Label TestID;
	}
}
