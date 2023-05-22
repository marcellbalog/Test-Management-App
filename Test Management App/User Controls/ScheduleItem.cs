using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Management_App
{
	public partial class ScheduleItem : UserControl
	{
		public MainForm mainForm;
		public ScheduleForm scheduleForm;
		public DailyTest dailyTest { get; set; }


		// Round border
		[DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
		private static extern IntPtr CreateRoundRectRgn
		(
			int nLeftRect,     // x-coordinate of upper-left corner
			int nTopRect,      // y-coordinate of upper-left corner
			int nRightRect,    // x-coordinate of lower-right corner
			int nBottomRect,   // y-coordinate of lower-right corner
			int nWidthEllipse, // width of ellipse
			int nHeightEllipse // height of ellipse
		);

		public ScheduleItem(MainForm mf, DailyTest t, ScheduleForm sf)
		{
			InitializeComponent();

			// Round border
			this.BorderStyle = BorderStyle.None;
			Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));


			mainForm = mf;
			dailyTest = t;
			scheduleForm = sf;

			testLabel.Text = mainForm.model.Tests.FirstOrDefault(te => te.ID == dailyTest.TestID).TestName;
			teamLabel.Text = mainForm.model.TeamMembers.FirstOrDefault(te => te.ID == dailyTest.TeamMemberID).Name;
			actionLabel.Text = dailyTest.ActionName;
		}

		private void ScheduleItem_Click(object sender, EventArgs e)
		{
			ScheduleItemEditPanel editpanel = new ScheduleItemEditPanel(mainForm, dailyTest) {
				date = mainForm.model.ScheduleDays.FirstOrDefault(d => d.ID == dailyTest.ScheduleDayID).Date
			};			
			editpanel.Show();

			editpanel.FormClosed += new FormClosedEventHandler(scheduleForm.ReloadItems);
		}
	}
}
