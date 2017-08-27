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
    class AttachmentsFormsPageObjects : SelectingBrowsers
    {
        static By addNoteTagsTextbox = By.CssSelector("select.form-control");
        static By createButton = By.CssSelector("button.btn.btn-default");

        public static void EnterAttachmentDetails()
        {
            addNoteTagsTextbox.SelectValueInDropdown("Mulvane IDM");
            //createButton.Click();
            //Thread.Sleep(4000);
            //createButton.ClickOnSpecificNumber(12);
            //Thread.Sleep(2000);
        }

    }
}
