
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
			this.comboBoxTeamMember = new System.Windows.Forms.ComboBox();
			this.comboBoxStatus = new System.Windows.Forms.ComboBox();
			this.comboBoxFolder = new System.Windows.Forms.ComboBox();
			this.textBoxDescription = new System.Windows.Forms.TextBox();
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
			this.TestNameInput.BackColor = System.Drawing.Color.WhiteSmoke;
			this.TestNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TestNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TestNameInput.Location = new System.Drawing.Point(26, 23);
			this.TestNameInput.Name = "TestNameInput";
			this.TestNameInput.Size = new System.Drawing.Size(100, 19);
			this.TestNameInput.TabIndex = 54;
			this.TestNameInput.Text = "Testcase 01";
			this.TestNameInput.Enter += new System.EventHandler(this.TestNameInput_Enter);
			this.TestNameInput.Leave += new System.EventHandler(this.TestNameInput_Leave);
			// 
			// comboBoxTeamMember
			// 
			this.comboBoxTeamMember.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxTeamMember.FormattingEnabled = true;
			this.comboBoxTeamMember.Location = new System.Drawing.Point(164, 180);
			this.comboBoxTeamMember.Name = "comboBoxTeamMember";
			this.comboBoxTeamMember.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTeamMember.TabIndex = 58;
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Location = new System.Drawing.Point(300, 180);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
			this.comboBoxStatus.TabIndex = 59;
			// 
			// comboBoxFolder
			// 
			this.comboBoxFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxFolder.FormattingEnabled = true;
			this.comboBoxFolder.Location = new System.Drawing.Point(26, 180);
			this.comboBoxFolder.Name = "comboBoxFolder";
			this.comboBoxFolder.Size = new System.Drawing.Size(121, 21);
			this.comboBoxFolder.TabIndex = 60;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(26, 58);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(493, 99);
			this.textBoxDescription.TabIndex = 61;
			// 
			// Testcase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBoxDescription);
			this.Controls.Add(this.comboBoxFolder);
			this.Controls.Add(this.comboBoxStatus);
			this.Controls.Add(this.comboBoxTeamMember);
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
		private System.Windows.Forms.ComboBox comboBoxTeamMember;
		private System.Windows.Forms.ComboBox comboBoxStatus;
		private System.Windows.Forms.ComboBox comboBoxFolder;
		private System.Windows.Forms.TextBox textBoxDescription;
	}
}