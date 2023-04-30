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
		ExecutionForm ef;
	
		public ExecutionRow(Execution e, ExecutionForm ef)
		{
			InitializeComponent();

			thisExecution = e;
			this.ef = ef;
			Setup();
		}

		private void Setup()
		{
			labelID.Text = "E" + thisExecution.ID.ToString();
			labelDate.Text = thisExecution.Date.Date.ToShortDateString();
			labelResult.Text = thisExecution.ResultName.ToString();
			labelTime.Text = TimeSpan.FromSeconds(thisExecution.Time).ToString(@"mm\:ss\:ff");
			PictureResult.BackColor = thisExecution.ResultColor;
		}

		private void panel1_Click(object sender, EventArgs e)
		{
			ef.UpdateSideInfo(thisExecution);
		}
	}
}

