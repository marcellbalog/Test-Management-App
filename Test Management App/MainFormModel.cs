using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class MainFormModel
	{		

		private SqlConnection connection;
		public List<TestData> testData;

		public MainFormModel(string connectionString)
		{
			connection = new SqlConnection(connectionString);
			testData = new List<TestData>();
		}


		public void LoadTests()
		{
			string sql = "SELECT * FROM YourTableNameHere";
			SqlCommand command = new SqlCommand(sql, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				TestData item = new TestData();
				item.ID = (int)reader["ID"];
				item.Name = reader["Name"].ToString();
				

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
