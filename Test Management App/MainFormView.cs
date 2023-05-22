using System;
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
	public class MainFormView
	{
		private MainForm form;

		List<Button> NavigationButtons;

		public MainFormView(MainForm form)
		{
			this.form = form;
			/*this.OnTestLibraryButtonClick += new EventHandler(this.form.testLibrarybutton_Click);
			this.form.testLibraryButton.Click += OnTestLibraryButtonClick;			
			this.form.teamButton.Click += OnTeamButtonClick;
			this.form.scheduleButton.Click += OnScheduleButtonClick;
			this.form.analyticsButton.Click += OnAnalyticsButtonClick;
			this.form.settingsButton.Click += OnSettingsButtonClick;*/

			NavigationButtons = new List<Button>() { form.testLibraryButton, form.teamButton, form.scheduleButton, form.analyticsButton, form.settingsButton };
		}

		public void ShowForm()
		{
			form.Show();
		}

		public void OpenPageForm(Form pageForm)
		{			
			pageForm.TopLevel = false;
			pageForm.FormBorderStyle = FormBorderStyle.None;
			pageForm.Dock = DockStyle.Fill;			
			pageForm.BringToFront();
			pageForm.Show();

			Debug.WriteLine("library show");
		}
		
		public void ChangeButtonColors(Button btn)
		{
			foreach (var prev in NavigationButtons)
			{
				prev.BackColor = Color.Transparent;
				prev.ForeColor = Color.Aqua;
				prev.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Regular);
			}

			btn.BackColor = Color.WhiteSmoke;
			btn.ForeColor = Color.DarkCyan;
			btn.Font = new Font(btn.Font.Name, btn.Font.Size, FontStyle.Bold);
		}


		public void OnTestLibraryButtonClick(object sender, EventArgs e)
		{
			//form.controller.OnTestLibraryButtonClick();
			//OpenPageForm(new TestLibraryForm(form.model));
			Debug.WriteLine("library click");			
			
		}

		private void OnTeamButtonClick(object sender, EventArgs e)
		{
			//form.controller.OnTeamButtonClick();
		}

		private void OnScheduleButtonClick(object sender, EventArgs e)
		{
			//form.controller.OnScheduleButtonClick();
		}

		private void OnAnalyticsButtonClick(object sender, EventArgs e)
		{
			//form.controller.OnAnalyticsButtonClick();
		}

		private void OnSettingsButtonClick(object sender, EventArgs e)
		{
			//form.controller.OnSettingsButtonClick();
		}



	}

}
