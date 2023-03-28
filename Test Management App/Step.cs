using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class Step
	{
		public int ID { get; set; }
		public int TestID { get; set; }
		public int StepNum { get; set; }
		public string StepDescription { get; set; }
		public string StepResult { get; set; }
	}
}
