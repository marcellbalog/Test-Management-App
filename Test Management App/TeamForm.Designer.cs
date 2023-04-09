
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
			this.SuspendLayout();
			// 
			// teamListBox
			// 
			this.teamListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.teamListBox.FormattingEnabled = true;
			this.teamListBox.ItemHeight = 16;
			this.teamListBox.Location = new System.Drawing.Point(143, 80);
			this.teamListBox.Name = "teamListBox";
			this.teamListBox.Size = new System.Drawing.Size(243, 292);
			this.teamListBox.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.label1.Location = new System.Drawing.Point(139, 42);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Team Members";
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.Color.LightCyan;
			this.AddButton.FlatAppearance.BorderSize = 0;
			this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.AddButton.Location = new System.Drawing.Point(422, 80);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(65, 23);
			this.AddButton.TabIndex = 50;
			this.AddButton.Text = "ADD";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
			// 
			// removeButton
			// 
			this.removeButton.BackColor = System.Drawing.Color.LightCyan;
			this.removeButton.FlatAppearance.BorderSize = 0;
			this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.removeButton.Location = new System.Drawing.Point(422, 109);
			this.removeButton.Name = "removeButton";
			this.removeButton.Size = new System.Drawing.Size(65, 23);
			this.removeButton.TabIndex = 51;
			this.removeButton.Text = "REMOVE";
			this.removeButton.UseVisualStyleBackColor = false;
			this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
			// 
			// TeamForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.removeButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.teamListBox);
			this.Name = "TeamForm";
			this.Text = "TeamForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox teamListBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button removeButton;
	}
}