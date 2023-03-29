
namespace Test_Management_App
{
	partial class TestLibraryForm
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
			this.testListPanel = new System.Windows.Forms.Panel();
			this.EditButton = new System.Windows.Forms.Button();
			this.RefreshButton = new System.Windows.Forms.Button();
			this.NewButton = new System.Windows.Forms.Button();
			this.CurrentFolderLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.HierarchyPanel = new System.Windows.Forms.Panel();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label25 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.label35 = new System.Windows.Forms.Label();
			this.HierarchyPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// testListPanel
			// 
			this.testListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.testListPanel.AutoScroll = true;
			this.testListPanel.Location = new System.Drawing.Point(181, 80);
			this.testListPanel.MinimumSize = new System.Drawing.Size(700, 225);
			this.testListPanel.Name = "testListPanel";
			this.testListPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.testListPanel.Size = new System.Drawing.Size(811, 307);
			this.testListPanel.TabIndex = 56;
			// 
			// EditButton
			// 
			this.EditButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.EditButton.BackColor = System.Drawing.Color.LightCyan;
			this.EditButton.FlatAppearance.BorderSize = 0;
			this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.EditButton.Location = new System.Drawing.Point(868, 49);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(47, 23);
			this.EditButton.TabIndex = 51;
			this.EditButton.Text = "EDIT";
			this.EditButton.UseVisualStyleBackColor = false;
			// 
			// RefreshButton
			// 
			this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshButton.BackColor = System.Drawing.Color.LightCyan;
			this.RefreshButton.FlatAppearance.BorderSize = 0;
			this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RefreshButton.Location = new System.Drawing.Point(921, 49);
			this.RefreshButton.Name = "RefreshButton";
			this.RefreshButton.Size = new System.Drawing.Size(68, 23);
			this.RefreshButton.TabIndex = 50;
			this.RefreshButton.Text = "REFRESH";
			this.RefreshButton.UseVisualStyleBackColor = false;
			this.RefreshButton.Click += new System.EventHandler(this.RefreshButton_Click);
			// 
			// NewButton
			// 
			this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NewButton.BackColor = System.Drawing.Color.LightCyan;
			this.NewButton.FlatAppearance.BorderSize = 0;
			this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.NewButton.Location = new System.Drawing.Point(815, 49);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(47, 23);
			this.NewButton.TabIndex = 49;
			this.NewButton.Text = "NEW";
			this.NewButton.UseVisualStyleBackColor = false;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// CurrentFolderLabel
			// 
			this.CurrentFolderLabel.AutoSize = true;
			this.CurrentFolderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.CurrentFolderLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
			this.CurrentFolderLabel.Location = new System.Drawing.Point(177, 32);
			this.CurrentFolderLabel.Name = "CurrentFolderLabel";
			this.CurrentFolderLabel.Size = new System.Drawing.Size(88, 24);
			this.CurrentFolderLabel.TabIndex = 47;
			this.CurrentFolderLabel.Text = "/Folder A";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label6.Location = new System.Drawing.Point(12, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 22);
			this.label6.TabIndex = 64;
			this.label6.Text = "Hierarchy";
			// 
			// HierarchyPanel
			// 
			this.HierarchyPanel.Controls.Add(this.label21);
			this.HierarchyPanel.Controls.Add(this.label22);
			this.HierarchyPanel.Controls.Add(this.label25);
			this.HierarchyPanel.Controls.Add(this.label26);
			this.HierarchyPanel.Controls.Add(this.label27);
			this.HierarchyPanel.Controls.Add(this.label30);
			this.HierarchyPanel.Controls.Add(this.label35);
			this.HierarchyPanel.Location = new System.Drawing.Point(12, 69);
			this.HierarchyPanel.Name = "HierarchyPanel";
			this.HierarchyPanel.Size = new System.Drawing.Size(163, 591);
			this.HierarchyPanel.TabIndex = 65;
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.BackColor = System.Drawing.Color.Transparent;
			this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label21.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label21.Location = new System.Drawing.Point(7, 105);
			this.label21.Name = "label21";
			this.label21.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.label21.Size = new System.Drawing.Size(114, 17);
			this.label21.TabIndex = 70;
			this.label21.Text = "◆ Subfolder E2";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.BackColor = System.Drawing.Color.Transparent;
			this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label22.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label22.Location = new System.Drawing.Point(8, 88);
			this.label22.Name = "label22";
			this.label22.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
			this.label22.Size = new System.Drawing.Size(114, 17);
			this.label22.TabIndex = 69;
			this.label22.Text = "◇ Subfolder E1";
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.BackColor = System.Drawing.Color.Transparent;
			this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label25.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label25.Location = new System.Drawing.Point(8, 73);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(75, 17);
			this.label25.TabIndex = 68;
			this.label25.Text = "◆ Folder E";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.BackColor = System.Drawing.Color.Transparent;
			this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label26.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label26.Location = new System.Drawing.Point(8, 58);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(76, 17);
			this.label26.TabIndex = 67;
			this.label26.Text = "◆ Folder D";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.BackColor = System.Drawing.Color.Transparent;
			this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label27.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label27.Location = new System.Drawing.Point(8, 43);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(75, 17);
			this.label27.TabIndex = 66;
			this.label27.Text = "◇ Folder C";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.BackColor = System.Drawing.Color.Transparent;
			this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label30.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label30.Location = new System.Drawing.Point(8, 28);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(75, 17);
			this.label30.TabIndex = 65;
			this.label30.Text = "◆ Folder B";
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.BackColor = System.Drawing.Color.Transparent;
			this.label35.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label35.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label35.Location = new System.Drawing.Point(8, 11);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(75, 17);
			this.label35.TabIndex = 64;
			this.label35.Text = "◆ Folder A";
			// 
			// TestLibraryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 660);
			this.Controls.Add(this.HierarchyPanel);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.testListPanel);
			this.Controls.Add(this.EditButton);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.CurrentFolderLabel);
			this.Name = "TestLibraryForm";
			this.Text = "TestLibraryForm";
			this.HierarchyPanel.ResumeLayout(false);
			this.HierarchyPanel.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel testListPanel;
		private System.Windows.Forms.Button EditButton;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Label CurrentFolderLabel;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Panel HierarchyPanel;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label35;
	}
}