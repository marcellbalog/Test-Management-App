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
		public MainForm mainForm;

		public Test Test { get; set; }
		public ScheduleDay Day { get; set; }
		public TeamMember TeamMember { get; set; }

		public DateTime date;

		public ScheduleItemEditPanel(MainForm mf)
		{
			InitializeComponent();

			mainForm = mf;

			testListBox.DataSource = mainForm.model.Tests;
			testListBox.DisplayMember = "DisplayText";
			testListBox.ValueMember = "ID";

			teamComboBox.DataSource = mainForm.model.TeamMembers;
			teamComboBox.DisplayMember = "Name";
			teamComboBox.ValueMember = "ID";
			
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

			DailyTest newDaily = new DailyTest
			{
				TestID = Test.ID,
				ScheduleDayID = Day.ID,
				TeamMemberID = TeamMember.ID,
				Comment = commentTextBox.Text
			};
			mainForm.model.DailyTests.Add(newDaily);


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
	}
}
