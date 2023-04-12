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
		private DateTime displayDate;

		Panel[] panels;

		public ScheduleForm()
		{
			InitializeComponent();

			WriteDates(DateTime.Now);

			Panel[] panels = { dayPanel1, dayPanel2, dayPanel3, dayPanel4, dayPanel5, dayPanel6, dayPanel7 };
			this.panels = panels;
		}

		private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
		{
			WriteDates(dateTimePicker1.Value);
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

		private void buttonBack_Click(object sender, EventArgs e)
		{
			WriteDates(displayDate.AddDays(-7));

			//SHOW PANELS...
		}

		private void buttonForward_Click(object sender, EventArgs e)
		{
			WriteDates(displayDate.AddDays(7));

			//SHOW PANELS...
		}

		private void dayPanelDoubleClick(object sender, EventArgs e)
		{
			// Get a number reference to which panel was clicked
			Panel clickedPanel = sender as Panel;
			int panelNumber = int.Parse(clickedPanel.Tag.ToString());

			Console.WriteLine(panelNumber);

			ScheduleItem newItem = new ScheduleItem();
			panels[panelNumber-1].Controls.Add(newItem);
			newItem.Dock = DockStyle.Top;

			ScheduleItemEditPanel editpanel = new ScheduleItemEditPanel();
			editpanel.Show();

			//SAVE IN EDIT FORM...

			//RELOAD PANELS...
		}
	}
}
