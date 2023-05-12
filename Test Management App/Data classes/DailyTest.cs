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
	}
}
