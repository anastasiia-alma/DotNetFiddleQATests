using DotNetFiddleQATests.WebDriver;
using NUnit.Framework;

namespace DotNetFiddleQATests.Tests.UI
{
	abstract class UiTestBase: TestBase
	{
		[SetUp]
		public void StartBrowser() {
			Browser.Init();
			Browser.LoadApplication();
		}

		[TearDown]
		public void CloseBrowser() {
			Browser.Close();
		}
	}
}