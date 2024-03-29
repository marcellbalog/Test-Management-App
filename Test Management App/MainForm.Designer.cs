﻿
namespace Test_Management_App
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.panel1 = new System.Windows.Forms.Panel();
			this.settingsButton = new System.Windows.Forms.Button();
			this.analyticsButton = new System.Windows.Forms.Button();
			this.scheduleButton = new System.Windows.Forms.Button();
			this.teamButton = new System.Windows.Forms.Button();
			this.testLibraryButton = new System.Windows.Forms.Button();
			this.pageFormPanel = new System.Windows.Forms.Panel();
			this.helpButton = new System.Windows.Forms.Button();
			this.imageList1 = new System.Windows.Forms.ImageList(this.components);
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.AutoSize = true;
			this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel1.Controls.Add(this.helpButton);
			this.panel1.Controls.Add(this.settingsButton);
			this.panel1.Controls.Add(this.analyticsButton);
			this.panel1.Controls.Add(this.scheduleButton);
			this.panel1.Controls.Add(this.teamButton);
			this.panel1.Controls.Add(this.testLibraryButton);
			this.panel1.Location = new System.Drawing.Point(-3, -4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1018, 57);
			this.panel1.TabIndex = 0;
			// 
			// settingsButton
			// 
			this.settingsButton.BackColor = System.Drawing.Color.Transparent;
			this.settingsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.settingsButton.FlatAppearance.BorderSize = 0;
			this.settingsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.settingsButton.ForeColor = System.Drawing.Color.Aqua;
			this.settingsButton.Location = new System.Drawing.Point(412, 22);
			this.settingsButton.Name = "settingsButton";
			this.settingsButton.Size = new System.Drawing.Size(88, 30);
			this.settingsButton.TabIndex = 12;
			this.settingsButton.Text = "Settings";
			this.settingsButton.UseVisualStyleBackColor = false;
			this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
			// 
			// analyticsButton
			// 
			this.analyticsButton.BackColor = System.Drawing.Color.Transparent;
			this.analyticsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.analyticsButton.FlatAppearance.BorderSize = 0;
			this.analyticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.analyticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.analyticsButton.ForeColor = System.Drawing.Color.Aqua;
			this.analyticsButton.Location = new System.Drawing.Point(314, 22);
			this.analyticsButton.Name = "analyticsButton";
			this.analyticsButton.Size = new System.Drawing.Size(94, 30);
			this.analyticsButton.TabIndex = 11;
			this.analyticsButton.Text = "Analytics";
			this.analyticsButton.UseVisualStyleBackColor = false;
			this.analyticsButton.Click += new System.EventHandler(this.analyticsButton_Click);
			// 
			// scheduleButton
			// 
			this.scheduleButton.BackColor = System.Drawing.Color.Transparent;
			this.scheduleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.scheduleButton.FlatAppearance.BorderSize = 0;
			this.scheduleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.scheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.scheduleButton.ForeColor = System.Drawing.Color.Aqua;
			this.scheduleButton.Location = new System.Drawing.Point(224, 22);
			this.scheduleButton.Name = "scheduleButton";
			this.scheduleButton.Size = new System.Drawing.Size(94, 30);
			this.scheduleButton.TabIndex = 10;
			this.scheduleButton.Text = "Schedule";
			this.scheduleButton.UseVisualStyleBackColor = false;
			this.scheduleButton.Click += new System.EventHandler(this.scheduleButton_Click);
			// 
			// teamButton
			// 
			this.teamButton.BackColor = System.Drawing.Color.Transparent;
			this.teamButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.teamButton.FlatAppearance.BorderSize = 0;
			this.teamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.teamButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.teamButton.ForeColor = System.Drawing.Color.Aqua;
			this.teamButton.Location = new System.Drawing.Point(141, 22);
			this.teamButton.Name = "teamButton";
			this.teamButton.Size = new System.Drawing.Size(94, 30);
			this.teamButton.TabIndex = 9;
			this.teamButton.Text = "Team";
			this.teamButton.UseVisualStyleBackColor = false;
			this.teamButton.Click += new System.EventHandler(this.teamButton_Click);
			// 
			// testLibraryButton
			// 
			this.testLibraryButton.BackColor = System.Drawing.Color.WhiteSmoke;
			this.testLibraryButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.testLibraryButton.FlatAppearance.BorderSize = 0;
			this.testLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.testLibraryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.testLibraryButton.ForeColor = System.Drawing.Color.DarkCyan;
			this.testLibraryButton.Location = new System.Drawing.Point(15, 22);
			this.testLibraryButton.Name = "testLibraryButton";
			this.testLibraryButton.Size = new System.Drawing.Size(146, 30);
			this.testLibraryButton.TabIndex = 8;
			this.testLibraryButton.Text = "Test Library";
			this.testLibraryButton.UseVisualStyleBackColor = false;
			this.testLibraryButton.Click += new System.EventHandler(this.testLibrarybutton_Click);
			// 
			// pageFormPanel
			// 
			this.pageFormPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.pageFormPanel.BackColor = System.Drawing.Color.Transparent;
			this.pageFormPanel.Location = new System.Drawing.Point(-3, 48);
			this.pageFormPanel.MinimumSize = new System.Drawing.Size(1018, 581);
			this.pageFormPanel.Name = "pageFormPanel";
			this.pageFormPanel.Size = new System.Drawing.Size(1018, 581);
			this.pageFormPanel.TabIndex = 47;
			// 
			// helpButton
			// 
			this.helpButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.helpButton.BackColor = System.Drawing.Color.Transparent;
			this.helpButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.helpButton.FlatAppearance.BorderSize = 0;
			this.helpButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.helpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.helpButton.ForeColor = System.Drawing.Color.Aqua;
			this.helpButton.Image = ((System.Drawing.Image)(resources.GetObject("helpButton.Image")));
			this.helpButton.Location = new System.Drawing.Point(963, 14);
			this.helpButton.Name = "helpButton";
			this.helpButton.Size = new System.Drawing.Size(41, 38);
			this.helpButton.TabIndex = 14;
			this.helpButton.UseVisualStyleBackColor = false;
			this.helpButton.Click += new System.EventHandler(this.helpButton_Click);
			// 
			// imageList1
			// 
			this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
			this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
			this.imageList1.Images.SetKeyName(0, "help_FILL0_wght400_GRAD0_opsz48.png");
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSeaGreen;
			this.ClientSize = new System.Drawing.Size(1014, 628);
			this.Controls.Add(this.pageFormPanel);
			this.Controls.Add(this.panel1);
			this.Name = "MainForm";
			this.Text = "Test Management Tool";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Button settingsButton;
		public System.Windows.Forms.Button analyticsButton;
		public System.Windows.Forms.Button scheduleButton;
		public System.Windows.Forms.Button teamButton;
		public System.Windows.Forms.Button testLibraryButton;
		private System.Windows.Forms.Panel pageFormPanel;
		public System.Windows.Forms.Button helpButton;
		private System.Windows.Forms.ImageList imageList1;
	}
}

