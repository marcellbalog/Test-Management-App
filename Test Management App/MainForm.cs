﻿using System;
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
	public partial class MainForm : Form
	{
		public MainFormModel model;
		public MainFormView view;

		public Form activeForm = null;

		

		public MainForm()
		{
			InitializeComponent();
			
			model = new MainFormModel();			
			view = new MainFormView(this);

			view.ShowForm();
			OpenPageForm(new TestLibraryForm(this));

			testLibraryButton.Click  += new EventHandler(view.OnTestLibraryButtonClick);
		}

		public void OpenPageForm(Form form)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = form;
			view.OpenPageForm(form);
			pageFormPanel.Controls.Clear();
			pageFormPanel.Controls.Add(form);
		}



		public void testLibrarybutton_Click(object sender, EventArgs e)
		{
			OpenPageForm(new TestLibraryForm(this));
			view.ChangeButtonColors(testLibraryButton);
		}

		public void teamButton_Click(object sender, EventArgs e)
		{
			OpenPageForm(new TeamForm(this));
			view.ChangeButtonColors(teamButton);
		}

		public void scheduleButton_Click(object sender, EventArgs e)
		{
			OpenPageForm(new ScheduleForm(this));
			view.ChangeButtonColors(scheduleButton);
		}

		public void analyticsButton_Click(object sender, EventArgs e)
		{
			OpenPageForm(new AnalyticsForm(this));
			view.ChangeButtonColors(analyticsButton);
		}

		public void settingsButton_Click(object sender, EventArgs e)
		{
			OpenPageForm(new SettingsForm());
			view.ChangeButtonColors(settingsButton);
		}

		private void helpButton_Click(object sender, EventArgs e)
		{
			Process.Start("https://github.com/marcellbalog/Test-Management-App");

		}
	}
}
