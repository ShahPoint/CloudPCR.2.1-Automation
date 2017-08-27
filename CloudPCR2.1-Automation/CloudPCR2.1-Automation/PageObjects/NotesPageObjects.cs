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
    public class NotesPageObjects : SelectingBrowsers
    {
        static By addNoteButton = By.CssSelector("button.btn.btn-default.pull-right");
        static By addNoteTextarea = By.Name("pcr.forms.notes.text");

        static By addNoteTagsTextbox = By.CssSelector(ReturnInputObject("forms.notes.tags"));
        static By saveButton = By.CssSelector("button.btn.btn-default");

        public static void EnterNotesDetails()
        {
            addNoteButton.Click();
            addNoteTextarea.EnterText("Notes text");
            addNoteTagsTextbox.EnterText("tag");
            saveButton.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
        }

    }
}
