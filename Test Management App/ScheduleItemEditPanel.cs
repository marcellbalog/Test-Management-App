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
	public partial class ScheduleItemEditPanel : Form
	{
		private MainForm mainForm;
		private DailyTest dailyTest;

		private Test Test { get; set; }
		private ScheduleDay Day { get; set; }
		private TeamMember TeamMember { get; set; }

		public DateTime date;

		public ScheduleItemEditPanel(MainForm mf, DailyTest dt)
		{
			InitializeComponent();

			mainForm = mf;
			dailyTest = dt;

			testListBox.DataSource = mainForm.model.Tests;
			testListBox.DisplayMember = "DisplayText";
			testListBox.ValueMember = "ID";			

			searchTextBox.Text = mainForm.model.Tests.FirstOrDefault(te => te.ID == dailyTest.TestID).TestName;

			teamComboBox.DataSource = mainForm.model.TeamMembers;
			teamComboBox.DisplayMember = "Name";
			teamComboBox.ValueMember = "ID";
			teamComboBox.SelectedIndex = dailyTest.TeamMemberID;

			commentTextBox.Text = dailyTest.Comment;			
			//action...
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{

			// Save date (check if a ScheduleDay record with the given date already exists)
			var existingScheduleDay = mainForm.model.ScheduleDays.FirstOrDefault(sd => sd.Date == date);
			if (existingScheduleDay != null)
			{
				Day = existingScheduleDay;
			}
			else
			{			
				Day = new ScheduleDay { Date = date };
				mainForm.model.ScheduleDays.Add(Day);
			}

			Test = (Test)testListBox.SelectedItem;
			TeamMember = (TeamMember)teamComboBox.SelectedItem;

			// Check if the daily test exists already, if not, then create a new one
			if (mainForm.model.DailyTests.Contains(dailyTest))
			{
				int index = mainForm.model.DailyTests.IndexOf(dailyTest);
				DailyTest existingDaily = mainForm.model.DailyTests[index];

				existingDaily.TestID = Test.ID;
				existingDaily.ScheduleDayID = Day.ID;
				existingDaily.TeamMemberID = TeamMember.ID;
				existingDaily.Comment = commentTextBox.Text;
			}
			else
			{
				DailyTest newDaily = new DailyTest
				{
					ID = mainForm.model.DailyTests.Last().ID + 1, //REMOVE LATER (AUTO WRITE IN DB)
					TestID = Test.ID,
					ScheduleDayID = Day.ID,
					TeamMemberID = TeamMember.ID,
					Comment = commentTextBox.Text
				};
				mainForm.model.DailyTests.Add(newDaily);
			}

			this.Close();

		}	


		// Filter results in the listBox while typing
		private void searchTextBox_TextChanged(object sender, EventArgs e)
		{
			string searchText = searchTextBox.Text.ToLower();

			// Filter the tests to only include those that match the entered text (case-insensitive)
			var filteredTests = mainForm.model.Tests.Where(t => t.DisplayText.ToLower().Contains(searchText)).ToList();

			// Update the DataSource of the ListBox to display the filtered tests
			testListBox.DataSource = filteredTests;
			testListBox.DisplayMember = "DisplayText";
			testListBox.ValueMember = "ID";

		}

		private void deleteButton_Click(object sender, EventArgs e)
		{
			mainForm.model.DailyTests.Remove(dailyTest);

			if (mainForm.model.DailyTests.Contains(dailyTest))
			{
				mainForm.model.DailyTests.Remove(dailyTest);
			}

			this.Close();
		}
	}
}
