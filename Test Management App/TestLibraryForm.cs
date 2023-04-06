using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Management_App
{
	public partial class TestLibraryForm : Form
	{
		MainForm mainForm;

		List<TestRow> testRows = new List<TestRow>();

		public TestLibraryForm(MainForm mf)
		{
			InitializeComponent();

			mainForm = mf;
			PopulateTestList(mainForm.model.Tests);


			PopulateTreeView(mainForm.model.Folders);
		}

		public void PopulateTestList(List<Test> data)
		{
			Debug.WriteLine(data.Count());
			testListPanel.Controls.Clear();
			foreach (Test item in data)
			{
				TestRow tr = new TestRow (item, mainForm);
				testRows.Add(tr);				
				testListPanel.Controls.Add(tr);
				tr.Dock = DockStyle.Top;
				tr.MaximumSize = new Size(default, 45);
				tr.MinimumSize = new Size(default, 45);
				tr.TestID.Text = "T" + item.ID.ToString();
				tr.TestName.Text = item.TestName;

				tr.TestOwner.Text = item.TeamMember.Name;
				tr.TestStatus.Text = item.GetStatusName();
				tr.TestResult.BackColor = item.GetResultColor();



				Debug.WriteLine(item.TestName + item.Status + item.Result + item.TeamMemberID);
			}
		}

		private void RefreshButton_Click(object sender, EventArgs e)
		{
			//refresh from db
			mainForm.model.Refresh();
			PopulateTestList(mainForm.model.Tests);
		}

		private void NewButton_Click(object sender, EventArgs e)
		{
			Test newTest = new Test();
			newTest.TestName = "Default Test Name";
			Testcase tc = new Testcase(newTest, mainForm);
			tc.Show();
		}

		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{
			Console.WriteLine(treeView1.SelectedNode.Text);

			CurrentFolderLabel.Text = treeView1.SelectedNode.FullPath;
		}

		private void PopulateTreeView(List<Folder> folders)
		{
			Dictionary<int, TreeNode> nodes = new Dictionary<int, TreeNode>();

			foreach (Folder folder in folders)
			{
				// Create a new TreeNode for the current Folder
				TreeNode node = new TreeNode(folder.Name);
				node.Tag = folder;

				nodes.Add(folder.ID, node);

				// If the current Folder has a parent, add the TreeNode as a child of its parent's TreeNode
				if (folder.ParentFolderID.HasValue && nodes.ContainsKey(folder.ParentFolderID.Value))
				{
					nodes[folder.ParentFolderID.Value].Nodes.Add(node);
				}
				else
				{
					// Otherwise, add the TreeNode as a root node
					treeView1.Nodes.Add(node);
				}
			}
		}

	}
}
