using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System.Configuration;

namespace DotNetFiddleQATests.WebDriver
{
    class Browser
    {
        public static IWebDriver Driver { get; private set; }

        public static void Init()
        {
            //лучше использовать Nuget-пакеты с драйверами. Проще отслеживать версии браузеров и реп не распухает
            string driverPath = ConfigurationManager.AppSettings["DriverPath"];
                switch (ConfigurationManager.AppSettings["Browser"])
                {
                    case "Firefox":
                            Driver = new FirefoxDriver(driverPath);
                        break;

                    case "IE":
                            Driver = new InternetExplorerDriver(driverPath);
                        break;

                    case "Chrome":
                        Driver = new ChromeDriver(driverPath);
                        break;
                    default:
                        throw new ArgumentException("Browser's name is not recognized! Please, check 'Browser' property in App.config");

                }
            Driver.Manage().Window.Maximize();
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(3);
        }

        public static void LoadApplication()
        {
            //по-хорошему, "драйвер" самостоятельная сущность и может работать
            //с разными проектами. Не стоит хардкодить какие-то урлы в этом классе
            Driver.Url = ConfigurationManager.AppSettings["URL"];
        }

        public static void Close()
        {
            if (Driver != null)
            {
                Driver.Close();
                Driver.Quit();
            }
        }
    }
}
