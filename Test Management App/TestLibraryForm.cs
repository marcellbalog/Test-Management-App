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
	public partial class TestLibraryForm : Form
	{
		MainForm mainForm;

		List<TestRow> testRows = new List<TestRow>();

		public TestLibraryForm(MainForm mf)
		{
			InitializeComponent();

			mainForm = mf;
			PopulateTestList(mainForm.model.Tests);
		}

		public void PopulateTestList(List<Test> data)
		{
			Debug.WriteLine(data.Count());
			testListPanel.Controls.Clear();
			foreach (Test item in data)
			{
				TestRow tr = new TestRow (item, mainForm);
				testRows.Add(tr);				
				testListPanel.Controls.Add(tr);
				tr.Dock = DockStyle.Top;
				tr.MaximumSize = new Size(default, 45);
				tr.MinimumSize = new Size(default, 45);
				tr.TestID.Text = "T" + item.ID.ToString();
				tr.TestName.Text = item.TestName;

				tr.TestOwner.Text = item.TeamMember.Name;
				tr.TestStatus.Text = item.GetStatusName();
				tr.TestResult.BackColor = item.GetResultColor();



				Debug.WriteLine(item.TestName + item.Status + item.Result + item.TeamMemberID);
			}
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			//refresh from db
			mainForm.model.Refresh();
			PopulateTestList(mainForm.model.Tests);
		}

		private void NewButton_Click(object sender, EventArgs e)
		{

		}
	}
}
