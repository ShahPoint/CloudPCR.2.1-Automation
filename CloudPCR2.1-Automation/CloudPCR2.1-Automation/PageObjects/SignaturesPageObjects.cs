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
   public class SignaturesPageObjects : SelectingBrowsers
    {
        static By signButton = By.CssSelector("button.btn.btn-primary");
        static By nameTextbox = By.Id("Name");
        static By acceptButton = By.CssSelector("button.btn.btn-success");

        public static void EnterSignatureDetails()
        {
            signButton.ClickOnSpecificNumber(6);
            Thread.Sleep(2000);
            nameTextbox.EnterText("TestingSign");
            acceptButton.Click();
        }
    }
}
