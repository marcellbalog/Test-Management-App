﻿using System;
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
	public partial class TestLibraryForm : Form
	{
		public TestLibraryForm()
		{
			InitializeComponent();
			PopulateTestList();
		}

		public void PopulateTestList()
		{
			for (int i = 0; i < 3; i++)
			{
				TestRow tr = new TestRow();
				testListPanel.Controls.Add(tr);
				tr.Dock = DockStyle.Top;
			}

			

		}
	}
}
