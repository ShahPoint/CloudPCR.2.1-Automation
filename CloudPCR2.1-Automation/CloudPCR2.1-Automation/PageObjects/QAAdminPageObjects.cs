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
    class QAAdminPageObjects : SelectingBrowsers
    {
        static By incidentTextbox = By.CssSelector("td[aria-label='Column Incident Number, Filter cell'] input.dx-texteditor-input");
        static By actionsButton = By.CssSelector("#actionsTemplate button");
        static By deleteButtonInPopup = By.CssSelector("button[id='delete']");
        static By yesButton = By.CssSelector("div[aria-label='Yes'] div");
        static By firstIncidentValue = By.CssSelector("div.dx-scrollable-content > div > table > tbody > tr:nth-child(1) > td:nth-child(3)");

        public static void EnterTextInIncidentTextbox(string incidentText)
        {
            var incidentTB = driver.FindElement(incidentTextbox);
            incidentTB.Clear();
            incidentTB.SendKeys(incidentText);
            Thread.Sleep(4000);
        }

        public static void ClickOnActionsButton()
        {
            driver.FindElements(actionsButton)[0].Click();
            Thread.Sleep(3000);
        }

        public static void ClickOnDeleteButton()
        { 
            driver.FindElement(deleteButtonInPopup).Click();
            Thread.Sleep(2000);
        }

        public static void ClickOnYesButton()
        {
            driver.FindElement(yesButton).Click();
            Thread.Sleep(2000);
        }

        public static void VerifyFirstIncidentValueDisplay(string value)
        {
            var incidentTB = driver.FindElement(firstIncidentValue).Text;
            Assert.IsTrue(incidentTB.Contains(value), "Incident value is not coming");
        }

        public static void VerifyFirstIncidentValueNotDisplay(string value)
        {
            var incidentTB = driver.FindElement(firstIncidentValue).Text;
            Assert.IsFalse(incidentTB.Contains(value), "Incident value is still coming");
        }
    }        
}
