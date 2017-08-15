using CloudPCR2._1_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.PageObjects
{
    public class HomePageObjects : SelectingBrowsers
    {
        static By userNameSpanText = By.Id("HeaderCurrentUserName");
        static By createPCRButton = By.CssSelector("button.btn.btn-primary.blue");

        public static void VerifyHomePageDisplayed(string userName)
        {
            string loginText = driver.FindElement(userNameSpanText).Text;
            Assert.AreEqual(loginText, userName, "Logged in user name are not matching with the actual");
        }

        public static void ClickCreatePCRButton()
        {
            driver.FindElement(createPCRButton).Click();
        }
    }

}
