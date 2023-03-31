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

		public Folder Folder { get; set; }
		public TeamMember TeamMember{ get; set; }		

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
				default:
					color = Color.Gray;
					break;
			}

			return color;
		}
	}
}
