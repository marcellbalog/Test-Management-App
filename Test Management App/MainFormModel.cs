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


		private void LoadTests()
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

		private void LoadFolders()
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

		private void LoadSteps()
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

		private void LoadTeamMembers()
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

		private void LoadScheduleDays()
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

		private void LoadDailyTests()
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
			Steps.Clear();
			TeamMembers.Clear();
			ScheduleDays.Clear();
			DailyTests.Clear();			

			LoadTeamMembers();
			LoadFolders();
			LoadTests();
			LoadSteps();
			LoadScheduleDays();
			LoadDailyTests();
		}

		#region Test Write
		public void UpdateTests()
		{
			string sql = "UPDATE Test SET FolderID = @FolderID, TeamMemberID = @TeamMemberID, TestName = @TestName, Description = @Description, Status = @Status, Result = @Result WHERE ID = @ID";
			connection.Open();
			foreach (Test test in Tests)
			{
				SqlCommand command = new SqlCommand(sql, connection);
				command.Parameters.AddWithValue("@FolderID", test.FolderID);
				command.Parameters.AddWithValue("@TeamMemberID", test.TeamMemberID);
				command.Parameters.AddWithValue("@TestName", test.TestName);
				command.Parameters.AddWithValue("@Description", test.Description);
				command.Parameters.AddWithValue("@Status", test.Status);
				command.Parameters.AddWithValue("@Result", test.Result);
				command.Parameters.AddWithValue("@ID", test.ID);

				int rowsAffected = command.ExecuteNonQuery();
				Console.WriteLine(rowsAffected + "rows updated");
				if (rowsAffected == 0)
				{
					// Handle the case where the update was not successful
				}
			}
			connection.Close();

			Refresh();
		}

		public void InsertTest(Test test)
		{
			string sql = "INSERT INTO Test (FolderID, TeamMemberID, TestName, Description, Status, Result) VALUES (@FolderID, @TeamMemberID, @TestName, @Description, @Status, @Result)";
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@FolderID", test.FolderID);
			command.Parameters.AddWithValue("@TeamMemberID", test.TeamMemberID);
			command.Parameters.AddWithValue("@TestName", test.TestName);
			command.Parameters.AddWithValue("@Description", test.Description);
			command.Parameters.AddWithValue("@Status", test.Status);
			command.Parameters.AddWithValue("@Result", test.Result);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			Refresh();
		}


		public void RemoveTest(int testID)
		{
			string sql = "DELETE FROM Test WHERE ID = @ID";
			connection.Open();
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@ID", testID);
			int rowsAffected = command.ExecuteNonQuery();
			Console.WriteLine(rowsAffected + " rows deleted");
			if (rowsAffected == 0)
			{
				// Handle the case where the delete was not successful
			}
			connection.Close();

			Refresh();
		}
		#endregion

		#region Folder Write
		public void InsertFolder(Folder folder)
		{
			string sql = "INSERT INTO Folder (Name, ParentFolderID) VALUES (@Name, @ParentFolderID)";
			connection.Open();
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@Name", folder.Name);
			command.Parameters.AddWithValue("@ParentFolderID", (object)folder.ParentFolderID ?? DBNull.Value);
			int rowsAffected = command.ExecuteNonQuery();
			Console.WriteLine(rowsAffected + " rows inserted");
			if (rowsAffected == 0)
			{
				// Handle the case where the insert was not successful
			}
			connection.Close();

			Refresh();
		}

		public void UpdateFolders()
		{
			string sql = "UPDATE Folder SET Name = @Name, ParentFolderID = @ParentFolderID WHERE ID = @ID";
			connection.Open();
			foreach (Folder folder in Folders)
			{
				SqlCommand command = new SqlCommand(sql, connection);
				command.Parameters.AddWithValue("@Name", folder.Name);
				command.Parameters.AddWithValue("@ParentFolderID", (object)folder.ParentFolderID ?? DBNull.Value);
				command.Parameters.AddWithValue("@ID", folder.ID);
				int rowsAffected = command.ExecuteNonQuery();
				Console.WriteLine(rowsAffected + " rows updated");
				if (rowsAffected == 0)
				{
					// Handle the case where the update was not successful
				}
			}
			connection.Close();

			Refresh();
		}


		public void RemoveFolder(Folder folder)
		{
			string sql = "DELETE FROM Folder WHERE ID = @ID";
			connection.Open();
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@ID", folder.ID);
			int rowsAffected = command.ExecuteNonQuery();
			Console.WriteLine(rowsAffected + " rows deleted");
			if (rowsAffected == 0)
			{
				// Handle the case where the delete was not successful
			}
			connection.Close();

			Refresh();
		}
		#endregion

		#region Step Write
		public void InsertStep(Step step)
		{
			string sql = "INSERT INTO Step (TestID, StepNum, StepDescription, StepResult) VALUES (@TestID, @StepNum, @StepDescription, @StepResult)";
			using (SqlCommand command = new SqlCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@TestID", step.TestID);
				command.Parameters.AddWithValue("@StepNum", step.StepNum);
				command.Parameters.AddWithValue("@StepDescription", step.StepDescription);
				command.Parameters.AddWithValue("@StepResult", step.StepResult);

				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
			Refresh();
		}

		public void UpdateSteps()
		{
			string sql = "UPDATE Step SET TestID = @TestID, StepNum = @StepNum, StepDescription = @StepDescription, StepResult = @StepResult WHERE ID = @ID";
			connection.Open();
			foreach (Step step in Steps)
			{
				using (SqlCommand command = new SqlCommand(sql, connection))
				{
					command.Parameters.AddWithValue("@ID", step.ID);
					command.Parameters.AddWithValue("@TestID", step.TestID);
					command.Parameters.AddWithValue("@StepNum", step.StepNum);
					command.Parameters.AddWithValue("@StepDescription", step.StepDescription);
					command.Parameters.AddWithValue("@StepResult", step.StepResult);

					int rowsAffected = command.ExecuteNonQuery();
					Console.WriteLine(rowsAffected + " step rows updated");
					if (rowsAffected == 0)
					{
						// Handle the case where the update was not successful
					}
				}
			}
			connection.Close();

			Refresh();
		}

		public void RemoveStep(int id)
		{
			string sql = "DELETE FROM Step WHERE ID = @ID";
			using (SqlCommand command = new SqlCommand(sql, connection))
			{
				command.Parameters.AddWithValue("@ID", id);

				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
			Refresh();
		}
		#endregion

	}
}
