
namespace Test_Management_App
{
	partial class StepRow
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numberLabel = new System.Windows.Forms.Label();
			this.descriptionTextBox = new System.Windows.Forms.TextBox();
			this.resultTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// numberLabel
			// 
			this.numberLabel.AutoSize = true;
			this.numberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
			this.numberLabel.ForeColor = System.Drawing.Color.DimGray;
			this.numberLabel.Location = new System.Drawing.Point(13, 23);
			this.numberLabel.Name = "numberLabel";
			this.numberLabel.Size = new System.Drawing.Size(34, 25);
			this.numberLabel.TabIndex = 0;
			this.numberLabel.Text = "01";
			// 
			// descriptionTextBox
			// 
			this.descriptionTextBox.Location = new System.Drawing.Point(78, 27);
			this.descriptionTextBox.Name = "descriptionTextBox";
			this.descriptionTextBox.Size = new System.Drawing.Size(272, 20);
			this.descriptionTextBox.TabIndex = 1;
			// 
			// resultTextBox
			// 
			this.resultTextBox.Location = new System.Drawing.Point(399, 27);
			this.resultTextBox.Name = "resultTextBox";
			this.resultTextBox.Size = new System.Drawing.Size(271, 20);
			this.resultTextBox.TabIndex = 2;
			// 
			// StepRow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.resultTextBox);
			this.Controls.Add(this.descriptionTextBox);
			this.Controls.Add(this.numberLabel);
			this.Name = "StepRow";
			this.Size = new System.Drawing.Size(704, 72);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label numberLabel;
		private System.Windows.Forms.TextBox descriptionTextBox;
		private System.Windows.Forms.TextBox resultTextBox;
	}
}
