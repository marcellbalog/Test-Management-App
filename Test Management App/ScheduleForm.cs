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
	public partial class ScheduleForm : Form
	{
		public MainForm mainForm;

		private DateTime displayDate;

		Panel[] panels;

		List<ScheduleDay> activeDays = new List<ScheduleDay>();
		List<DailyTest> weeklyTests = new List<DailyTest>();

		List<ScheduleItem> weeklyItems = new List<ScheduleItem>();

		public ScheduleForm(MainForm mf)
		{
			InitializeComponent();

			mainForm = mf;			

			Panel[] panels = { dayPanel1, dayPanel2, dayPanel3, dayPanel4, dayPanel5, dayPanel6, dayPanel7 };
			this.panels = panels;

			WriteDates(DateTime.Now);
			LoadItems(DateTime.Now);
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			WriteDates(dateTimePicker1.Value);
			LoadItems(dateTimePicker1.Value);
		}

		public void WriteDates(DateTime selectedDate)
		{			
			int delta = DayOfWeek.Monday - selectedDate.DayOfWeek;
			DateTime monday = selectedDate.AddDays(delta);
			label1.Text = monday.ToString("MM.dd");
			label2.Text = monday.AddDays(1).ToString("MM.dd");
			label3.Text = monday.AddDays(2).ToString("MM.dd");
			label4.Text = monday.AddDays(3).ToString("MM.dd");
			label5.Text = monday.AddDays(4).ToString("MM.dd");
			label6.Text = monday.AddDays(5).ToString("MM.dd");
			label7.Text = monday.AddDays(6).ToString("MM.dd");

			displayDate = selectedDate;
		}

		public void LoadItems(DateTime selectedDate)
		{
			// Remove displayed items & Free up resources
			foreach (var item in weeklyItems)
			{
				item.Parent.Controls.Remove(item);				
				item.Dispose();
			}
			weeklyItems.Clear();
			weeklyTests.Clear();

			activeDays.Clear();
			

						

			int delta = DayOfWeek.Monday - selectedDate.DayOfWeek;
			DateTime monday = selectedDate.AddDays(delta);

			for (int i = 0; i < 7; i++)
			{
				DateTime date = monday.AddDays(i);

				activeDays = mainForm.model.ScheduleDays.FindAll(day => day.Date.Date == date.Date);
				// Find the tests for the current date
				var tests = mainForm.model.DailyTests.FindAll(test => activeDays.Any(ad => ad.ID == test.ScheduleDayID && ad.Date.Date == date.Date)).ToList();
				weeklyTests.AddRange(tests);

				foreach (var test in tests)
				{
					// Create a new user control and add it to the panel
					ScheduleItem newItem = new ScheduleItem(mainForm, test);
					panels[i].Controls.Add(newItem);
					newItem.Dock = DockStyle.Top;
					

					weeklyItems.Add(newItem);

					// Assign a tag for referencing the data with the panel
					newItem.Tag = weeklyItems.Count()-1;
				}
			}
		}

		public void ReloadItems()
		{
			LoadItems(displayDate);
		}

		private void buttonBack_Click(object sender, EventArgs e)
		{			

			WriteDates(displayDate.AddDays(-7));
			LoadItems(displayDate);			
		}

		private void buttonForward_Click(object sender, EventArgs e)
		{		

			WriteDates(displayDate.AddDays(7));
			LoadItems(displayDate);			
		}

		private void dayPanelDoubleClick(object sender, EventArgs e)
		{
			// Get a number reference to which panel was clicked
			Panel clickedPanel = sender as Panel;
			int panelNumber = int.Parse(clickedPanel.Tag.ToString());

			Console.WriteLine(panelNumber);

			ScheduleItemEditPanel editpanel = new ScheduleItemEditPanel (mainForm, new DailyTest()) {				
				date = displayDate.AddDays(panelNumber-1)
			};
			editpanel.Show();

			//SAVE IN EDIT FORM...

			//RELOAD PANELS...
		}
	}
}
