using DotNetFiddleQATests.WebDriver;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetFiddleQATests.Pages
{
	public class PageBase
	{
        protected readonly IWebDriver driver = Browser.Driver;
		public PageBase() {
			PageFactory.InitElements(driver, this);
		}
	}
}