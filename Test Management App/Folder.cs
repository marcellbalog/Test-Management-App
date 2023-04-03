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

		public string ParentFolderDisplay { get; set; }


		private string GetParentFolderPath(List<Folder> parentFolders, int? parentFolderID)
		{
			if (parentFolderID == null)
				return string.Empty;

			var parentFolder = parentFolders.FirstOrDefault(pf => pf.ID == parentFolderID);
			if (parentFolder == null)
				return string.Empty;

			var parentFolderPath = GetParentFolderPath(parentFolders, parentFolder.ParentFolderID);
			return string.IsNullOrEmpty(parentFolderPath) ? parentFolder.Name : $"{parentFolderPath}/{parentFolder.Name}";
		}

		public string GetDisplayValue(List<Folder> parentFolders)
		{
			if (ParentFolderID != null)
				return $"{GetParentFolderPath(parentFolders, (int)ParentFolderID)}/{Name}";
			else
				return $"{Name}";
		}

	}
}
