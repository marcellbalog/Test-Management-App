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
		private Execution thisExecution;

		Label popupLabel = new Label();
		ComboBox popupComboBox = new ComboBox();

		public ExecutionResultForm(MainForm mf, Test t)
		{
			InitializeComponent();

			mainForm = mf;
			thisTest = t;
			//thisExecution = e;

			comboBox1.Items.AddRange(new string[]{"Success", "Fail", "Terminated"});
			comboBox1.SelectedIndex = 0;			
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (comboBox1.SelectedIndex == 1)
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
	}
}
