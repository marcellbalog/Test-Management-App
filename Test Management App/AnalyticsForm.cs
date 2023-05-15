using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Test_Management_App
{
	public partial class AnalyticsForm : Form
	{
		private MainForm mainForm;

		public AnalyticsForm(MainForm mf)
		{
			InitializeComponent();
			mainForm = mf;

			Setup();
		}

		private void Setup()
		{
			FolderComboBox.DataSource = mainForm.model.Folders;
			FolderComboBox.DisplayMember = "ParentFolderDisplay";
			FolderComboBox.ValueMember = "ID";
			FolderComboBox.SelectedItem = "Root";

			chart1.DataSource = mainForm.model.Tests;
			chart1.Series[0].XValueMember = "ResultName";
			chart1.Series[0].YValueMembers = "ID";
			//chart1.Series[0].Points..Color = Color.Blue;
			//chart1.Series[0].Points[1].Color = Color.Blue;
			//chart1.Series[0].Points[2].Color = Color.Pink;

			/*foreach (DataPoint point in chart1.Series[0].Points)
			{
				if (point.XValue == "+")
				{
					point.Color = Color.Red;
				}
				else if (point.XValue == 2.0)
				{
					point.Color = Color.Blue;
				}
			}*/
			



			chart2.DataSource = mainForm.model.Tests;
			chart2.Series[0].XValueMember = "StatusName";
			chart2.Series[0].YValueMembers = "ID";


			chart3.DataSource = mainForm.model.Tests;
			chart3.Series[0].XValueMember = "TeamMember";
			chart3.Series[0].YValueMembers = "ID";

			chart3.DataSource = mainForm.model.DailyTests;
			chart3.Series[0].XValueMember = "Action";
			chart3.Series[0].YValueMembers = "ID";
		}

		private void FolderComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Get the selected item from the FolderComboBox
			var selectedItem = (Folder)FolderComboBox.SelectedItem;
			int selectedFolderID = selectedItem.ID;





			List<int> folderIds = GetDescendantFolderIds(selectedFolderID);
			folderIds.Add(selectedFolderID);

			// Get all tests from the selected folder and its subfolders
			List<Test> testsInFolder = mainForm.model.Tests.Where(test => folderIds.Contains(test.FolderID)).ToList();

			chart1.DataSource = testsInFolder;
			chart1.DataBind();

			chart2.DataSource = testsInFolder;
			chart2.DataBind();

			chart3.DataSource = testsInFolder;
			chart3.DataBind();

			chart3.DataSource = testsInFolder;
			chart4.DataBind();
		}

		private List<int> GetDescendantFolderIds(int folderId)
		{
			// Get all direct children folders
			List<Folder> childFolders = mainForm.model.Folders.Where(folder => folder.ParentFolderID == folderId).ToList();

			List<int> descendantFolderIds = new List<int>();

			foreach (Folder childFolder in childFolders)
			{
				descendantFolderIds.Add(childFolder.ID);

				// Recursively get the IDs of all descendant folders of the child folder
				descendantFolderIds.AddRange(GetDescendantFolderIds(childFolder.ID));
			}

			return descendantFolderIds;
		}
	}
}
