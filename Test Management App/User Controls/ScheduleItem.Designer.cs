
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
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// testLabel
			// 
			this.testLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.testLabel.Location = new System.Drawing.Point(3, 0);
			this.testLabel.Name = "testLabel";
			this.testLabel.Size = new System.Drawing.Size(121, 52);
			this.testLabel.TabIndex = 0;
			this.testLabel.Text = "testLabeltestLabeltetestLabeltestLabelte\r\n\r\n\r\n";
			this.testLabel.Click += new System.EventHandler(this.ScheduleItem_Click);
			// 
			// teamLabel
			// 
			this.teamLabel.AutoSize = true;
			this.teamLabel.Location = new System.Drawing.Point(3, 65);
			this.teamLabel.Name = "teamLabel";
			this.teamLabel.Size = new System.Drawing.Size(56, 13);
			this.teamLabel.TabIndex = 1;
			this.teamLabel.Text = "teamLabel";
			// 
			// actionLabel
			// 
			this.actionLabel.AutoSize = true;
			this.actionLabel.Location = new System.Drawing.Point(3, 52);
			this.actionLabel.Name = "actionLabel";
			this.actionLabel.Size = new System.Drawing.Size(62, 13);
			this.actionLabel.TabIndex = 2;
			this.actionLabel.Text = "actionLabel";
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel1.Controls.Add(this.testLabel);
			this.flowLayoutPanel1.Controls.Add(this.actionLabel);
			this.flowLayoutPanel1.Controls.Add(this.teamLabel);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(137, 81);
			this.flowLayoutPanel1.TabIndex = 3;
			this.flowLayoutPanel1.Click += new System.EventHandler(this.ScheduleItem_Click);
			// 
			// ScheduleItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSalmon;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.flowLayoutPanel1);
			this.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Name = "ScheduleItem";
			this.Size = new System.Drawing.Size(143, 87);
			this.Click += new System.EventHandler(this.ScheduleItem_Click);
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label testLabel;
		private System.Windows.Forms.Label teamLabel;
		private System.Windows.Forms.Label actionLabel;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
	}
}
