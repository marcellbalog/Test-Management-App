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
	public partial class NameInputForm : Form
	{

		public string NameInput { get; private set; }
		public NameInputForm()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NameInput = textBox1.Text;
			DialogResult = DialogResult.OK;
		}
	}
}
