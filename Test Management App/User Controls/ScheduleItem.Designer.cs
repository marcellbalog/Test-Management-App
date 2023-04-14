
namespace Test_Management_App
{
	partial class ScheduleItem
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
			this.testLabel = new System.Windows.Forms.Label();
			this.teamLabel = new System.Windows.Forms.Label();
			this.actionLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// testLabel
			// 
			this.testLabel.AutoSize = true;
			this.testLabel.Location = new System.Drawing.Point(3, 9);
			this.testLabel.Name = "testLabel";
			this.testLabel.Size = new System.Drawing.Size(50, 13);
			this.testLabel.TabIndex = 0;
			this.testLabel.Text = "testLabel";
			// 
			// teamLabel
			// 
			this.teamLabel.AutoSize = true;
			this.teamLabel.Location = new System.Drawing.Point(3, 22);
			this.teamLabel.Name = "teamLabel";
			this.teamLabel.Size = new System.Drawing.Size(56, 13);
			this.teamLabel.TabIndex = 1;
			this.teamLabel.Text = "teamLabel";
			// 
			// actionLabel
			// 
			this.actionLabel.AutoSize = true;
			this.actionLabel.Location = new System.Drawing.Point(3, 35);
			this.actionLabel.Name = "actionLabel";
			this.actionLabel.Size = new System.Drawing.Size(62, 13);
			this.actionLabel.TabIndex = 2;
			this.actionLabel.Text = "actionLabel";
			// 
			// ScheduleItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DeepSkyBlue;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.actionLabel);
			this.Controls.Add(this.teamLabel);
			this.Controls.Add(this.testLabel);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "ScheduleItem";
			this.Size = new System.Drawing.Size(143, 87);
			this.Click += new System.EventHandler(this.ScheduleItem_Click);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label testLabel;
		private System.Windows.Forms.Label teamLabel;
		private System.Windows.Forms.Label actionLabel;
	}
}
