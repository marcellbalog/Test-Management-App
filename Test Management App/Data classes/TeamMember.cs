using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class TeamMember
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int Role { get; set; }

		public string RoleName => GetRoleName();
		public string DisplayInfo => Name + " (" + RoleName + ")";

		public string GetRoleName()
		{
			string text;
			switch (Role)
			{
				case 0:
					text = "Manager";
					break;
				case 1:
					text = "Test Lead";
					break;
				case 2:
					text = "Test Engineer";
					break;
				case 3:
					text = "Read-Only";
					break;
				default:
					text = "Read-Only";
					break;
			}
			return text;
		}
	}
}
