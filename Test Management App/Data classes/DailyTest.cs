using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class DailyTest
	{
		public int ID { get; set; }
		public int TeamMemberID { get; set; }
		public int ScheduleDayID { get; set; }
		public int TestID { get; set; }
		public string Comment { get; set; }
		public int Action { get; set; }

		public string ActionName => GetActionName();

		public string GetActionName()
		{
			string text;
			switch (Action)
			{
				case 0:
					text = "DEV";
					break;
				case 1:
					text = "RUN";
					break;
				case 2:
					text = "FIX";
					break;
				default:
					text = "DEV";
					break;
			}

			return text;
		}
	}
}
