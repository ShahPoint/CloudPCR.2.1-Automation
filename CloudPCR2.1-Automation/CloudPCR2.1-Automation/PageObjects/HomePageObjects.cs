using CloudPCR2._1_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.PageObjects
{
    public class HomePageObjects : SelectingBrowsers
    {
        static By userNameSpanText = By.Id("HeaderCurrentUserName");
        static By createPCRButton = By.CssSelector("button.btn.btn-primary.blue");
        static By qaPCRLink = By.CssSelector("div > ul > li:nth-child(2) > ul > li:nth-child(1) > a > span");
        static By sidePanelIcons = By.CssSelector("ul.page-sidebar-menu a");

        public static void VerifyHomePageDisplayed(string userName)
        {
            string loginText = driver.FindElement(userNameSpanText).Text;
            Assert.AreEqual(loginText, userName, "Logged in user name are not matching with the actual");
        }

        public static void ClickCreatePCRButton()
        {
            driver.FindElement(createPCRButton).Click();
        }

        public static void ClickQAPcr()
        {
            driver.FindElement(qaPCRLink).Click();
            Thread.Sleep(2000);
        }

        public static void ClickSideIconLink(string iconName)
        {
           var elements= driver.FindElements(sidePanelIcons);
            foreach (var element in elements)
            {
                if (element.Text.Equals(iconName))
                {
                    element.Click();
                    break;
                }
            }
        }

    }

}
