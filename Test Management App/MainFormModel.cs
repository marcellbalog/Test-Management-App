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
		public List<Execution> Executions = new List<Execution>();

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
			LoadExecutions();
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
					Precondition = reader["Precondition"].ToString(),
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
					Comment = reader["Comment"].ToString(),
					Action = (int)reader["Action"]
				};

				DailyTests.Add(item);
			}

			reader.Close();
			connection.Close();
		}

		private void LoadExecutions()
		{
			string sql = "SELECT * FROM Execution";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				Execution item = new Execution
				{
					ID = (int)reader["ID"],
					TestID = (int)reader["TestID"],
					Date = (DateTime)reader["Date"],
					Time = (double)reader["Time"],
					Result = (int)reader["Result"],
					FailedStepID = (int)reader["FailedStepID"],
					Comment = reader["Comment"].ToString()
				};

				Executions.Add(item);
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
			Executions.Clear();

			LoadTeamMembers();
			LoadFolders();
			LoadTests();
			LoadSteps();
			LoadScheduleDays();
			LoadDailyTests();
			LoadExecutions();
		}

		#region Test Write
		public void UpdateTests()
		{
			string sql = "UPDATE Test SET FolderID = @FolderID, TeamMemberID = @TeamMemberID, TestName = @TestName, Description = @Description, Status = @Status, Precondition = @Precondition, Result = @Result WHERE ID = @ID";
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
				command.Parameters.AddWithValue("@Precondition", test.Precondition);

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
			string sql = "INSERT INTO Test (FolderID, TeamMemberID, TestName, Description, Status, Result, Precondition) VALUES (@FolderID, @TeamMemberID, @TestName, @Description, @Status, @Result, @Precondition)";
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@FolderID", test.FolderID);
			command.Parameters.AddWithValue("@TeamMemberID", test.TeamMemberID);
			command.Parameters.AddWithValue("@TestName", test.TestName);
			command.Parameters.AddWithValue("@Description", test.Description);
			command.Parameters.AddWithValue("@Status", test.Status);
			command.Parameters.AddWithValue("@Result", test.Result);
			command.Parameters.AddWithValue("@Precondition", test.Precondition);

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

		#region TeamMember Write
		public void InsertTeamMember(TeamMember teamMember)
		{
			string sql = "INSERT INTO TeamMember (ID, Name) VALUES (@ID, @Name)";
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@ID", teamMember.ID);
			command.Parameters.AddWithValue("@Name", teamMember.Name);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			Refresh();
		}

		public void UpdateTeamMembers()
		{
			string sql = "UPDATE TeamMember SET Name = @Name WHERE ID = @ID";
			connection.Open();
			foreach (TeamMember teamMember in TeamMembers)
			{
				SqlCommand command = new SqlCommand(sql, connection);
				command.Parameters.AddWithValue("@ID", teamMember.ID);
				command.Parameters.AddWithValue("@Name", teamMember.Name);

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

		public void RemoveTeamMember(TeamMember teamMember)
		{
			string sql = "DELETE FROM TeamMember WHERE ID = @ID";
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@ID", teamMember.ID);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			Refresh();
		}
		#endregion


		#region Schedule Write
		public void InsertScheduleDay(ScheduleDay scheduleDay)
		{
			string sql = "INSERT INTO ScheduleDay (Date) VALUES (@Date)";
			SqlCommand command = new SqlCommand(sql, connection);			
			command.Parameters.AddWithValue("@Date", scheduleDay.Date);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			Refresh();
		}

		public void UpdateScheduleDays()
		{
			string sql = "UPDATE ScheduleDay SET Date = @Date WHERE ID = @ID";
			connection.Open();
			foreach (ScheduleDay scheduleDay in ScheduleDays)
			{
				SqlCommand command = new SqlCommand(sql, connection);
				command.Parameters.AddWithValue("@ID", scheduleDay.ID);
				command.Parameters.AddWithValue("@Date", scheduleDay.Date);

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


		public void RemoveScheduleDay(ScheduleDay scheduleDay)
		{
			string sql = "DELETE FROM ScheduleDay WHERE ID = @ID";
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@ID", scheduleDay.ID);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			Refresh();
		}
		#endregion

		#region DailyTests Write
		public void InsertDailyTest(DailyTest dailyTest)
		{
			string sql = "INSERT INTO DailyTest (TeamMemberID, ScheduleDayID, TestID, Comment, Action) VALUES (@TeamMemberID, @ScheduleDayID, @TestID, @Comment, @Action)";
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@TeamMemberID", dailyTest.TeamMemberID);
			command.Parameters.AddWithValue("@ScheduleDayID", dailyTest.ScheduleDayID);
			command.Parameters.AddWithValue("@TestID", dailyTest.TestID);
			command.Parameters.AddWithValue("@Comment", dailyTest.Comment);
			command.Parameters.AddWithValue("@Action", dailyTest.Action);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			Refresh();
		}

		public void UpdateDailyTests()
		{
			string sql = "UPDATE DailyTest SET TeamMemberID = @TeamMemberID, ScheduleDayID = @ScheduleDayID, TestID = @TestID, Comment = @Comment, Action = @Action WHERE ID = @ID";
			connection.Open();
			foreach (DailyTest dailyTest in DailyTests)
			{
				SqlCommand command = new SqlCommand(sql, connection);
				command.Parameters.AddWithValue("@TeamMemberID", dailyTest.TeamMemberID);
				command.Parameters.AddWithValue("@ScheduleDayID", dailyTest.ScheduleDayID);
				command.Parameters.AddWithValue("@TestID", dailyTest.TestID);
				command.Parameters.AddWithValue("@Comment", dailyTest.Comment);
				command.Parameters.AddWithValue("@ID", dailyTest.ID);
				command.Parameters.AddWithValue("@Action", dailyTest.Action);				

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

		public void RemoveDailyTest(DailyTest dailyTest)
		{
			string sql = "DELETE FROM DailyTest WHERE ID = @ID";
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@ID", dailyTest.ID);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			Refresh();
		}

		#endregion

		#region Execution Write
		public void InsertExecution(Execution execution)
		{
			string sql = "INSERT INTO Execution (TestID, Date, Time, Result, FailedStepID, Comment) VALUES (@TestID, @Date, @Time, @Result, @FailedStepID, @Comment)";
			SqlCommand command = new SqlCommand(sql, connection);			
			command.Parameters.AddWithValue("@TestID", execution.TestID);
			command.Parameters.AddWithValue("@Date", execution.Date);
			command.Parameters.AddWithValue("@Time", execution.Time);
			command.Parameters.AddWithValue("@Result", execution.Result);
			command.Parameters.AddWithValue("@FailedStepID", execution.FailedStepID);
			command.Parameters.AddWithValue("@Comment", execution.Comment);

			connection.Open();
			command.ExecuteNonQuery();
			connection.Close();

			Refresh();
		}

		public void UpdateExecutions()
		{
			string sql = "UPDATE Execution SET TestID = @TestID, Date = @Date, Time = @Time, Result = @Result, FailedStepID = @FailedStepID, Comment = @Comment WHERE ID = @ID";
			connection.Open();
			foreach (Execution execution in Executions)
			{
				SqlCommand command = new SqlCommand(sql, connection);
				command.Parameters.AddWithValue("@TestID", execution.TestID);
				command.Parameters.AddWithValue("@Date", execution.Date);
				command.Parameters.AddWithValue("@Time", execution.Time);
				command.Parameters.AddWithValue("@Result", execution.Result);
				command.Parameters.AddWithValue("@FailedStepID", execution.FailedStepID);
				command.Parameters.AddWithValue("@Comment", execution.Comment);
				command.Parameters.AddWithValue("@ID", execution.ID);

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

		public void RemoveExecution(int id)
		{
			string sql = "DELETE FROM Execution WHERE ID = @ID";
			SqlCommand command = new SqlCommand(sql, connection);
			command.Parameters.AddWithValue("@ID", id);

			connection.Open();
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
	}
}
