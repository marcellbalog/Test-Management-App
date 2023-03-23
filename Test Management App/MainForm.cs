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
	public partial class MainForm : Form
	{
		public MainFormController controller;
		string connectionString = "";

		public Form activeForm = null;

		public MainForm()
		{
			InitializeComponent();
			
			var view = new MainFormView(this);
			var model = new MainFormModel(connectionString);
			controller = new MainFormController(view, model);
			controller.Initialize();

			testLibraryButton.Click  += new EventHandler(view.OnTestLibraryButtonClick);
		}

		

		public void testLibrarybutton_Click(object sender, EventArgs e)
		{
			//OpenPageForm(new TestLibraryForm());
		}

		public void teamButton_Click(object sender, EventArgs e)
		{
			//OpenPageForm(new TeamForm());
		}

		public void scheduleButton_Click(object sender, EventArgs e)
		{
			//OpenPageForm(new ScheduleForm());
		}

		public void analyticsButton_Click(object sender, EventArgs e)
		{
			//OpenPageForm(new AnalyticsForm());
		}

		public void settingsButton_Click(object sender, EventArgs e)
		{
			//OpenPageForm(new SettingsForm());
		}
	}
}
