
namespace Test_Management_App
{
	partial class ExecutionForm
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
			this.components = new System.ComponentModel.Container();
			this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.buttonStart = new System.Windows.Forms.Button();
			this.buttonPause = new System.Windows.Forms.Button();
			this.buttonStop = new System.Windows.Forms.Button();
			this.labelTime = new System.Windows.Forms.Label();
			this.labelInfo = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// flowLayoutPanel
			// 
			this.flowLayoutPanel.Location = new System.Drawing.Point(36, 94);
			this.flowLayoutPanel.Name = "flowLayoutPanel";
			this.flowLayoutPanel.Size = new System.Drawing.Size(378, 317);
			this.flowLayoutPanel.TabIndex = 0;
			// 
			// buttonStart
			// 
			this.buttonStart.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonStart.FlatAppearance.BorderSize = 3;
			this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonStart.Location = new System.Drawing.Point(36, 27);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(47, 42);
			this.buttonStart.TabIndex = 1;
			this.buttonStart.Text = "▶";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// buttonPause
			// 
			this.buttonPause.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonPause.FlatAppearance.BorderSize = 3;
			this.buttonPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonPause.Location = new System.Drawing.Point(89, 27);
			this.buttonPause.Name = "buttonPause";
			this.buttonPause.Size = new System.Drawing.Size(47, 42);
			this.buttonPause.TabIndex = 2;
			this.buttonPause.Text = "⏸";
			this.buttonPause.UseVisualStyleBackColor = true;
			this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
			// 
			// buttonStop
			// 
			this.buttonStop.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.buttonStop.FlatAppearance.BorderSize = 3;
			this.buttonStop.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.buttonStop.Location = new System.Drawing.Point(142, 27);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(47, 42);
			this.buttonStop.TabIndex = 3;
			this.buttonStop.Text = "⬛";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// labelTime
			// 
			this.labelTime.AutoSize = true;
			this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelTime.Location = new System.Drawing.Point(195, 31);
			this.labelTime.Name = "labelTime";
			this.labelTime.Size = new System.Drawing.Size(120, 31);
			this.labelTime.TabIndex = 4;
			this.labelTime.Text = "00:00:00";
			// 
			// labelInfo
			// 
			this.labelInfo.AutoSize = true;
			this.labelInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.labelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.labelInfo.Location = new System.Drawing.Point(439, 94);
			this.labelInfo.Name = "labelInfo";
			this.labelInfo.Size = new System.Drawing.Size(151, 26);
			this.labelInfo.TabIndex = 5;
			this.labelInfo.Text = "Failed at Step 14";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(439, 161);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(323, 250);
			this.textBox1.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(439, 142);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(54, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Comment:";
			// 
			// ExecutionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.labelInfo);
			this.Controls.Add(this.labelTime);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.buttonPause);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.flowLayoutPanel);
			this.Name = "ExecutionForm";
			this.Text = "ExecutionForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Label labelTime;
		private System.Windows.Forms.Label labelInfo;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Timer timer1;
	}
}