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
	public partial class TestRow : UserControl
	{
		MainForm mainForm;
		private Test thisTest { get; set; }

		public TestRow(Test t, MainForm mf)
		{
			InitializeComponent();
			thisTest = t;
			mainForm = mf;
			Debug.WriteLine(thisTest + " " + t);
		}

		private void TestRow_Click(object sender, EventArgs e)
		{

			Debug.WriteLine("click test");
			Debug.WriteLine(thisTest + " ");

			Testcase tc = new Testcase(thisTest, mainForm) { isNew = false };
			tc.Show();			

		}
	}
}
