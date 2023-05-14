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
	public partial class ExecutionResultForm : Form
	{
		private MainForm mainForm;
		private Test thisTest;
		private Execution thisExecution = new Execution();

		private double timeInSeconds;

		private Label popupLabel = new Label();
		private ComboBox popupComboBox = new ComboBox();

		public ExecutionResultForm(MainForm mf, Test t, double time)
		{
			InitializeComponent();

			mainForm = mf;
			thisTest = t;
			//thisExecution = e;

			timeInSeconds = time;

			comboBoxResult.Items.AddRange(new string[]{"Success", "Fail", "Terminated"});
			comboBoxResult.SelectedIndex = 0;			
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBoxResult.SelectedIndex == 1)
			{				
				popupLabel.Text = "at step:";
				popupLabel.AutoSize = true;
				flowLayoutPanel1.Controls.Add(popupLabel);
				
				flowLayoutPanel1.Controls.Add(popupComboBox);

				List<Step> stepsForTest = mainForm.model.Steps
				.Where(s => s.TestID == thisTest.ID)
				.OrderBy(s => s.StepNum)
				.ToList();

				popupComboBox.Items.AddRange(stepsForTest.ToArray());				
			}
			else
			{
				flowLayoutPanel1.Controls.Remove(popupLabel);
				flowLayoutPanel1.Controls.Remove(popupComboBox);
			}
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			thisExecution.TestID = thisTest.ID;
			thisExecution.Date = DateTime.Now;
			thisExecution.Result = comboBoxResult.SelectedIndex;
			thisExecution.Time = timeInSeconds;
			thisExecution.FailedStepID = popupComboBox.SelectedIndex;
			thisExecution.Comment = textBoxComment.Text;
			
			mainForm.model.InsertExecution(thisExecution);

			// +1 because 0 is "Not Executed" in test data
			thisTest.Result = 1 + thisExecution.Result;

			mainForm.model.UpdateTests();



			this.Close();
		}
	}
}
