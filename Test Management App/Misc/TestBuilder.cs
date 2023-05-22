using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class TestBuilder
	{
		private Test test;

		public TestBuilder(Test test)
		{
			this.test = test;
		}

		public TestBuilder WithName(string name)
		{
			test.TestName = name;
			return this;
		}

		public TestBuilder WithDescription(string description)
		{
			test.Description = description;
			return this;
		}

		public TestBuilder WithPrecondition(string precondition)
		{
			test.Precondition = precondition;
			return this;
		}

		public TestBuilder WithFolderID(int folderID)
		{
			test.FolderID = folderID;
			return this;
		}

		public TestBuilder WithTeamMemberID(int teamMemberID)
		{
			test.TeamMemberID = teamMemberID;
			return this;
		}

		public TestBuilder WithStatus(string statusName, Dictionary<int, string> statusNames)
		{
			int statusValue = statusNames.FirstOrDefault(x => x.Value == statusName).Key;
			test.Status = statusValue;
			return this;
		}

		// Add more modification methods for other properties as needed

		public Test Build()
		{
			return test;
		}
	}

}
