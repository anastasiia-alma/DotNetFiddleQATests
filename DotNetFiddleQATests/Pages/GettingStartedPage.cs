using DotNetFiddleQATests.WebDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetFiddleQATests.Pages
{
    class GettingStartedPage
    {
        private IWebDriver driver = Browser.Driver;

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Back To Editor')]]")]
        private IWebElement backToEditorButton;

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Getting Started')]]")]
        private IWebElement gettingStartedButton;

        [FindsBy(How = How.XPath, Using = "//a[@id='run-button']")]
        private IWebElement searchButton;

        public GettingStartedPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public bool IsOpened()
        {
            return driver.IsElementPresent(By.XPath("//h1[text()='Overview']"));
        }

        public void ClickOnBackToEditorButton()
        {
            backToEditorButton.Click();
        }

        public void ClickOnGettingStartedButton()
        {
            gettingStartedButton.Click();
        }

        public void ClickOnSearchButton()
        {
            searchButton.Click();
        }

    }

}
