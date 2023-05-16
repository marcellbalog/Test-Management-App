using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_Management_App
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
			Application.ThreadException += Application_ThreadException;
			AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}


		// Handle the exception in UI thread
		private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
		{
			
			HandleException(e.Exception);
		}


		// Handle the exception in any (other) thread
		private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
		{
			
			Exception exception = e.ExceptionObject as Exception;
			if (exception != null)
			{
				HandleException(exception);
			}
		}

		private static void HandleException(Exception exception)
		{
			// Log the exception or perform any other necessary actions
			LogException(exception);

			// Display an error message to the user or handle the exception as needed
			MessageBox.Show("An error occurred. Please contact support.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

			// Application.Exit();
			// Environment.Exit(1);
		}

		private static void LogException(Exception exception)
		{
			Console.WriteLine($"Exception: {exception.Message}");
		}
	}

}
