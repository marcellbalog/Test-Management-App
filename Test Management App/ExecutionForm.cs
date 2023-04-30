using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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

		private List<ExecutionRow> exeRows = new List<ExecutionRow>();
		Timer timer;
		Stopwatch sw;

		public ExecutionForm(MainForm mf, Test t)
		{
			InitializeComponent();

			mainForm = mf;
			thisTest = t;
			Setup();

			buttonStop.Enabled = false;
			buttonPause.Enabled = false;
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
				ExecutionRow er = new ExecutionRow(item, this);
				exeRows.Add(er);
				flowLayoutPanel.Controls.Add(er);
				er.Dock = DockStyle.Top;
				er.MinimumSize = new Size(default, 72);
			}

			UpdateSideInfo(execs.First());
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (timer != null)
			{
				//timer.Stop();
				//sw.Reset();
			}
			else
			{
				timer = new Timer();
				timer.Interval = 10;
				timer.Tick += new EventHandler(timer_Tick);
				sw = new Stopwatch();
			}
			timer.Start();
			sw.Start();
			buttonStart.Enabled = false;
			buttonStop.Enabled = true;
			buttonPause.Enabled = true;

		}

		private void buttonPause_Click(object sender, EventArgs e)
		{
			if (timer.Enabled)
			{
				timer.Stop();
				sw.Stop();

				buttonStart.Enabled = true;
				buttonPause.Enabled = false;
			}
			else
			{
				timer.Start();
				sw.Start();
			}

		}

		private void buttonStop_Click(object sender, EventArgs e)
		{
			timer.Stop();
			sw.Stop();

			buttonStart.Enabled = true;
			buttonStop.Enabled = false;
			buttonPause.Enabled = false;

			ExecutionResultForm ef = new ExecutionResultForm(mainForm, thisTest, sw.Elapsed.TotalSeconds);
			ef.Show();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			labelTime.Text = sw.Elapsed.ToString(@"mm\:ss\:ff");
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			Setup();
		}

		public void UpdateSideInfo(Execution e)
		{
			if (e.Result == 0)
				labelInfo.Text = "Failed at step: " + e.FailedStepID;
			else if (e.Result == 1)
				labelInfo.Text = "Success";
			else if (e.Result == 2)
				labelInfo.Text = "Terminated";
			textBoxComment.Text = e.Comment;
		}
	}
}
