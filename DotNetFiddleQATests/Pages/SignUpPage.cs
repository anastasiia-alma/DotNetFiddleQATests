using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace DotNetFiddleQATests.Pages
{
    class SignUpPage : PageBase 
    {
        [FindsBy(How = How.XPath, Using = "//div[@id='signup-options']/a[text()[contains(.,'Twitter')]]")]
        public IWebElement openTwittterButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='signup-options']/a[text()[contains(.,'Facebook')]]")]
        private IWebElement openFacebookButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='signup-options']/a[text()[contains(.,'Gmail')]]")]
        private IWebElement openGmailButton;

        [FindsBy(How = How.XPath, Using = "//div[@id='signup-options']/a[text()[contains(.,'.NET Fiddle')]]")]
        private IWebElement openDotNetFiddlerButton;
    }
}
