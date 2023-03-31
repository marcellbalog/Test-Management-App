using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Management_App
{
	public partial class Testcase : Form
	{
		public Test thisTest { get; set; }

		public Testcase(Test t)
		{
			InitializeComponent();

			thisTest = t;
			LoadTestData();
		}

		private	void LoadTestData()
		{
			TestNameInput.Text = thisTest.TestName;
			DescriptionInput.Text = thisTest.Description;
			TeamMemberInput.Text = thisTest.TeamMember.Name;
			StatusInput.Text = thisTest.Status.ToString();			
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			thisTest.TestName = TestNameInput.Text;

			//call sql write
		}
	}
}
