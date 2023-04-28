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
	public partial class ExecutionForm : Form
	{
		private MainForm mainForm;
		private Test thisTest;

		private List<ExecutionRow> exeRows;

		public ExecutionForm(MainForm mf, Test t)
		{
			InitializeComponent();

			mainForm = mf;
			thisTest = t;
			Setup();
		}

		private void Setup()
		{
			flowLayoutPanel.Controls.Clear();
				
			List<Execution> execs = mainForm.model.Executions
				.Where(e => e.TestID == thisTest.ID)
				.OrderBy(e => e.ID)
				.ToList();

			// Load tests from db
			foreach (Execution item in execs)
			{
				ExecutionRow er = new ExecutionRow(item);
				exeRows.Add(er);
				flowLayoutPanel.Controls.Add(er);
				er.Dock = DockStyle.Top;
				er.MinimumSize = new Size(default, 72);
			}			
		}
	}
}
