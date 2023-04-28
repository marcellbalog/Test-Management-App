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
	
	public partial class ExecutionRow : UserControl
	{
		public Execution thisExecution;
	
		public ExecutionRow(Execution e)
		{
			InitializeComponent();

			thisExecution = e;
			Setup();
		}

		private void Setup()
		{
			labelID.Text = "E" + thisExecution.ID.ToString();
			labelDate.Text = thisExecution.Date.Date.ToString();
			labelResult.Text = thisExecution.ResultName.ToString();
			labelTime.Text = thisExecution.Time.ToString();
			PictureResult.BackColor = thisExecution.ResultColor;
		}
	}
}

