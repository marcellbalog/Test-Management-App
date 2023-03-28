﻿using System;
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

		public TestLibraryForm(MainForm mf)
		{
			InitializeComponent();

			mainForm = mf;
			PopulateTestList(mainForm.model.Tests);
		}

		public void PopulateTestList(List<Test> data)
		{
			foreach (Test item in data)
			{
				TestRow tr = new TestRow();
				testListPanel.Controls.Clear();
				testListPanel.Controls.Add(tr);
				tr.Dock = DockStyle.Top;
				tr.MaximumSize = new Size(default, 45);
				tr.MinimumSize = new Size(default, 45);
				tr.TestID.Text = "T" + item.ID.ToString();
				tr.TestName.Text = item.TestName;

				tr.TestOwner.Text = item.TeamMemberID.ToString();

				switch (item.Status)
				{
					case 0: 
						tr.TestStatus.Text = "DEV";
						break;
					case 1:
						tr.TestStatus.Text = "DONE";
						break;
					default:
						tr.TestStatus.Text = "DEV";
						break;
				}

				switch (item.Result)
				{
					case 0:
						tr.TestResult.BackColor = Color.WhiteSmoke;
						break;
					case 1:
						tr.TestResult.BackColor = Color.Lime;
						break;
					case 2:
						tr.TestResult.BackColor = Color.Crimson;
						break;
					default: 
						break;
				}


				Debug.WriteLine(item.TestName, item.Status, item.Result, item.TeamMemberID);
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
