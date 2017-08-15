using CloudPCR2._1_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.PageObjects
{
    public class CreateNewPCRPageObjects : SelectingBrowsers
    {
        static By dispositionDropdown = By.CssSelector("select[originalngmodel='e20_10']");
        static By incidentNumberTextbox = By.CssSelector("input[originalngmodel='e02_02']");
        static By optionsDropdown = By.CssSelector("div.top-menu a.dropdown-toggle");
        static By saveLinkInsideOptionsDropdown = By.CssSelector("li.dropdown.open > ul > li:nth-child(2) > a");
        static By pcrSyncMessage = By.Id("toast-container");
        static By backButton = By.Id("undefined");


        public static void SelectValueInDispositionDropdown(string value)
        {
            SelectElement element = new SelectElement(driver.FindElement(dispositionDropdown));
            element.SelectByText(value);
        }

        public static void EnterIncidentNum(string num)
        {
            var obj = driver.FindElement(incidentNumberTextbox);
            obj.Clear();
            obj.SendKeys(num);
        }

        public static void ClickSaveButtonFromOptionsDropdown()
        {
            driver.FindElements(optionsDropdown)[1].Click();
            Thread.Sleep(1000);
            driver.FindElement(saveLinkInsideOptionsDropdown).Click();
        }

        public static void VerifyPCRSyncMessageDisplay()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(driver.FindElement(pcrSyncMessage).Text.Contains("PCR sync"), "Message is not coming");
        }

        public static void ClickBackButton()
        {
            driver.FindElement(backButton).Click();
            Thread.Sleep(1000);
        }
    }
}
