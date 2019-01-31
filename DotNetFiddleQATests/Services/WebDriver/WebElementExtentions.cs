using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DotNetFiddleQATests.WebDriver
{
    static class WrappedWebElement
    {
        private static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public static bool IsElementPresent(this IWebDriver driver, By locator)
        {
            try
            {
                driver.FindElement(locator);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public static bool IsDisplayed(this IWebElement element)
        {
            bool result;
            try
            {
                result = element.Displayed;
            }
            catch (NoSuchElementException)
            {
                result = false;
            }
            return result;
        }

        public static IWebElement FindElement(this IWebDriver driver, By by, int timeoutInSeconds)
        {
            logger.Info("Waiting for a visible element found by '{0}'", by.ToString());
            IWait<IWebDriver> wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeoutInSeconds));
            return wait.Until(ExpectedConditions.ElementIsVisible(by));
        }

        public static void Click(this IWebElement element, string elementName)
        {
            logger.Info("Clicking on '{0}'", elementName);
            element.Click();
        }

    }
}
