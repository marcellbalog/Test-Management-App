
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
			this.label1 = new System.Windows.Forms.Label();
			this.stepsPanel = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.stepFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.NewButton = new System.Windows.Forms.Button();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.label10 = new System.Windows.Forms.Label();
			this.TestResult = new System.Windows.Forms.PictureBox();
			this.resultLabel = new System.Windows.Forms.Label();
			this.stepsPanel.SuspendLayout();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.TestResult)).BeginInit();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.BackColor = System.Drawing.Color.LightCyan;
			this.SaveButton.FlatAppearance.BorderSize = 0;
			this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.SaveButton.Location = new System.Drawing.Point(662, 23);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(47, 23);
			this.SaveButton.TabIndex = 52;
			this.SaveButton.Text = "SAVE";
			this.SaveButton.UseVisualStyleBackColor = false;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// TestNameInput
			// 
			this.TestNameInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.TestNameInput.BackColor = System.Drawing.Color.DarkSlateGray;
			this.TestNameInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.TestNameInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.TestNameInput.ForeColor = System.Drawing.SystemColors.Info;
			this.TestNameInput.Location = new System.Drawing.Point(26, 23);
			this.TestNameInput.Name = "TestNameInput";
			this.TestNameInput.Size = new System.Drawing.Size(528, 19);
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
			this.comboBoxTeamMember.Location = new System.Drawing.Point(168, 148);
			this.comboBoxTeamMember.Name = "comboBoxTeamMember";
			this.comboBoxTeamMember.Size = new System.Drawing.Size(121, 21);
			this.comboBoxTeamMember.TabIndex = 58;
			// 
			// comboBoxStatus
			// 
			this.comboBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxStatus.FormattingEnabled = true;
			this.comboBoxStatus.Location = new System.Drawing.Point(304, 148);
			this.comboBoxStatus.Name = "comboBoxStatus";
			this.comboBoxStatus.Size = new System.Drawing.Size(121, 21);
			this.comboBoxStatus.TabIndex = 59;
			// 
			// comboBoxFolder
			// 
			this.comboBoxFolder.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.comboBoxFolder.FormattingEnabled = true;
			this.comboBoxFolder.Location = new System.Drawing.Point(30, 148);
			this.comboBoxFolder.Name = "comboBoxFolder";
			this.comboBoxFolder.Size = new System.Drawing.Size(121, 21);
			this.comboBoxFolder.TabIndex = 60;
			// 
			// textBoxDescription
			// 
			this.textBoxDescription.Location = new System.Drawing.Point(30, 24);
			this.textBoxDescription.Multiline = true;
			this.textBoxDescription.Name = "textBoxDescription";
			this.textBoxDescription.Size = new System.Drawing.Size(411, 99);
			this.textBoxDescription.TabIndex = 61;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(26, 252);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 18);
			this.label1.TabIndex = 62;
			this.label1.Text = "Steps";
			// 
			// stepsPanel
			// 
			this.stepsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.stepsPanel.AutoScroll = true;
			this.stepsPanel.Controls.Add(this.panel1);
			this.stepsPanel.Controls.Add(this.stepFlowLayoutPanel);
			this.stepsPanel.Location = new System.Drawing.Point(26, 285);
			this.stepsPanel.MinimumSize = new System.Drawing.Size(700, 225);
			this.stepsPanel.Name = "stepsPanel";
			this.stepsPanel.Size = new System.Drawing.Size(747, 381);
			this.stepsPanel.TabIndex = 63;
			// 
			// panel1
			// 
			this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(741, 23);
			this.panel1.TabIndex = 68;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(391, 4);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(85, 13);
			this.label3.TabIndex = 2;
			this.label3.Text = "Expected Result";
			this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(60, 4);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Description";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(16, 4);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(18, 13);
			this.label6.TabIndex = 0;
			this.label6.Text = "ID";
			// 
			// stepFlowLayoutPanel
			// 
			this.stepFlowLayoutPanel.AutoScroll = true;
			this.stepFlowLayoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.stepFlowLayoutPanel.Location = new System.Drawing.Point(0, 25);
			this.stepFlowLayoutPanel.Name = "stepFlowLayoutPanel";
			this.stepFlowLayoutPanel.Size = new System.Drawing.Size(747, 356);
			this.stepFlowLayoutPanel.TabIndex = 66;
			this.stepFlowLayoutPanel.WrapContents = false;
			// 
			// NewButton
			// 
			this.NewButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.NewButton.BackColor = System.Drawing.Color.LightCyan;
			this.NewButton.FlatAppearance.BorderSize = 0;
			this.NewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.NewButton.Location = new System.Drawing.Point(726, 251);
			this.NewButton.Name = "NewButton";
			this.NewButton.Size = new System.Drawing.Size(47, 23);
			this.NewButton.TabIndex = 64;
			this.NewButton.Text = "NEW";
			this.NewButton.UseVisualStyleBackColor = false;
			this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
			// 
			// DeleteButton
			// 
			this.DeleteButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.DeleteButton.BackColor = System.Drawing.Color.LightCyan;
			this.DeleteButton.FlatAppearance.BorderSize = 0;
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.DeleteButton.Location = new System.Drawing.Point(715, 23);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(58, 23);
			this.DeleteButton.TabIndex = 65;
			this.DeleteButton.Text = "DELETE";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.LightCoral;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.button1.ForeColor = System.Drawing.Color.Black;
			this.button1.Location = new System.Drawing.Point(574, 23);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(82, 23);
			this.button1.TabIndex = 66;
			this.button1.Text = "EXECUTION";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(30, 132);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(36, 13);
			this.label4.TabIndex = 67;
			this.label4.Text = "Folder";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(165, 132);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 13);
			this.label5.TabIndex = 68;
			this.label5.Text = "Team Member";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(301, 132);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(37, 13);
			this.label7.TabIndex = 69;
			this.label7.Text = "Status";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(30, 8);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(60, 13);
			this.label8.TabIndex = 70;
			this.label8.Text = "Desctiption";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(481, 24);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(262, 99);
			this.textBox1.TabIndex = 71;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(478, 8);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(66, 13);
			this.label9.TabIndex = 72;
			this.label9.Text = "Precondition";
			// 
			// panel2
			// 
			this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panel2.BackColor = System.Drawing.Color.LightBlue;
			this.panel2.Controls.Add(this.resultLabel);
			this.panel2.Controls.Add(this.TestResult);
			this.panel2.Controls.Add(this.label10);
			this.panel2.Controls.Add(this.label9);
			this.panel2.Controls.Add(this.textBoxDescription);
			this.panel2.Controls.Add(this.textBox1);
			this.panel2.Controls.Add(this.comboBoxTeamMember);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.comboBoxStatus);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.comboBoxFolder);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.label4);
			this.panel2.Location = new System.Drawing.Point(-4, 61);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(813, 184);
			this.panel2.TabIndex = 73;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.DarkSlateGray;
			this.panel3.Location = new System.Drawing.Point(-4, -2);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(810, 66);
			this.panel3.TabIndex = 74;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(481, 148);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(107, 13);
			this.label10.TabIndex = 73;
			this.label10.Text = "Last execution result:";
			// 
			// TestResult
			// 
			this.TestResult.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.TestResult.BackColor = System.Drawing.Color.WhiteSmoke;
			this.TestResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.TestResult.Location = new System.Drawing.Point(594, 144);
			this.TestResult.Name = "TestResult";
			this.TestResult.Size = new System.Drawing.Size(25, 25);
			this.TestResult.TabIndex = 74;
			this.TestResult.TabStop = false;
			// 
			// resultLabel
			// 
			this.resultLabel.AutoSize = true;
			this.resultLabel.Location = new System.Drawing.Point(625, 148);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(57, 13);
			this.resultLabel.TabIndex = 75;
			this.resultLabel.Text = "SUCCESS";
			// 
			// Testcase
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(800, 711);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.DeleteButton);
			this.Controls.Add(this.NewButton);
			this.Controls.Add(this.stepsPanel);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.TestNameInput);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Name = "Testcase";
			this.Text = "Testcase";
			this.stepsPanel.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.TestResult)).EndInit();
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel stepsPanel;
		private System.Windows.Forms.Button NewButton;
		private System.Windows.Forms.Button DeleteButton;
		private System.Windows.Forms.FlowLayoutPanel stepFlowLayoutPanel;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label resultLabel;
		public System.Windows.Forms.PictureBox TestResult;
	}
}