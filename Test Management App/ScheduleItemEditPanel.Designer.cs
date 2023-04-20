
namespace Test_Management_App
{
	partial class ScheduleItemEditPanel
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.searchTextBox = new System.Windows.Forms.TextBox();
			this.testListBox = new System.Windows.Forms.ListBox();
			this.teamComboBox = new System.Windows.Forms.ComboBox();
			this.actionComboBox = new System.Windows.Forms.ComboBox();
			this.commentTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.deleteButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.BackColor = System.Drawing.Color.LightCyan;
			this.SaveButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.SaveButton.FlatAppearance.BorderSize = 0;
			this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SaveButton.Location = new System.Drawing.Point(510, 11);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(47, 23);
			this.SaveButton.TabIndex = 50;
			this.SaveButton.Text = "SAVE";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// searchTextBox
			// 
			this.searchTextBox.Location = new System.Drawing.Point(40, 43);
			this.searchTextBox.Name = "searchTextBox";
			this.searchTextBox.Size = new System.Drawing.Size(348, 20);
			this.searchTextBox.TabIndex = 51;
			this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBox_TextChanged);
			// 
			// testListBox
			// 
			this.testListBox.FormattingEnabled = true;
			this.testListBox.Location = new System.Drawing.Point(40, 80);
			this.testListBox.Name = "testListBox";
			this.testListBox.Size = new System.Drawing.Size(348, 147);
			this.testListBox.TabIndex = 52;
			// 
			// teamComboBox
			// 
			this.teamComboBox.FormattingEnabled = true;
			this.teamComboBox.Location = new System.Drawing.Point(456, 80);
			this.teamComboBox.Name = "teamComboBox";
			this.teamComboBox.Size = new System.Drawing.Size(121, 21);
			this.teamComboBox.TabIndex = 53;
			// 
			// actionComboBox
			// 
			this.actionComboBox.FormattingEnabled = true;
			this.actionComboBox.Location = new System.Drawing.Point(456, 127);
			this.actionComboBox.Name = "actionComboBox";
			this.actionComboBox.Size = new System.Drawing.Size(121, 21);
			this.actionComboBox.TabIndex = 54;
			// 
			// commentTextBox
			// 
			this.commentTextBox.Location = new System.Drawing.Point(40, 270);
			this.commentTextBox.Multiline = true;
			this.commentTextBox.Name = "commentTextBox";
			this.commentTextBox.Size = new System.Drawing.Size(537, 116);
			this.commentTextBox.TabIndex = 55;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 251);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 13);
			this.label1.TabIndex = 56;
			this.label1.Text = "Comment";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 21);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(66, 13);
			this.label2.TabIndex = 57;
			this.label2.Text = "Select a test";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(453, 64);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(74, 13);
			this.label3.TabIndex = 58;
			this.label3.Text = "Team member";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(456, 111);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(37, 13);
			this.label4.TabIndex = 59;
			this.label4.Text = "Action";
			// 
			// deleteButton
			// 
			this.deleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.deleteButton.BackColor = System.Drawing.Color.LightCyan;
			this.deleteButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.deleteButton.FlatAppearance.BorderSize = 0;
			this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.deleteButton.Location = new System.Drawing.Point(563, 11);
			this.deleteButton.Name = "deleteButton";
			this.deleteButton.Size = new System.Drawing.Size(63, 23);
			this.deleteButton.TabIndex = 60;
			this.deleteButton.Text = "DELETE";
			this.deleteButton.UseVisualStyleBackColor = false;
			this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
			// 
			// ScheduleItemEditPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(638, 398);
			this.Controls.Add(this.deleteButton);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.commentTextBox);
			this.Controls.Add(this.actionComboBox);
			this.Controls.Add(this.teamComboBox);
			this.Controls.Add(this.testListBox);
			this.Controls.Add(this.searchTextBox);
			this.Controls.Add(this.SaveButton);
			this.Name = "ScheduleItemEditPanel";
			this.Text = "ScheduleItemEditPanel";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScheduleItemEditPanel_FormClosed);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox searchTextBox;
		private System.Windows.Forms.ListBox testListBox;
		private System.Windows.Forms.ComboBox teamComboBox;
		private System.Windows.Forms.ComboBox actionComboBox;
		private System.Windows.Forms.TextBox commentTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button deleteButton;
	}
}