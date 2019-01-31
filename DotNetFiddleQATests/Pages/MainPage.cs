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
    class MainPage : PageBase {
        [FindsBy(How = How.XPath, Using = ".//a[text()[contains(.,'Getting Started')]]")]
        private IWebElement gettingStartedButton;

        public void ClickOnGettingStartedButton()
        {
	        gettingStartedButton.Click("'Getting Started' Button");
        }
    }
}
