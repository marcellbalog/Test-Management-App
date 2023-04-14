using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Management_App
{
	public partial class StepRow : UserControl
	{
		MainForm mainForm;
		private Test thisTest { get; set; }
		public Step thisStep { get; set; }
		public StepRow(Test t, Step s, MainForm mf)
		{
			InitializeComponent();
			thisTest = t;
			mainForm = mf;
			thisStep = s;

			numberLabel.Text = thisStep.StepNum.ToString();
			descriptionTextBox.Text = thisStep.StepDescription;
			resultTextBox.Text = thisStep.StepResult;

			// Handle TextChanged event for descriptionTextBox
			descriptionTextBox.TextChanged += (sender, e) =>
			{
				ResizeTextBox(descriptionTextBox);
			};

			// Handle KeyDown event for descriptionTextBox
			descriptionTextBox.KeyDown += (sender, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					ResizeTextBox(descriptionTextBox);
				}
			};

			// Handle TextChanged event for resultTextBox
			resultTextBox.TextChanged += (sender, e) =>
			{
				ResizeTextBox(resultTextBox);
			};

			// Handle KeyDown event for resultTextBox
			resultTextBox.KeyDown += (sender, e) =>
			{
				if (e.KeyCode == Keys.Enter)
				{
					ResizeTextBox(resultTextBox);
				}
			};
		}

		private void ResizeTextBox(TextBox textBox)
		{
			using (Graphics g = textBox.CreateGraphics())
			{
				SizeF size = g.MeasureString(textBox.Text + Environment.NewLine, textBox.Font);
				textBox.Height = (int)Math.Ceiling(size.Height) + 10; // Add 10 pixels of padding
			}
		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this step?", "Delete", MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.Yes)
			{
				mainForm.model.Steps.Remove(thisStep);
				this.Parent.Controls.Remove(this);
			}
		}
	}
}
