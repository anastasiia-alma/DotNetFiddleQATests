using DotNetFiddleQATests.Pages;
using NUnit.Framework;

namespace DotNetFiddleQATests.Tests.UI
{
    [TestFixture]
    class GettingStartedTests : UiTestBase
    {
        [Test(Description = "Verify 'Getting Started' page is opened after 'Getting Started' button click")]
        public void GettingStartedButtonTest()
        {
            var mainPage = new MainPage();
            mainPage.ClickOnGettingStartedButton();
            var gettingStartedPage = new GettingStartedPage();
            Assert.IsTrue(gettingStartedPage.IsOpened(), "'Getting Started' page is not displayed");
        }
	}
}
