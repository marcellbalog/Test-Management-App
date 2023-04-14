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
	public partial class ScheduleItem : UserControl
	{
		public MainForm mainForm;

		public DailyTest dailyTest { get; set; }
		
		public ScheduleItem(MainForm mf, DailyTest t)
		{
			InitializeComponent();

			mainForm = mf;
			dailyTest = t;

			testLabel.Text = mainForm.model.Tests.FirstOrDefault(te => te.ID == dailyTest.TestID).TestName;
			teamLabel.Text = mainForm.model.TeamMembers.FirstOrDefault(te => te.ID == dailyTest.TeamMemberID).Name;
			actionLabel.Text = "[action]";
		}

		private void ScheduleItem_Click(object sender, EventArgs e)
		{
			ScheduleItemEditPanel editpanel = new ScheduleItemEditPanel(mainForm, dailyTest);
			editpanel.Show();
		}
	}
}
