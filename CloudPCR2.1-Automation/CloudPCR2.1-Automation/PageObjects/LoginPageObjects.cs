using CloudPCR2._1_Automation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.PageObjects
{
    public class LoginPageObjects : SelectingBrowsers
    {
        static By userNameTextbox = By.Name("usernameOrEmailAddress");
        static By passwordTextbox = By.Name("password");
        static By loginButton = By.CssSelector("button[type = 'submit']");
        static By startDemoButton = By.CssSelector("a.btn.btn-success");

        public static void EnterLoginDetails(string userName, string password)
        {
           driver.FindElement(userNameTextbox).SendKeys(userName);
           driver.FindElement(passwordTextbox).SendKeys(password);
           driver.FindElement(loginButton).Click();
        }

        public static void ClickStartDemoButton()
        {
            Thread.Sleep(30000);
            driver.FindElement(startDemoButton).Click();
            Thread.Sleep(3000);
        }
    }
}
