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
            CreateNewPCRPageObjects createNewPCR = new CreateNewPCRPageObjects(pcr);
            createNewPCR.SelectValueInDispositionDropdown("Cancelled");
            createNewPCR.EnterIncidentNum(randomName);
            createNewPCR.ClickSaveButtonFromOptionsDropdown();
            createNewPCR.VerifyPCRSyncMessageDisplay();
            createNewPCR.ClickBackButton();
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
            CreateNewPCRPageObjects createNewPCR = new CreateNewPCRPageObjects(pcr);
            createNewPCR.EnterIncidentDetails();
            createNewPCR.EnterSceneAddressDetails();
            createNewPCR.EnterCrewDetails();
            createNewPCR.EnterLocationDetails();
            createNewPCR.EnterDispatchDetails();
            createNewPCR.EnterMileageDetails();
            createNewPCR.EnterTimesDetails();
            createNewPCR.EnterDelaysDetails();
            createNewPCR.EnterOthersOnSceneDetails();
            createNewPCR.SelectValueInDispositionDropdown(pcr.DispositionOutcome);

            HomePageObjects.ClickSideIconLink("Patient");
            PatientHomePageObjects patientsPage = new PatientHomePageObjects(pcr);
            patientsPage.EnterPatientImmunizationsDetails();
            patientsPage.EnterPersonalDetails();
            patientsPage.EnterPatientMedicationsDetails();
            patientsPage.EnterMedicalInfoDetails();
            patientsPage.EnterPatientInfoDetails();
            patientsPage.EnterPatientAddressDetails();

            HomePageObjects.ClickSideIconLink("Assessment");
            AssessmentPageObjects assessmentPageObjects = new AssessmentPageObjects(pcr);
            assessmentPageObjects.EnterImpressionDetails();
            assessmentPageObjects.EnterProtocolDetails();
            assessmentPageObjects.EnterTraumaDetails();
            assessmentPageObjects.EnterVehicleCollisionDetails();
            assessmentPageObjects.EnterPriorAidGivenDetails();
            assessmentPageObjects.EnterCardiacArrestDetails();
            assessmentPageObjects.EnterPatientComplaintDetails();

            HomePageObjects.ClickSideIconLink("Billing");
            BillingPageObjects billingPageObjects = new BillingPageObjects(pcr);
            billingPageObjects.EnterEmployerDetails();
            billingPageObjects.EnterGuardianDetails();
            billingPageObjects.EnterInsuranceDetails();
            billingPageObjects.EnterBillingDetails();

            HomePageObjects.ClickSideIconLink("Timeline");
            TimelinePageObjects timelinePageObjects = new TimelinePageObjects(pcr);
            timelinePageObjects.EnterVitalDetails();
            timelinePageObjects.EnterMedicationDetails();
            timelinePageObjects.EnterProcedureDetails();
            timelinePageObjects.EnterExamDetails();
            timelinePageObjects.EnterHeadNeckDetails();
            timelinePageObjects.EnterChestAbsDetails();
            timelinePageObjects.EnterExtremitiesDetails();
            timelinePageObjects.EnterBackDetails();
            timelinePageObjects.EnterNotesDetails();
            Thread.Sleep(5000);
            HomePageObjects.ClickSideIconLink("Outcome");
            OutcomePageObjects outcomePageObjects = new OutcomePageObjects(pcr);
            outcomePageObjects.EnterDestinationDetails();
            outcomePageObjects.EnterTransportInformationDetails();
            outcomePageObjects.EnterOtherReportInfoDetails();

            HomePageObjects.ClickSideIconLink("Narrative");
            NarrativePageObjects narrativePageObjects = new NarrativePageObjects(pcr);
            narrativePageObjects.EnterOtherFieldsDetails();

            HomePageObjects.ClickSideIconLink("Attachments/Forms");
            AttachmentsFormsPageObjects attachmentsFormsPageObjects = new AttachmentsFormsPageObjects(pcr);
            attachmentsFormsPageObjects.EnterAttachmentDetails();
            Thread.Sleep(10000);

            HomePageObjects.ClickSideIconLink("Signatures");
            SignaturesPageObjects.EnterSignatureDetails();
            Thread.Sleep(10000);

            HomePageObjects.ClickSideIconLink("Notes");
            NotesPageObjects.EnterNotesDetails();

            createNewPCR.ClickSaveButtonFromOptionsDropdown();
            createNewPCR.VerifyPCRSyncMessageDisplay();
        }
    }

}
