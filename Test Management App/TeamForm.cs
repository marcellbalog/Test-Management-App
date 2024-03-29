﻿using System;
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
	public partial class TeamForm : Form
	{
		MainForm mainForm;

		public TeamForm(MainForm mf)
		{
			InitializeComponent();
			mainForm = mf;

			PopulateTeamList();
		}

		private void PopulateTeamList()
		{
			// Filter out the first (=unknown) team member
			var filteredTeam = mainForm.model.TeamMembers.Where(tm => tm.ID != 0).ToList();
						
			teamListBox.DataSource = filteredTeam;
			teamListBox.DisplayMember = "DisplayInfo";
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			using (var form = new NameRoleInputForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{					
					TeamMember tm = new TeamMember();
					tm.Name = form.NameInput;
					tm.ID = mainForm.model.TeamMembers.Last().ID + 1;

					mainForm.model.InsertTeamMember(tm);
				}
			}

			PopulateTeamList();
		}

		private void removeButton_Click(object sender, EventArgs e)
		{
			var selected = teamListBox.SelectedItem;

			if (selected is TeamMember selectedTM)
			{
				// If it's 0 (unknown), cancel method
				if (selectedTM.ID == 0)
					return;

				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this team member?", "Delete", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.Yes)
				{
					

					// Update tests' associated team member to 0
					foreach (var test in mainForm.model.Tests.Where(t => t.TeamMemberID == selectedTM.ID))
					{
						test.TeamMemberID = 0;
					}

					// Update schedules
					foreach (var sched in mainForm.model.DailyTests.Where(t => t.TeamMemberID == selectedTM.ID))
					{
						sched.TeamMemberID = 0;
					}

					mainForm.model.UpdateTests();
					mainForm.model.UpdateDailyTests();
					mainForm.model.RemoveTeamMember(selectedTM);
				}
			}

			PopulateTeamList();
		}

		private void editButton_Click(object sender, EventArgs e)
		{
			var selected = teamListBox.SelectedItem;

			if (selected is TeamMember selectedTM)
			{
				// If it's 0 (unknown), cancel method
				if (selectedTM.ID == 0)
					return;

				using (var form = new NameRoleInputForm(selectedTM))
				{
					if (form.ShowDialog() == DialogResult.OK)
					{
						TeamMember tm = mainForm.model.TeamMembers.FirstOrDefault(t => t.ID == selectedTM.ID);
						tm.Name = form.NameInput;
						tm.Role = form.RoleInput;

						mainForm.model.UpdateTeamMembers();
					}
				}
			}
			PopulateTeamList();
		}
	}
}
