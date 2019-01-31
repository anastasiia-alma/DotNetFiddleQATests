using System.Configuration;
using System.Linq;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace DotNetFiddleQATests.Tests {
	abstract class TestBase {
        private static readonly ExtentReports Report = new ExtentReports();
		protected ExtentTest ExtendTest;
		[SetUp]
		public void InitExtendTest() {
			var testName = TestContext.CurrentContext.Test.Name;
			var description = TestContext.CurrentContext.Test.Properties["Description"].FirstOrDefault()?.ToString();
			ExtendTest = Report.CreateTest(testName, description);

			var htmlReporter = new ExtentHtmlReporter(ConfigurationManager.AppSettings["Reports"]);
			Report.AttachReporter(htmlReporter);
		}

		[TearDown]
		public void SetTestStateAndFlush() {
			if (TestContext.CurrentContext.Result.Outcome.Status == TestStatus.Failed)
			{
				//"message" - for example
				ExtendTest.Fail(TestContext.CurrentContext.Result.Message);
			}

			ExtendTest = null;
			Report.Flush();
		}
	}
}
