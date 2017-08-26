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
        PCRVariables pcr = new PCRVariables();

        public CloudPCRTestCases()
        { 
           pcr= SeedData(pcr);
        }       

        [TestMethod]
        public void VerifyPCRCanBeAddedAndDeleted()
        {
            string randomName = "TeamcityPCR" + new Random().Next();
            LoginPageObjects.EnterLoginDetails(GlobalVariables.userName, GlobalVariables.password);
            LoginPageObjects.ClickStartDemoButton();
            HomePageObjects.VerifyHomePageDisplayed(GlobalVariables.userName);
            HomePageObjects.ClickCreatePCRButton();
            CreateNewPCRPageObjects.SelectValueInDispositionDropdown("Cancelled");
            CreateNewPCRPageObjects.EnterIncidentNum(randomName);
            CreateNewPCRPageObjects.ClickSaveButtonFromOptionsDropdown();
            CreateNewPCRPageObjects.VerifyPCRSyncMessageDisplay();
            CreateNewPCRPageObjects.ClickBackButton();
            HomePageObjects.ClickQAPcr();
            QAAdminPageObjects.EnterTextInIncidentTextbox(randomName);
            QAAdminPageObjects.ClickOnActionsButton();
            QAAdminPageObjects.ClickOnDeleteButton();
            QAAdminPageObjects.ClickOnYesButton();
            QAAdminPageObjects.VerifyFirstIncidentValueNotDisplay(randomName);

        }


        [TestMethod]
        public void VerifyPCRCanBeAddedWithAllTheValueValues()
        {
            string randomName = "TeamcityPCR" + new Random().Next();
            LoginPageObjects.EnterLoginDetails(GlobalVariables.userName, GlobalVariables.password);
            LoginPageObjects.ClickStartDemoButton();
            HomePageObjects.VerifyHomePageDisplayed(GlobalVariables.userName);
            HomePageObjects.ClickCreatePCRButton();
            CreateNewPCRPageObjects.EnterIncidentDetails(pcr);
            CreateNewPCRPageObjects.EnterSceneAddressDetails();
            CreateNewPCRPageObjects.EnterCrewDetails();
            CreateNewPCRPageObjects.EnterLocationDetails();
            CreateNewPCRPageObjects.EnterDispatchDetails();
            CreateNewPCRPageObjects.EnterMileageDetails();
            CreateNewPCRPageObjects.EnterTimesDetails();
            CreateNewPCRPageObjects.EnterDelaysDetails();
            CreateNewPCRPageObjects.EnterOthersOnSceneDetails();
            CreateNewPCRPageObjects.SelectValueInDispositionDropdown("Cancelled");

            HomePageObjects.ClickSideIconLink("Patient");
            PatientHomePageObjects.EnterPatientImmunizationsDetails();
            PatientHomePageObjects.EnterPersonalDetails();
            PatientHomePageObjects.EnterPatientMedicationsDetails();
            PatientHomePageObjects.EnterMedicalInfoDetails();
            PatientHomePageObjects.EnterPatientInfoDetails();
            PatientHomePageObjects.EnterPatientAddressDetails();

            HomePageObjects.ClickSideIconLink("Assessment");

            AssessmentPageObjects.EnterImpressionDetails();
            AssessmentPageObjects.EnterProtocolDetails();
            AssessmentPageObjects.EnterTraumaDetails();
            AssessmentPageObjects.EnterVehicleCollisionDetails();
            AssessmentPageObjects.EnterPriorAidGivenDetails();
            AssessmentPageObjects.EnterCardiacArrestDetails();
            AssessmentPageObjects.EnterPatientComplaintDetails();


        }
    }
    
}
