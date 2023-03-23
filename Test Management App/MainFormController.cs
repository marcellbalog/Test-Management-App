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
	public class MainFormController
	{
		private MainFormModel model;
		private MainFormView view;
		//private TestLibraryModel testLibraryModel;
		private Form activeForm = null;

		public MainFormController(MainFormView view, MainFormModel mainFormModel)
		{
			this.view = view;
			this.model = mainFormModel;
		}

		public void Initialize()
		{
			view.Show();
			view.OpenPageForm(new TestLibraryForm(model));
		}

		public void OpenPageForm(Form form)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = form;
			view.OpenPageForm(form);
		}


		public void OnTestLibraryButtonClick()
		{
			OpenPageForm(new TestLibraryForm(model));			
		}

		public void OnTeamButtonClick()
		{
			OpenPageForm(new TeamForm());
		}

		public void OnScheduleButtonClick()
		{
			OpenPageForm(new ScheduleForm());
		}

		public void OnAnalyticsButtonClick()
		{
			OpenPageForm(new AnalyticsForm());
		}

		public void OnSettingsButtonClick()
		{
			OpenPageForm(new SettingsForm());
		}
	}

}
