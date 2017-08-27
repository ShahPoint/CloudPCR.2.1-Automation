using CloudPCR2._1_Automation.PageObjects;
using CloudPCR2._1_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            HomePageObjects.ClickSideIconLink("Billing");
            BillingPageObjects.EnterEmployerDetails();
            BillingPageObjects.EnterGuardianDetails();
            BillingPageObjects.EnterInsuranceDetails();
            BillingPageObjects.EnterBillingDetails();

            HomePageObjects.ClickSideIconLink("Timeline");
            TimelinePageObjects.EnterVitalDetails();
            TimelinePageObjects.EnterMedicationDetails();
            TimelinePageObjects.EnterProcedureDetails();
            TimelinePageObjects.EnterExamDetails();
            TimelinePageObjects.EnterHeadNeckDetails();
            TimelinePageObjects.EnterChestAbsDetails();
            TimelinePageObjects.EnterExtremitiesDetails();
            TimelinePageObjects.EnterBackDetails();
            TimelinePageObjects.EnterNotesDetails();

            HomePageObjects.ClickSideIconLink("Outcome");
            OutcomePageObjects.EnterDestinationDetails();
            OutcomePageObjects.EnterTransportInformationDetails();
            OutcomePageObjects.EnterOtherReportInfoDetails();

            HomePageObjects.ClickSideIconLink("Narrative");
            NarrativePageObjects.EnterOtherFieldsDetails();

            HomePageObjects.ClickSideIconLink("Attachments/Forms");
            AttachmentsFormsPageObjects.EnterAttachmentDetails();
            Thread.Sleep(10000);

            HomePageObjects.ClickSideIconLink("Signatures");
            SignaturesPageObjects.EnterSignatureDetails();
            Thread.Sleep(10000);

            HomePageObjects.ClickSideIconLink("Notes");
            NotesPageObjects.EnterNotesDetails();

            CreateNewPCRPageObjects.ClickSaveButtonFromOptionsDropdown();
            CreateNewPCRPageObjects.VerifyPCRSyncMessageDisplay();
        }
    }

}
