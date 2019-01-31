using DotNetFiddleQATests.Pages;
using NUnit.Framework;
using DotNetFiddleQATests.WebDriver;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NLog;
using System.Configuration;

namespace DotNetFiddleQATests
{
    [TestFixture]
    class GettingStartedTests
    {
        public static ExtentReports report = new ExtentReports();
        public static ExtentTest test;

        [SetUp]
        public void StartBrowser()
        {
            var htmlReporter = new ExtentHtmlReporter(ConfigurationManager.AppSettings["Reports"]);
            report.AttachReporter(htmlReporter);
            Browser.Init();
            Browser.LoadApplication();
        }

        [Test]
        public void GettingStartedButtonTest()
        {
            test = report.CreateTest("'Getting Started' button is working", 
                "Verify 'Getting Started' page is opened after 'Getting Started' button click");
            var mainPage = new MainPage();
            mainPage.ClickOnGettingStartedButton();
            var gettingStartedPage = new GettingStartedPage();
            Assert.IsTrue(gettingStartedPage.IsOpened(), "'Getting Started' page is not displayed");
        }

        [TearDown]
        public void CloseBrowser()
        {
           Browser.Close();
           report.Flush();
        }

    }
}
