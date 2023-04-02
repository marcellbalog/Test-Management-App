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
		}
	}
}
