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
    public class TimelinePageObjects: SelectingBrowsers
    {

        PCRVariables pcrVar = new PCRVariables();

        public TimelinePageObjects(PCRVariables pcr)
        {
            pcrVar = pcr;
        }
        #region Vital Objects
        //VITAL
        By vitalButtonLink = By.CssSelector("a[href='#vitals']");
        By dateTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_01_Date"));
        By timeTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_01_Time"));
        By sBPTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_04"));
        By dBPTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_05"));
        By bPDeviceDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_06"));
        By aVPUDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_22"));
        By respirationTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_11"));
        By pulseOxTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_09"));
        By pulseRhythmDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_10"));
        By respirationEffortDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_12"));
        By pulseRateTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_07"));
        By gCSEyesTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_15"));
        By gCSVerbalTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_16"));
        By gCSMotorTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_17"));
        By gCSQaulDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_18"));
        By gCSTotalTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_19"));

        #endregion

        #region Medication Objects
        //MEDICATION
        By medicationsButtonLink = By.CssSelector("a[href='#medications']");
        By medicationsTimeTextbox = By.CssSelector(ReturnInputObject("forms.medications.e18_01_Time"));
        By medicationsDateTextbox = By.CssSelector(ReturnInputObject("forms.medications.e18_01_Date"));
        By crewDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_09"));
        By medicationDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_03"));
        By dosageTextbox = By.CssSelector(ReturnInputObject("forms.medications.e18_05"));
        By unitsDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_06"));
        By routeDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_04"));
        By responseDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_07"));
        By complicationDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_08"));
        By authorizationDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_10"));
        By authPhysicianTextbox = By.CssSelector(ReturnInputObject("forms.medications.e18_11"));
        By isPriorAidDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_02"));
        By notesTextbox = By.CssSelector(ReturnInputObject("forms.medications.notes"));
        #endregion

        #region Procedure Objects
        //PROCEDURE
        By procedureButtonLink = By.CssSelector("a[href='#procedures']");
        By procedureTimeTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_01_Time"));
        By procedureDateTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_01_Date"));
        By procedurecrewDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_09"));
        By procedureDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_03"));
        By equipSizeTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_04"));
        By successDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_06"));
        By attemptsTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_05"));
        By procedureresponseDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_08"));
        By procedurecomplicationDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_07"));
        By procedureauthorizationDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_10"));
        By authPhysTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_11"));
        By procedureisPriorAidDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_02"));
        By iVSuccessDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_12"));
        By tubeConfirmationDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_13"));
        By tubeDestinationDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_14"));
        By procedureNotesTextbox = By.CssSelector(ReturnInputObject("forms.procedures.notes"));
        #endregion

        #region Exam Objects
        //EXAM
        By examButtonLink = By.CssSelector("a[href='#exams']");
        By examsTabs = By.CssSelector("a[data-toggle='tab']");
        //head/neck
        By headDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e15_02"));
        By mentalDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_23"));
        By neuroDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_24"));
        By faceDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_05"));
        By leftEyeDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_21"));
        By rightEyeDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_22"));
        By neckDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_06"));
        By skinDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_04"));

        //chest/abs
        By chestDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_07"));
        By heartDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_08"));
        By absLeftUpperDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_09"));
        By absLeftLowerDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_10"));
        By absRightUpperDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_11"));
        By absRightLowerDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_12"));
        By GUDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_13"));
   
        //Extremities
        By rightUpperDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_17"));
        By rightLowerDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_18"));
        By leftLowerDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_20"));
        By leftUpperDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_19"));

        //Back
        By backCervicalDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_14"));
        By backThoracicDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_15"));
        By backLumbarDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_16"));
        By unspecifiedDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e15_11"));
    
        //Notes
        By notesTimeTextbox = By.CssSelector(ReturnInputObject("forms.exams.e16_03_Time"));
        By notesDateTextbox = By.CssSelector(ReturnInputObject("forms.exams.e16_03_Date"));
        By notesTextarea= By.Name("pcr.forms.exams.notes");
        #endregion

        By closeButton = By.CssSelector("button.btn.btn-default");

        public  void EnterMedicationDetails()
        {
            medicationsButtonLink.Click();
            Thread.Sleep(2000);
           //medicationsDateTextbox.EnterText("08/26/2017");
          //medicationsTimeTextbox.EnterText("15:12");
          //crewDropdown.SelectValueInDropdown("Not Applicable");
            medicationDropdown.SelectValueInDropdown(pcrVar.TimelineMedicationDrop);
            dosageTextbox.EnterText(pcrVar.TimelineMedicationdosage);
            unitsDropdown.SelectValueInDropdown(pcrVar.TimelineMedicationunits);
            routeDropdown.SelectValueInDropdown(pcrVar.TimelineMedicationroute);
            responseDropdown.SelectValueInDropdown(pcrVar.TimelineMedicationresponse);
            complicationDropdown.SelectValueInDropdown(pcrVar.TimelineMedicationcomplication);
            authorizationDropdown.SelectValueInDropdown(pcrVar.TimelineMedicationauthorization);
            authPhysicianTextbox.EnterText(pcrVar.TimelineMedicationauthPhysician);
            isPriorAidDropdown.SelectValueInDropdown(pcrVar.TimelineMedicationisPriorAid);
            notesTextbox.EnterText(pcrVar.TimelineMedicationnotes);
            closeButton.ClickOnSpecificNumber(0);
            Thread.Sleep(2000);
        }

        public  void EnterVitalDetails()
        {
            vitalButtonLink.Click();
            Thread.Sleep(2000);
          //dateTextbox.EnterText("08/26/2017");
          //timeTextbox.EnterText("15:12");
            sBPTextbox.EnterText(pcrVar.TimelineVitalsBP);
            dBPTextbox.EnterText(pcrVar.TimelineVitaldBP);
            bPDeviceDropdown.SelectValueInDropdown(pcrVar.TimelineVitalbPDevice);
            aVPUDropdown.SelectValueInDropdown(pcrVar.TimelineVitalaVPU);
            respirationTextbox.EnterText(pcrVar.TimelineVitalrespiration);
            pulseOxTextbox.EnterText(pcrVar.TimelineVitalpulseOx);
            pulseRhythmDropdown.SelectValueInDropdown(pcrVar.TimelineVitalpulseRhythm);
            respirationEffortDropdown.SelectValueInDropdown(pcrVar.TimelineVitalrespirationEffort);
            pulseRateTextbox.EnterText(pcrVar.TimelineVitalpulseRate);
            gCSEyesTextbox.EnterText(pcrVar.TimelineVitalgCSEyes);
            gCSVerbalTextbox.EnterText(pcrVar.TimelineVitalgCSVerbal);
            gCSMotorTextbox.EnterText(pcrVar.TimelineVitalgCSMotor);
            gCSQaulDropdown.SelectValueInDropdown(pcrVar.TimelineVitalgCSQaul);
            gCSTotalTextbox.EnterText(pcrVar.TimelineVitalgCSTotal);
            closeButton.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
        }

        public  void EnterProcedureDetails()
        {
            procedureButtonLink.Click();
            Thread.Sleep(2000);
            //procedureDateTextbox.EnterText("08/26/2017");
           // procedureTimeTextbox.EnterText("15:12");
            //procedurecrewDropdown.SelectValueInDropdown("Not Applicable");
            procedureDropdown.SelectValueInDropdown(pcrVar.TimelineProcedureDrop);
            equipSizeTextbox.EnterText(pcrVar.TimelineProcedureequipSize);
            successDropdown.SelectValueInDropdown(pcrVar.TimelineProceduresuccess);
            attemptsTextbox.EnterText(pcrVar.TimelineProcedureattempts);
            procedureresponseDropdown.SelectValueInDropdown(pcrVar.TimelineProcedureresponse);
            procedurecomplicationDropdown.SelectValueInDropdown(pcrVar.TimelineProcedurecomplication);
            procedureauthorizationDropdown.SelectValueInDropdown(pcrVar.TimelineProcedureauthorization);
            authPhysTextbox.EnterText(pcrVar.TimelineProcedureauthPhys);
            procedureisPriorAidDropdown.SelectValueInDropdown(pcrVar.TimelineProcedureprocedureisPriorAid);
            iVSuccessDropdown.SelectValueInDropdown(pcrVar.TimelineProcedureiVSuccess);
            tubeConfirmationDropdown.SelectValueInDropdown(pcrVar.TimelineProceduretubeConfirmation);
            tubeDestinationDropdown.SelectValueInDropdown(pcrVar.TimelineProceduretubeDestination);
            procedureNotesTextbox.EnterText(pcrVar.TimelineProcedureprocedureNotes);
            closeButton.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
        }

        public  void EnterExamDetails()
        {
            examButtonLink.Click();
            Thread.Sleep(2000);
        }

        public  void EnterHeadNeckDetails()
        {
            headDropdown.SelectValueInDropdown(pcrVar.TimelineHeadNeckhead);
            mentalDropdown.SelectValueInDropdown(pcrVar.TimelineHeadNeckmental);
            neuroDropdown.SelectValueInDropdown(pcrVar.TimelineHeadNeckneuro);
            faceDropdown.SelectValueInDropdown(pcrVar.TimelineHeadNeckface);
            leftEyeDropdown.SelectValueInDropdown(pcrVar.TimelineHeadNeckleftEye);
            rightEyeDropdown.SelectValueInDropdown(pcrVar.TimelineHeadNeckrightEye);
            neckDropdown.SelectValueInDropdown(pcrVar.TimelineHeadNeckDrop);
            skinDropdown.SelectValueInDropdown(pcrVar.TimelineHeadNeckskin);
            Thread.Sleep(2000);
        }

        public  void EnterChestAbsDetails()
        {
            examsTabs.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
            chestDropdown.SelectValueInDropdown(pcrVar.TimelineChestAbschest);
            heartDropdown.SelectValueInDropdown(pcrVar.TimelineChestAbsheart);
            absLeftUpperDropdown.SelectValueInDropdown(pcrVar.TimelineChestAbsLeftUpper);
            absLeftLowerDropdown.SelectValueInDropdown(pcrVar.TimelineChestAbsLeftLower);
            absRightUpperDropdown.SelectValueInDropdown(pcrVar.TimelineChestAbsRightUpper);
            absRightLowerDropdown.SelectValueInDropdown(pcrVar.TimelineChestAbsRightLower);
            GUDropdown.SelectValueInDropdown(pcrVar.TimelineChestAbsGU);
            Thread.Sleep(2000);
        }

        public  void EnterExtremitiesDetails()
        {
            examsTabs.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
            rightUpperDropdown.SelectValueInDropdown(pcrVar.TimelineExtremitiesrightUpper);
            rightLowerDropdown.SelectValueInDropdown(pcrVar.TimelineExtremitiesrightLower);
            leftLowerDropdown.SelectValueInDropdown(pcrVar.TimelineExtremitiesleftLower);
            leftUpperDropdown.SelectValueInDropdown(pcrVar.TimelineExtremitiesleftUpper);
            Thread.Sleep(2000);
        }

        public  void EnterBackDetails()
        {
            examsTabs.ClickOnSpecificNumber(3);
            Thread.Sleep(2000);
            backCervicalDropdown.SelectValueInDropdown(pcrVar.TimelineBackCervical);
            backThoracicDropdown.SelectValueInDropdown(pcrVar.TimelineBackThoracic);
            backLumbarDropdown.SelectValueInDropdown(pcrVar.TimelineBackLumbar);
            unspecifiedDropdown.SelectValueInDropdown(pcrVar.TimelineBackunspecified);
            Thread.Sleep(2000);
        }

        public  void EnterNotesDetails()
        {
            examsTabs.ClickOnSpecificNumber(4);
            Thread.Sleep(2000);
            //notesTimeTextbox.EnterText("15:12");
            //notesDateTextbox.EnterText("08/26/2017");
            notesTextarea.EnterText(pcrVar.TimelineNotesTextarea);
            Thread.Sleep(2000);
            closeButton.ClickOnSpecificNumber(7);
        }


    }
}
