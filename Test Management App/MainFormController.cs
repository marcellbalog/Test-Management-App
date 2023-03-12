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
		private MainFormView view;
		//private TestLibraryModel testLibraryModel;

		public MainFormController(MainFormView view/*, TestLibraryModel testLibraryModel*/)
		{
			this.view = view;
			//this.testLibraryModel = testLibraryModel;
		}

		public void Initialize()
		{
			view.Show();
			view.OpenPageForm(new TestLibraryForm());
		}

		public void OnTestLibraryButtonClick()
		{
			view.OpenPageForm(new TestLibraryForm());
		}

		public void OnTeamButtonClick()
		{
			view.OpenPageForm(new TeamForm());
		}

		public void OnScheduleButtonClick()
		{
			view.OpenPageForm(new ScheduleForm());
		}

		public void OnAnalyticsButtonClick()
		{
			view.OpenPageForm(new AnalyticsForm());
		}

		public void OnSettingsButtonClick()
		{
			view.OpenPageForm(new SettingsForm());
		}
	}

}
