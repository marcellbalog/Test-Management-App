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
		public List<TestData> testData;

		public MainFormModel()
		{
			connection = new SqlConnection(connectionString);
			testData = new List<TestData>();

			LoadTests();
		}


		public void LoadTests()
		{
			string sql = "SELECT * FROM Test";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				TestData item = new TestData();
				item.ID = (int)reader["ID"];
				item.FolderID = (int)reader["FolderID"];
				item.TeamMemberID = (int)reader["TeamMemberID"];
				item.TestName = reader["TestName"].ToString();
				item.Description = reader["Description"].ToString();
				item.Status = (int)reader["Status"];
				item.Result = (int)reader["Result"];


				testData.Add(item);
			}

			reader.Close();
			connection.Close();
		}

		public List<TestData> GetData()
		{
			return testData;
		}
	}
}
