using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetFiddleQATests.WebDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetFiddleQATests.Pages
{
    class MainPage
    {
        private readonly IWebDriver driver = Browser.Driver;

        [FindsBy(How = How.XPath, Using = "//a[text()[contains(.,'Getting Started')]]")]
        private IWebElement gettingStartedButton;

        public MainPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public void ClickOnGettingStartedButton()
        {
           driver.FindElement(By.XPath("//a[text()[contains(.,'Getting Started')]]"), 3).Click("'Getting Started' Button");
        }

    }
}
