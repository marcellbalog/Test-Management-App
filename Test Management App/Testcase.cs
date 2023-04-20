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
	public partial class Testcase : Form
	{
		private Test thisTest { get; set; }
		private MainForm mainForm;

		private List<StepRow> stepRows = new List<StepRow>();
		private List<Step> newSteps = new List<Step>();
		List<Step> stepsForTest = new List<Step>();

		public bool isNew;

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
			comboBoxFolder.DisplayMember = "ParentFolderDisplay";
			comboBoxFolder.ValueMember = "ID";


			List<int> statusValues = new List<int>(mainForm.model.StatusNames.Keys);
			foreach (int value in statusValues)
			{
				comboBoxStatus.Items.Add(mainForm.model.StatusNames[value]);
			}
			/*comboBoxStatus.DataSource = mainForm.model.Tests;
			comboBoxStatus.DisplayMember = "StatusName";
			comboBoxFolder.ValueMember = "Status";
			*/comboBoxStatus.SelectedItem = mainForm.model.StatusNames[thisTest.Status];


		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			

			thisTest.TestName = TestNameInput.Text;
			thisTest.Description = textBoxDescription.Text;
			thisTest.FolderID = (int)comboBoxFolder.SelectedValue;
			//thisTest.Result = 			
			thisTest.TeamMemberID = (int)comboBoxTeamMember.SelectedValue;
			

			//saving status data
			string selectedStatusName = comboBoxStatus.SelectedItem.ToString();
			int selectedStatusValue = mainForm.model.StatusNames.FirstOrDefault(x => x.Value == selectedStatusName).Key;
			thisTest.Status = selectedStatusValue;
			

			//call sql write			
			if (isNew)
				mainForm.model.InsertTest(thisTest);
			else
			{
				mainForm.model.UpdateTests();
				mainForm.model.UpdateSteps();
			}

			foreach (Step s in newSteps)
			{
				mainForm.model.InsertStep(s);
			}
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
			stepFlowLayoutPanel.Controls.Clear();			
			List<Step> stepsForTest = mainForm.model.Steps
				.Where(s => s.TestID == thisTest.ID)
				.OrderBy(s => s.StepNum)
				.ToList();

			// Load tests from db
			foreach (Step item in stepsForTest)
			{
				StepRow sr = new StepRow(thisTest, item, mainForm);
				stepRows.Add(sr);
				stepFlowLayoutPanel.Controls.Add(sr);
				sr.Dock = DockStyle.Top;
				sr.MinimumSize = new Size(default, 72);
			}
			// Load new steps (after adding them to the list)
			foreach (Step item in newSteps)
			{
				StepRow sr = new StepRow(thisTest, item, mainForm);
				stepRows.Add(sr);
				stepFlowLayoutPanel.Controls.Add(sr);
				sr.Dock = DockStyle.Top;
				sr.MinimumSize = new Size(default, 72);
			}
		}

		//Adding new Step
		private void NewButton_Click(object sender, EventArgs e)
		{
			Step newStep = new Step();
			newStep.TestID = thisTest.ID;

			int maxStepNum = mainForm.model.Steps.Where(s => s.TestID == thisTest.ID).Max(s => s.StepNum);
			newStep.StepNum = maxStepNum + 1;
					
			newSteps.Add(newStep);

			PopulateStepList();
		}

		//Delete testcase
		private void DeleteButton_Click(object sender, EventArgs e)
		{

			DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this testcase?", "Delete", MessageBoxButtons.YesNo);
			if (dialogResult == DialogResult.Yes)
			{
				mainForm.model.RemoveTest(thisTest.ID);

				this.Close();
			}
				
		}
	}
}
