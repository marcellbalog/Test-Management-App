using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class Test
	{
		public int ID { get; set; }
		public int FolderID { get; set; }
		public int TeamMemberID { get; set; }
		public string TestName { get; set; }
		public int Status { get; set; }
		public int Result { get; set; }
		public string Description { get; set; }
		public string Precondition { get; set; }
		public Folder Folder { get; set; }
		public TeamMember TeamMember{ get; set; }

		// Property for display that combines the ID and TestName properties into a single string
		public string DisplayText => $"T{ID}  {TestName}";

		public string StatusName => GetStatusName();

		public string ResultName => GetResultName();

		public string GetStatusName()
		{
			string text;
			switch (Status)
			{
				case 0:
					text = "NEW";
					break;
				case 1:
					text = "DEV";
					break;
				case 2:
					text = "DONE";
					break;
				default:
					text = "NEW";
					break;
			}

			return text;
		}

		public Color GetResultColor()
		{
			Color color;
			switch (Result)
			{
				case 0:
					color = Color.WhiteSmoke;
					break;
				case 1:
					color = Color.Lime;
					break;
				case 2:
					color = Color.Crimson;
					break;
				case 3:
					color = Color.Orange;
					break;
				default:
					color = Color.Gray;
					break;
			}

			return color;
		}

		public string GetResultName()
		{
			string name;
			switch (Result)
			{
				case 0:
					name = "NOT EXECUTED";
					break;
				case 1:
					name = "SUCCESS";
					break;
				case 2:
					name = "FAIL";
					break;
				case 3:
					name = "TERMINATED";
					break;
				default:
					name = "NOT EXECUTED";
					break;
			}

			return name;
		}
	}
}

