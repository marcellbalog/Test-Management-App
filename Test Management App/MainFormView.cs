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
	public class MainFormView
	{
		private MainForm form;

		public MainFormView(MainForm form)
		{
			this.form = form;
			/*this.OnTestLibraryButtonClick += new EventHandler(this.form.testLibrarybutton_Click);
			this.form.testLibraryButton.Click += OnTestLibraryButtonClick;			
			this.form.teamButton.Click += OnTeamButtonClick;
			this.form.scheduleButton.Click += OnScheduleButtonClick;
			this.form.analyticsButton.Click += OnAnalyticsButtonClick;
			this.form.settingsButton.Click += OnSettingsButtonClick;*/
		}

		public void Show()
		{
			form.Show();
		}

		public void OpenPageForm(Form pageForm)
		{
			//form.pageFormPanel.Controls.Clear();
			pageForm.TopLevel = false;
			pageForm.FormBorderStyle = FormBorderStyle.None;
			pageForm.Dock = DockStyle.Fill;
			//form.pageFormPanel.Controls.Add(pageForm);
			pageForm.BringToFront();
			pageForm.Show();			
		}

		public void OnTestLibraryButtonClick(object sender, EventArgs e)
		{
			form.controller.OnTestLibraryButtonClick();
		}

		private void OnTeamButtonClick(object sender, EventArgs e)
		{
			form.controller.OnTeamButtonClick();
		}

		private void OnScheduleButtonClick(object sender, EventArgs e)
		{
			form.controller.OnScheduleButtonClick();
		}

		private void OnAnalyticsButtonClick(object sender, EventArgs e)
		{
			form.controller.OnAnalyticsButtonClick();
		}

		private void OnSettingsButtonClick(object sender, EventArgs e)
		{
			form.controller.OnSettingsButtonClick();
		}



	}

}
