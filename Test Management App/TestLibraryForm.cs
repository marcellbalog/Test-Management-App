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
		public TestLibraryForm(MainFormModel model)
		{
			InitializeComponent();

			PopulateTestList(model.testData);
		}

		public void PopulateTestList(List<TestData> data)
		{
			foreach (TestData item in data)
			{
				TestRow tr = new TestRow();
				testListPanel.Controls.Add(tr);
				tr.Dock = DockStyle.Top;
				tr.TestID.Text = item.ID.ToString();
				tr.TestName.Text = item.TestName;

				Debug.WriteLine(item.TestName);
			}

			

		}
	}
}
