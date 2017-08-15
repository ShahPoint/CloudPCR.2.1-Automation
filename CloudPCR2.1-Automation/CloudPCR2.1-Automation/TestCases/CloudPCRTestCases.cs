using CloudPCR2._1_Automation.PageObjects;
using CloudPCR2._1_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.TestCases
{
    [TestClass]
   public class CloudPCRTestCases : DriverScenarios
    {
        [TestMethod]
        public void VerifyPCRCanBeAddedAndDeleted()
        {
            LoginPageObjects.EnterLoginDetails(GlobalVariables.userName, GlobalVariables.password);
            LoginPageObjects.ClickStartDemoButton();
            HomePageObjects.VerifyHomePageDisplayed(GlobalVariables.userName);
            HomePageObjects.ClickCreatePCRButton();
            CreateNewPCRPageObjects.SelectValueInDispositionDropdown("Cancelled");
            CreateNewPCRPageObjects.EnterIncidentNum("TeamcityPCR");
            CreateNewPCRPageObjects.ClickSaveButtonFromOptionsDropdown();
            CreateNewPCRPageObjects.VerifyPCRSyncMessageDisplay();
            CreateNewPCRPageObjects.ClickBackButton();
        }
    }
    
}
