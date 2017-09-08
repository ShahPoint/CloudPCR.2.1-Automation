using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.Utilities
{
    public class SelectingBrowsers
    { 

        public IWebDriver OpenBrowser(string browserName, string url)
        {
            switch (browserName)
            {
                case "Chrome":
                    driver = new ChromeDriver("c:\\");
                    driver.Navigate().GoToUrl(url);
                    driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(60);
                    driver.Manage().Window.Maximize();
                    break;
            }
            return driver;
        }

        public static IWebDriver driver
        {
            get;
            set;
        }

       public static string ReturnSelectObject(string value)
        {
            return "select[originalngmodel='" + value + "']";
        }

        public static string ReturnInputObject(string value)
        {
            return "input[originalngmodel='" + value + "']";
        }
    }
}
