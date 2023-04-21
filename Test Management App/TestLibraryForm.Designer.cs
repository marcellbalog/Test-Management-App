
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
			this.RefreshButton = new System.Windows.Forms.Button();
			this.NewButton = new System.Windows.Forms.Button();
			this.CurrentFolderLabel = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.treeView1 = new Test_Management_App.MyTreeView();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// testListPanel
			// 
			this.testListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.testListPanel.AutoScroll = true;
			this.testListPanel.Location = new System.Drawing.Point(191, 91);
			this.testListPanel.MinimumSize = new System.Drawing.Size(700, 225);
			this.testListPanel.Name = "testListPanel";
			this.testListPanel.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
			this.testListPanel.Size = new System.Drawing.Size(811, 520);
			this.testListPanel.TabIndex = 56;
			// 
			// RefreshButton
			// 
			this.RefreshButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.RefreshButton.BackColor = System.Drawing.Color.LightCyan;
			this.RefreshButton.FlatAppearance.BorderSize = 0;
			this.RefreshButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.RefreshButton.Location = new System.Drawing.Point(933, 35);
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
			this.NewButton.Location = new System.Drawing.Point(880, 35);
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
			this.CurrentFolderLabel.Location = new System.Drawing.Point(187, 32);
			this.CurrentFolderLabel.Name = "CurrentFolderLabel";
			this.CurrentFolderLabel.Size = new System.Drawing.Size(54, 24);
			this.CurrentFolderLabel.TabIndex = 47;
			this.CurrentFolderLabel.Text = "\\Root";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.label6.Location = new System.Drawing.Point(22, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(87, 22);
			this.label6.TabIndex = 64;
			this.label6.Text = "Hierarchy";
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(191, 64);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(810, 21);
			this.panel1.TabIndex = 67;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(645, 4);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(37, 13);
			this.label5.TabIndex = 4;
			this.label5.Text = "Status";
			this.label5.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(759, 4);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Result";
			this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label3
			// 
			this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(435, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Team member";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(83, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(35, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Name";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(18, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "ID";
			// 
			// treeView1
			// 
			this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.treeView1.ForeColor = System.Drawing.Color.DarkSlateGray;
			this.treeView1.LineColor = System.Drawing.Color.DarkSlateGray;
			this.treeView1.Location = new System.Drawing.Point(22, 64);
			this.treeView1.Name = "treeView1";
			this.treeView1.Size = new System.Drawing.Size(163, 547);
			this.treeView1.TabIndex = 66;
			this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
			this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseClick);
			// 
			// TestLibraryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1120, 660);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.treeView1);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.testListPanel);
			this.Controls.Add(this.RefreshButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.CurrentFolderLabel);
			this.Name = "TestLibraryForm";
			this.Text = "TestLibraryForm";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel testListPanel;
		private System.Windows.Forms.Button RefreshButton;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Label CurrentFolderLabel;
		private System.Windows.Forms.Label label6;
		private Test_Management_App.MyTreeView treeView1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label5;
	}
}