
namespace Test_Management_App
{
	partial class Testcase
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
			this.TestNameInput = new System.Windows.Forms.TextBox();
			this.DescriptionInput = new System.Windows.Forms.TextBox();
			this.TeamMemberInput = new System.Windows.Forms.TextBox();
			this.StatusInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.BackColor = System.Drawing.Color.LightCyan;
			this.SaveButton.FlatAppearance.BorderSize = 0;
			this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SaveButton.Location = new System.Drawing.Point(726, 34);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(47, 23);
			this.SaveButton.TabIndex = 52;
			this.SaveButton.Text = "SAVE";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// TestNameInput
			// 
			this.TestNameInput.BackColor = System.Drawing.SystemColors.MenuBar;
			this.TestNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TestNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TestNameInput.Location = new System.Drawing.Point(26, 23);
			this.TestNameInput.Name = "TestNameInput";
			this.TestNameInput.Size = new System.Drawing.Size(100, 19);
			this.TestNameInput.TabIndex = 54;
			this.TestNameInput.Text = "Testcase 01";
			// 
			// DescriptionInput
			// 
			this.DescriptionInput.BackColor = System.Drawing.SystemColors.MenuBar;
			this.DescriptionInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.DescriptionInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.DescriptionInput.Location = new System.Drawing.Point(26, 64);
			this.DescriptionInput.Name = "DescriptionInput";
			this.DescriptionInput.Size = new System.Drawing.Size(100, 19);
			this.DescriptionInput.TabIndex = 55;
			this.DescriptionInput.Text = "Description";
			// 
			// TeamMemberInput
			// 
			this.TeamMemberInput.BackColor = System.Drawing.SystemColors.MenuBar;
			this.TeamMemberInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TeamMemberInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TeamMemberInput.Location = new System.Drawing.Point(26, 100);
			this.TeamMemberInput.Name = "TeamMemberInput";
			this.TeamMemberInput.Size = new System.Drawing.Size(100, 19);
			this.TeamMemberInput.TabIndex = 56;
			this.TeamMemberInput.Text = "TeamMember";
			// 
			// StatusInput
			// 
			this.StatusInput.BackColor = System.Drawing.SystemColors.MenuBar;
			this.StatusInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.StatusInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.StatusInput.Location = new System.Drawing.Point(26, 138);
			this.StatusInput.Name = "StatusInput";
			this.StatusInput.Size = new System.Drawing.Size(100, 19);
			this.StatusInput.TabIndex = 57;
			this.StatusInput.Text = "Status";
			// 
			// Testcase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.StatusInput);
			this.Controls.Add(this.TeamMemberInput);
			this.Controls.Add(this.DescriptionInput);
			this.Controls.Add(this.TestNameInput);
			this.Controls.Add(this.SaveButton);
			this.Name = "Testcase";
			this.Text = "Testcase";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.TextBox TestNameInput;
		private System.Windows.Forms.TextBox DescriptionInput;
		private System.Windows.Forms.TextBox TeamMemberInput;
		private System.Windows.Forms.TextBox StatusInput;
	}
}