using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Management_App
{
	public class MyTreeView : System.Windows.Forms.TreeView
	{

		[DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
		private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

		public MyTreeView()
		{
			SetWindowTheme(this.Handle, "explorer", null);
		}
	}

}
