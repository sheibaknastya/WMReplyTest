using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace TestSolution.Helpers
{
    public class WebDriver
    {
        private static IWebDriver driver;

        public static void CreateDriver()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        public static IWebDriver GetDriver()
        {
            if (driver == null)
            {
                throw new SystemException("WebDriver has not been initialised");
            }
            return driver;
        }

        public static void QuitDriver()
        {
            if (driver != null)
            {
                driver.Quit();
                driver = null;
            }
        }
    }
}