using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Management_App
{
	public class Folder
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public int? ParentFolderID { get; set; }
	}
}
