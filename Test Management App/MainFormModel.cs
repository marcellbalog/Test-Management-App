using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class MainFormModel
	{
		string connectionString = ConfigurationManager.ConnectionStrings["Test_Management_App.Properties.Settings.Database1ConnectionString"].ConnectionString;
		private SqlConnection connection;
		public List<Test> Tests = new List<Test>();
		public List<Folder> Folders = new List<Folder>();
		public List<Step> Steps = new List<Step>();
		public List<TeamMember> TeamMembers = new List<TeamMember>();
		public List<ScheduleDay> ScheduleDays = new List<ScheduleDay>();
		public List<DailyTest> DailyTests = new List<DailyTest>();

		// Mapping from status values to their names
		public Dictionary<int, string> StatusNames = new Dictionary<int, string>()
		{
			{ 0, "NEW" },			
			{ 1, "DEV" },
			{ 2, "DONE" }
		};


		public MainFormModel()
		{
			connection = new SqlConnection(connectionString);


			//fontos a sorrend
			LoadTeamMembers();
			LoadFolders();
			LoadTests();
			LoadSteps();
			LoadScheduleDays();
			LoadDailyTests();

		}


		public void LoadTests()
		{
			string sql = "SELECT * FROM Test";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Test item = new Test {
					ID = (int)reader["ID"],
					FolderID = (int)reader["FolderID"],
					TeamMemberID = (int)reader["TeamMemberID"],
					TestName = reader["TestName"].ToString(),
					Description = reader["Description"].ToString(),
					Status = (int)reader["Status"],
					Result = (int)reader["Result"],
				};

				int folderId = (int)reader["FolderID"];
				Folder parentFolder = Folders.Find(folder => folder.ID == folderId);
				item.Folder = parentFolder;

				int memberID = (int)reader["TeamMemberID"];
				TeamMember member = TeamMembers.Find(tmember => tmember.ID == memberID);
				item.TeamMember = member;

				Tests.Add(item);
			}

			reader.Close();
			connection.Close();
		}

		public void LoadFolders()
		{
			string sql = "SELECT * FROM Folder";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Folder item = new Folder();
				item.ID = (int)reader["ID"];
				item.Name = reader["Name"].ToString();

				if (reader.IsDBNull(reader.GetOrdinal("ParentFolderID")))
				{
					item.ParentFolderID = null; // or some default value if it's not nullable
				}
				else
				{
					item.ParentFolderID = (int)reader["ParentFolderID"];
				}			


				Folders.Add(item);
			}

			foreach (Folder item in Folders)
			{
				item.ParentFolderDisplay =  item.GetDisplayValue(Folders);
			}

			reader.Close();
			connection.Close();
		}

		public void LoadSteps()
		{
			string sql = "SELECT * FROM Step";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Step item = new Step
				{
					ID = (int)reader["ID"],
					TestID = (int)reader["TestID"],
					StepNum = (int)reader["StepNum"],
					StepDescription = reader["StepDescription"].ToString(),
					StepResult = reader["StepResult"].ToString(),
				};

				Steps.Add(item);
			}

			reader.Close();
			connection.Close();
		}

		public void LoadTeamMembers()
		{
			string sql = "SELECT * FROM TeamMember";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				TeamMember item = new TeamMember
				{
					ID = (int)reader["ID"],
					Name = reader["Name"].ToString(),
				};

				TeamMembers.Add(item);
			}

			reader.Close();
			connection.Close();
		}

		public void LoadScheduleDays()
		{
			string sql = "SELECT * FROM ScheduleDay";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				ScheduleDay item = new ScheduleDay
				{
					ID = (int)reader["ID"],
					Date = (DateTime)reader["Date"],
				};

				ScheduleDays.Add(item);
			}

			reader.Close();
			connection.Close();
		}

		public void LoadDailyTests()
		{
			string sql = "SELECT * FROM DailyTest";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				DailyTest item = new DailyTest
				{
					ID = (int)reader["ID"],
					TeamMemberID = (int)reader["TeamMemberID"],
					ScheduleDayID = (int)reader["ScheduleDayID"],
					TestID = (int)reader["TestID"],
					Comment = reader["Comment"].ToString()
				};

				DailyTests.Add(item);
			}

			reader.Close();
			connection.Close();
		}
		

		public List<Test> GetData()
		{
			return Tests;
		}

		public void Refresh()
		{
			Tests.Clear();
			Folders.Clear();
			//others...

			LoadTeamMembers();
			LoadFolders();
			LoadTests();
			LoadSteps();
			LoadScheduleDays();
			LoadDailyTests();
		}
	}
}
