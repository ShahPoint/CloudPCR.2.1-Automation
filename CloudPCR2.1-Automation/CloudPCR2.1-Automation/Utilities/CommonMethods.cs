using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.Utilities
{
    public static class CommonMethods
    {
        public static void Click(this By obj)
        {
            SelectingBrowsers.driver.FindElement(obj).Click();
        }

        public static void EnterText(this By obj,string value)
        {
            try
            {
                SelectingBrowsers.driver.FindElement(obj).Clear();
            }
            catch { }
            SelectingBrowsers.driver.FindElement(obj).SendKeys(value);
        }

        public static void SelectValueInDropdown(this By obj, string value)
        { 
            SelectElement element = new SelectElement(SelectingBrowsers.driver.FindElement(obj));
            element.SelectByText(value);
        }

        public static void ClickOnSpecificNumber(this By obj,int num)
        {
            SelectingBrowsers.driver.FindElements(obj)[num].Click();
        }
    }
}
