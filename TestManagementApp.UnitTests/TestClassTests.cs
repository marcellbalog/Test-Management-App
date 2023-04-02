using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System;
using System.Drawing;
using Test_Management_App;
using Assert = NUnit.Framework.Assert;

namespace TestManagementApp.UnitTests
{
	[TestClass]
	public class TestClassTests
	{
		[TestMethod]
		public void GetStatusName_ReturnsNew_WhenStatusIs0()
		{
			var test = new Test { Status = 0 };

			var statusName = test.GetStatusName();

			Assert.That(statusName, Is.EqualTo("NEW"));
		}

		[TestMethod]
		public void GetStatusName_ReturnsDev_WhenStatusIs1()
		{
			var test = new Test { Status = 1 };

			var statusName = test.GetStatusName();

			Assert.That(statusName, Is.EqualTo("DEV"));
		}

		[TestMethod]
		public void GetStatusName_ReturnsDone_WhenStatusIs2()
		{
			var test = new Test { Status = 2 };

			var statusName = test.GetStatusName();

			Assert.That(statusName, Is.EqualTo("DONE"));
		}

		[TestMethod]
		public void GetStatusName_ReturnsNew_WhenStatusIsInvalid()
		{
			var test = new Test { Status = -1 };

			var statusName = test.GetStatusName();

			Assert.That(statusName, Is.EqualTo("NEW"));
		}

		[TestMethod]
		public void GetResultColor_ReturnsWhiteSmoke_WhenResultIs0()
		{
			var test = new Test { Result = 0 };

			var resultColor = test.GetResultColor();

			Assert.That(resultColor, Is.EqualTo(Color.WhiteSmoke));
		}

		[TestMethod]
		public void GetResultColor_ReturnsLime_WhenResultIs1()
		{
			var test = new Test { Result = 1 };

			var resultColor = test.GetResultColor();

			Assert.That(resultColor, Is.EqualTo(Color.Lime));
		}

		[TestMethod]
		public void GetResultColor_ReturnsCrimson_WhenResultIs2()
		{
			var test = new Test { Result = 2 };

			var resultColor = test.GetResultColor();

			Assert.That(resultColor, Is.EqualTo(Color.Crimson));
		}

		[TestMethod]
		public void GetResultColor_ReturnsGray_WhenResultIsInvalid()
		{
			var test = new Test { Result = -1 };

			var resultColor = test.GetResultColor();

			Assert.That(resultColor, Is.EqualTo(Color.Gray));
		}
	}
}
