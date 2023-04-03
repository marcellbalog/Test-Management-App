﻿using System;
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
	public partial class Testcase : Form
	{
		private Test thisTest { get; set; }
		private MainForm mainForm;

		private List<StepRow> stepRows = new List<StepRow>();

		public Testcase(Test t, MainForm mf)
		{
			InitializeComponent();

			thisTest = t;
			mainForm = mf;
			LoadTestData();
			PopulateStepList();
		}

		private	void LoadTestData()
		{
			TestNameInput.Text = thisTest.TestName;
			textBoxDescription.Text = thisTest.Description;			

			comboBoxTeamMember.DataSource = mainForm.model.TeamMembers;
			comboBoxTeamMember.DisplayMember = "Name";
			comboBoxTeamMember.ValueMember = "ID";

			comboBoxFolder.DataSource = mainForm.model.Folders;
			comboBoxFolder.DisplayMember = "Name";
			comboBoxFolder.ValueMember = "ID";


			List<int> statusValues = new List<int>(mainForm.model.StatusNames.Keys);
			foreach (int value in statusValues)
			{
				comboBoxStatus.Items.Add(mainForm.model.StatusNames[value]);
			}			
			comboBoxStatus.SelectedItem = mainForm.model.StatusNames[thisTest.Status];


		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			thisTest.TestName = TestNameInput.Text;

			//call sql write


			//saving status data
			/*
			string selectedStatusName = comboBoxStatus.SelectedItem.ToString();
			int selectedStatusValue = mainForm.model.StatusNames.FirstOrDefault(x => x.Value == selectedStatusName).Key;
			thisTest.Status = selectedStatusValue;
			*/


		}

		private void TestNameInput_Enter(object sender, EventArgs e)
		{
			TestNameInput.BackColor = Color.White;
		}

		private void TestNameInput_Leave(object sender, EventArgs e)
		{
			TestNameInput.BackColor = Color.WhiteSmoke;
		}

		public void PopulateStepList()
		{			
			stepsPanel.Controls.Clear();
			List<Step> stepsForTest = mainForm.model.Steps
				.Where(s => s.TestID == thisTest.ID)
				.OrderByDescending(s => s.StepNum)
				.ToList();

			foreach (Step item in stepsForTest)
			{
				StepRow sr = new StepRow(thisTest, item, mainForm);
				stepRows.Add(sr);
				stepsPanel.Controls.Add(sr);
				sr.Dock = DockStyle.Top;
				//sr.MaximumSize = new Size(default, 45);
				sr.MinimumSize = new Size(default, 72);			
				
			}
		}
	}
}
