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

		private ContextMenuStrip contextMenuStrip1;
		private ToolStripMenuItem addFolderMenuItem;
		private ToolStripMenuItem renameFolderMenuItem;
		private ToolStripMenuItem deleteFolderMenuItem;

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
				tr.TestStatus.Text = item.StatusName;
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
			Testcase tc = new Testcase(newTest, mainForm) { isNew = true};			
			tc.Show();
		}

		private void PopulateTreeView(List<Folder> folders)
		{
			treeView1.Nodes.Clear();

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

			// Root node expanded on start
			treeView1.Nodes[0].Expand();



			// Adding context menu for hierarchy nodes
			contextMenuStrip1 = new ContextMenuStrip();			
			contextMenuStrip1.Items.Add(addFolderMenuItem = new ToolStripMenuItem("Add folder"));
			contextMenuStrip1.Items.Add(renameFolderMenuItem = new ToolStripMenuItem("Rename"));
			contextMenuStrip1.Items.Add(deleteFolderMenuItem = new ToolStripMenuItem("Delete"));

			// Add event handlers
			addFolderMenuItem.Click += new EventHandler(addFolderMenuItem_Click);
			renameFolderMenuItem.Click += new EventHandler(renameFolderMenuItem_Click);
			deleteFolderMenuItem.Click += new EventHandler(removeFolderMenuItem_Click);
			
			treeView1.ContextMenuStrip = contextMenuStrip1;
		}


		// For selecting the node with right click (when opening context menu)
		void treeView1_NodeMouseClick(object sender,TreeNodeMouseClickEventArgs e)
		{
			if (e.Button == MouseButtons.Right)
			{				
				treeView1.SelectedNode = e.Node;
			}
		}

		// Add new folder node
		private void addFolderMenuItem_Click(object sender, EventArgs e)
		{
			using (var form = new NameInputForm())
			{
				if (form.ShowDialog() == DialogResult.OK)
				{					
					TreeNode selectedNode = treeView1.SelectedNode;

					// Add a new child node to the selected node with the entered name
					var newNode = selectedNode.Nodes.Add(form.NameInput);

					Folder newFolder = new Folder();
					newFolder.Name = form.NameInput;
					newFolder.ID = mainForm.model.Folders.Last().ID + 1;

					// If the selected node represents a folder, set the ParentFolderID of the new folder
					if (selectedNode.Tag is Folder parentFolder)
					{
						newFolder.ParentFolderID = parentFolder.ID;
					}
					
					mainForm.model.Folders.Add(newFolder);

					// Set the Tag property (for the display function)
					newNode.Tag = newFolder;
				}
			}


			PopulateTreeView(mainForm.model.Folders);
		}

		private void renameFolderMenuItem_Click(object sender, EventArgs e)
		{
			TreeNode selectedNode = treeView1.SelectedNode;

			Folder f = (Folder)selectedNode.Tag;


			using (var form = new NameInputForm(f.Name))
			{							
				if (form.ShowDialog() == DialogResult.OK)
				{					
					f.Name = form.NameInput;															
				}
			}


			PopulateTreeView(mainForm.model.Folders);
		}

		// Remove the selected node
		private void removeFolderMenuItem_Click(object sender, EventArgs e)
		{			
			TreeNode selectedNode = treeView1.SelectedNode;


			if (selectedNode.Tag is Folder selectedFolder)
			{
				// If it's root folder, cancel method
				if (selectedFolder.ID == 0)
					return;


				DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this folder? (All child folders will be removed, and all of the tests will be relocated to the parent folder.)", "Delete", MessageBoxButtons.YesNo);

				if (dialogResult == DialogResult.Yes)
				{
					// Recursively find and remove all child folders
					RemoveChildFolders(selectedFolder);

					// Remove the folder from the data model
					mainForm.model.Folders.Remove(selectedFolder);

					// Update the tests to have the removed folder's parent folder ID as their FolderID (move the tests up a level)
					foreach (var test in mainForm.model.Tests.Where(t => t.FolderID == selectedFolder.ID))
					{
						test.FolderID = (int)selectedFolder.ParentFolderID;
					}

					// Remove the node from the TreeView
					selectedNode.Remove();
				}
				
			}			

			PopulateTreeView(mainForm.model.Folders);

		}

		private void RemoveChildFolders(Folder parentFolder)
		{
			var childFolders = mainForm.model.Folders.Where(f => f.ParentFolderID == parentFolder.ID).ToList();
			foreach (var childFolder in childFolders)
			{				
				RemoveChildFolders(childFolder);

				// Update the tests to have the parent folder's ID as their ParentFolderID
				foreach (var test in mainForm.model.Tests.Where(t => t.FolderID == childFolder.ID))
				{
					test.FolderID = (int)parentFolder.ParentFolderID;
				}

				mainForm.model.Folders.Remove(childFolder);
			}
		}




		private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
		{			
			CurrentFolderLabel.Text = treeView1.SelectedNode.FullPath;
			
			Folder selectedFolder = (Folder)treeView1.SelectedNode.Tag;

			// Get a list of all Folder IDs that are descendants of the selected folder + the selected folder
			List<int> folderIds = GetDescendantFolderIds(selectedFolder.ID);		
			folderIds.Add(selectedFolder.ID);

			// Get all tests from the selected folder and its subfolders
			List<Test> testsInFolder = mainForm.model.Tests.Where(test => folderIds.Contains(test.FolderID)).ToList();

			PopulateTestList(testsInFolder);
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
