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
	public partial class MainForm : Form
	{
		public Form activeForm = null;

		public MainForm()
		{
			InitializeComponent();

			activeForm = new TestLibraryForm();
		}

		private void OpenPageForm(Form pageForm)
		{
			if (activeForm != null)
				activeForm.Close();
			activeForm = pageForm;
			pageForm.TopLevel = false;
			pageForm.FormBorderStyle = FormBorderStyle.None;
			pageForm.Dock = DockStyle.Fill;
			pageFormPanel.Controls.Add(pageForm);
			pageFormPanel.Tag = pageForm;
			pageForm.BringToFront();
			pageForm.Show();

		}

		private void testLibrarybutton_Click(object sender, EventArgs e)
		{
			OpenPageForm(new TestLibraryForm());
		}
	}
}
