﻿
namespace Test_Management_App
{
	partial class TeamForm
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
			this.teamListBox = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.AddButton = new System.Windows.Forms.Button();
			this.removeButton = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.editButton = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// teamListBox
			// 
			this.teamListBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.teamListBox.BackColor = System.Drawing.Color.White;
			this.teamListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.teamListBox.FormattingEnabled = true;
			this.teamListBox.ItemHeight = 16;
			this.teamListBox.Location = new System.Drawing.Point(215, 15);
			this.teamListBox.Name = "teamListBox";
			this.teamListBox.Size = new System.Drawing.Size(243, 292);
			this.teamListBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(34, 38);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Team Members";
			// 
			// AddButton
			// 
			this.AddButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.AddButton.BackColor = System.Drawing.Color.LightCyan;
			this.AddButton.FlatAppearance.BorderSize = 0;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddButton.Location = new System.Drawing.Point(517, 88);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(65, 23);
			this.AddButton.TabIndex = 50;
			this.AddButton.Text = "ADD";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.removeButton.BackColor = System.Drawing.Color.LightCyan;
			this.removeButton.FlatAppearance.BorderSize = 0;
			this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.removeButton.Location = new System.Drawing.Point(517, 117);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(65, 23);
			this.removeButton.TabIndex = 51;
			this.removeButton.Text = "REMOVE";
			this.removeButton.UseVisualStyleBackColor = false;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.editButton);
			this.panel1.Controls.Add(this.teamListBox);
			this.panel1.Location = new System.Drawing.Point(38, 73);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(704, 339);
			this.panel1.TabIndex = 52;
			// 
			// editButton
			// 
			this.editButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.editButton.BackColor = System.Drawing.Color.LightCyan;
			this.editButton.FlatAppearance.BorderSize = 0;
			this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.editButton.Location = new System.Drawing.Point(479, 73);
			this.editButton.Name = "editButton";
			this.editButton.Size = new System.Drawing.Size(65, 23);
			this.editButton.TabIndex = 53;
			this.editButton.Text = "EDIT";
			this.editButton.UseVisualStyleBackColor = false;
			this.editButton.Click += new System.EventHandler(this.editButton_Click);
			// 
			// TeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "TeamForm";
			this.Text = "TeamForm";
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox teamListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button removeButton;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button editButton;
	}
}