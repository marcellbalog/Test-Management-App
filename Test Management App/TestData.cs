using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class TestData
	{
		public int ID { get; set; }
		public int FolderID { get; set; }
		public int TeamMemberID { get; set; }
		public string TestName { get; set; }
		public int Status { get; set; }
		public int Result { get; set; }
		public string Description { get; set; }
	}
}
