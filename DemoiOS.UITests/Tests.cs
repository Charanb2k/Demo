using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.iOS;
using Xamarin.UITest.Queries;

namespace DemoiOS.UITests
{
	[TestFixture]
	public class Tests
	{
		iOSApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ConfigureApp.iOS.StartApp ();
		}

		[Test]
		public void ViewIsDisplayed ()
		{
			AppResult [] results = app.WaitForElement (c => c.Child ("UIView"));
			app.Screenshot ("First screen.");

			Assert.IsTrue (results.Any ());
		}

		[Test]
		public void ButtonDisplayed ()
		{
			AppResult [] result= app.WaitForElement (c => c.Class ("UIButton").Marked("Click here!"));
			app.Screenshot ("Button");
			Assert.IsTrue (result.Any ());
		}
	}
}

