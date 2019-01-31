using NUnit.Framework;

namespace DotNetFiddleQATests.Tests
{
	[TestFixture]
	class TestsForFillReportFixture : TestBase
	{
		[TestCase(false, TestName = "Failed test with description", Description = "Failed test's description")]
		[TestCase(true, TestName = "Passed test without description")]
		public void GettingStartedButtonTest(bool fail) {
			if (fail) {
				Assert.Fail("Check not passed");
			}
		}
	}
}