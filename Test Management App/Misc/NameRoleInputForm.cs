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
	public partial class NameRoleInputForm : Form
	{

		public string NameInput { get; private set; }
		public int RoleInput { get; private set;
		}
		public NameRoleInputForm(TeamMember tm = null)
		{
			InitializeComponent();

			comboBox1.Items.AddRange(new string[] { "Manager", "Test Lead", "Test Engineer", "Read-Only" });

			if (tm == null)
				return;

			textBox1.Text = tm.Name;			
			comboBox1.SelectedIndex = tm.Role;			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			NameInput = textBox1.Text;
			RoleInput = comboBox1.SelectedIndex;
			DialogResult = DialogResult.OK;
		}
	}
}
