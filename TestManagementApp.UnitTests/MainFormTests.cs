using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Test_Management_App;
using System.Windows.Forms;

namespace TestManagementApp.UnitTests
{
	[TestClass]
	public class MainFormTests
	{
		[TestMethod]
		public void OpenPageForm_Should_Show_Form()
		{
			// Arrange
			var mainForm = new MainForm();
			var pageForm = new TestLibraryForm();
			var privateObject = new PrivateObject(mainForm); // create PrivateObject for MainForm instance


			// Act
			privateObject.Invoke("OpenPageForm", new object[] { pageForm }); // invoke OpenPageForm method through PrivateObject


			// Assert
			Assert.AreEqual(pageForm, mainForm.activeForm);			

		}
	}
}
