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
        #region Vital Objects
        //VITAL
        static By vitalButtonLink = By.CssSelector("a[href='#vitals']");
        static By dateTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_01_Date"));
        static By timeTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_01_Time"));
        static By sBPTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_04"));
        static By dBPTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_05"));
        static By bPDeviceDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_06"));
        static By aVPUDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_22"));
        static By respirationTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_11"));
        static By pulseOxTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_09"));
        static By pulseRhythmDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_10"));
        static By respirationEffortDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_12"));
        static By pulseRateTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_07"));
        static By gCSEyesTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_15"));
        static By gCSVerbalTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_16"));
        static By gCSMotorTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_17"));
        static By gCSQaulDropdown = By.CssSelector(ReturnSelectObject("forms.vitals.e14_18"));
        static By gCSTotalTextbox = By.CssSelector(ReturnInputObject("forms.vitals.e14_19"));

        #endregion

        #region Medication Objects
        //MEDICATION
        static By medicationsButtonLink = By.CssSelector("a[href='#medications']");
        static By medicationsTimeTextbox = By.CssSelector(ReturnInputObject("forms.medications.e18_01_Time"));
        static By medicationsDateTextbox = By.CssSelector(ReturnInputObject("forms.medications.e18_01_Date"));
        static By crewDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_09"));
        static By medicationDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_03"));
        static By dosageTextbox = By.CssSelector(ReturnInputObject("forms.medications.e18_05"));
        static By unitsDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_06"));
        static By routeDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_04"));
        static By responseDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_07"));
        static By complicationDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_08"));
        static By authorizationDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_10"));
        static By authPhysicianTextbox = By.CssSelector(ReturnInputObject("forms.medications.e18_11"));
        static By isPriorAidDropdown = By.CssSelector(ReturnSelectObject("forms.medications.e18_02"));
        static By notesTextbox = By.CssSelector(ReturnInputObject("forms.medications.notes"));
        #endregion

        #region Procedure Objects
        //PROCEDURE
        static By procedureButtonLink = By.CssSelector("a[href='#procedures']");
        static By procedureTimeTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_01_Time"));
        static By procedureDateTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_01_Date"));
        static By procedurecrewDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_09"));
        static By procedureDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_03"));
        static By equipSizeTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_04"));
        static By successDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_06"));
        static By attemptsTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_05"));
        static By procedureresponseDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_08"));
        static By procedurecomplicationDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_07"));
        static By procedureauthorizationDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_10"));
        static By authPhysTextbox = By.CssSelector(ReturnInputObject("forms.procedures.e19_11"));
        static By procedureisPriorAidDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_02"));
        static By iVSuccessDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_12"));
        static By tubeConfirmationDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_13"));
        static By tubeDestinationDropdown = By.CssSelector(ReturnSelectObject("forms.procedures.e19_14"));
        static By procedureNotesTextbox = By.CssSelector(ReturnInputObject("forms.procedures.notes"));
        #endregion

        #region Exam Objects
        //EXAM
        static By examButtonLink = By.CssSelector("a[href='#exams']");
        static By examsTabs = By.CssSelector("a[data-toggle='tab']");
        //head/neck
        static By headDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e15_02"));
        static By mentalDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_23"));
        static By neuroDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_24"));
        static By faceDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_05"));
        static By leftEyeDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_21"));
        static By rightEyeDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_22"));
        static By neckDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_06"));
        static By skinDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_04"));

        //chest/abs
        static By chestDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_07"));
        static By heartDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_08"));
        static By absLeftUpperDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_09"));
        static By absLeftLowerDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_10"));
        static By absRightUpperDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_11"));
        static By absRightLowerDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_12"));
        static By GUDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_13"));
   
        //Extremities
        static By rightUpperDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_17"));
        static By rightLowerDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_18"));
        static By leftLowerDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_20"));
        static By leftUpperDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_19"));

        //Back
        static By backCervicalDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_14"));
        static By backThoracicDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_15"));
        static By backLumbarDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e16_16"));
        static By unspecifiedDropdown = By.CssSelector(ReturnSelectObject("forms.exams.e15_11"));
    
        //Notes
        static By notesTimeTextbox = By.CssSelector(ReturnInputObject("forms.exams.e16_03_Time"));
        static By notesDateTextbox = By.CssSelector(ReturnInputObject("forms.exams.e16_03_Date"));
        static By notesTextarea= By.Name("pcr.forms.exams.notes");
        #endregion

        static By closeButton = By.CssSelector("button.btn.btn-default");

        public static void EnterMedicationDetails()
        {
            medicationsButtonLink.Click();
            Thread.Sleep(2000);
            //medicationsDateTextbox.EnterText("08/26/2017");
           // medicationsTimeTextbox.EnterText("15:12");
          //  crewDropdown.SelectValueInDropdown("Not Applicable");
            medicationDropdown.SelectValueInDropdown("Alteplase");
            dosageTextbox.EnterText("test");
            unitsDropdown.SelectValueInDropdown("GMS");
            routeDropdown.SelectValueInDropdown("Not Applicable");
            responseDropdown.SelectValueInDropdown("Improved");
            complicationDropdown.SelectValueInDropdown("Not Applicable");
            authorizationDropdown.SelectValueInDropdown("Not Applicable");
            authPhysicianTextbox.EnterText("test");
            isPriorAidDropdown.SelectValueInDropdown("Yes");
            notesTextbox.EnterText("test");
            closeButton.ClickOnSpecificNumber(0);
            Thread.Sleep(2000);
        }

        public static void EnterVitalDetails()
        {
            vitalButtonLink.Click();
            Thread.Sleep(2000);
           // dateTextbox.EnterText("08/26/2017");
          //  timeTextbox.EnterText("15:12");
            sBPTextbox.EnterText("test");
            dBPTextbox.EnterText("test");
            bPDeviceDropdown.SelectValueInDropdown("Arterial Line");
            aVPUDropdown.SelectValueInDropdown("Not Known");
            respirationTextbox.EnterText("test");
            pulseOxTextbox.EnterText("test");
            pulseRhythmDropdown.SelectValueInDropdown("Not Applicable");
            respirationEffortDropdown.SelectValueInDropdown("Not Applicable");
            pulseRateTextbox.EnterText("test");
            gCSEyesTextbox.EnterText("test");
            gCSVerbalTextbox.EnterText("test");
            gCSMotorTextbox.EnterText("test");
            gCSQaulDropdown.SelectValueInDropdown("Not Applicable");
            gCSTotalTextbox.EnterText("test");
            closeButton.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
        }

        public static void EnterProcedureDetails()
        {
            procedureButtonLink.Click();
            Thread.Sleep(2000);
            //procedureDateTextbox.EnterText("08/26/2017");
           // procedureTimeTextbox.EnterText("15:12");
            //procedurecrewDropdown.SelectValueInDropdown("Not Applicable");
            procedureDropdown.SelectValueInDropdown("Chest Decompression");
            equipSizeTextbox.EnterText("test");
            successDropdown.SelectValueInDropdown("Yes");
            attemptsTextbox.EnterText("test");
            procedureresponseDropdown.SelectValueInDropdown("Not Applicable");
            procedurecomplicationDropdown.SelectValueInDropdown("Not Applicable");
            procedureauthorizationDropdown.SelectValueInDropdown("Not Applicable");
            authPhysTextbox.EnterText("test");
            procedureisPriorAidDropdown.SelectValueInDropdown("Not Applicable");
            iVSuccessDropdown.SelectValueInDropdown("Not Applicable");
            tubeConfirmationDropdown.SelectValueInDropdown("Not Applicable");
            tubeDestinationDropdown.SelectValueInDropdown("Not Applicable");
            procedureNotesTextbox.EnterText("test");
            closeButton.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
        }

        public static void EnterExamDetails()
        {
            examButtonLink.Click();
            Thread.Sleep(2000);
        }

        public static void EnterHeadNeckDetails()
        {
            headDropdown.SelectValueInDropdown("Not Available");
            mentalDropdown.SelectValueInDropdown("Not Known");
            neuroDropdown.SelectValueInDropdown("Not Applicable");
            faceDropdown.SelectValueInDropdown("Normal");
            leftEyeDropdown.SelectValueInDropdown("Not Known");
            rightEyeDropdown.SelectValueInDropdown("Not Applicable");
            neckDropdown.SelectValueInDropdown("Not Done");
            skinDropdown.SelectValueInDropdown("Normal");
            Thread.Sleep(2000);
        }

        public static void EnterChestAbsDetails()
        {
            examsTabs.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
            chestDropdown.SelectValueInDropdown("Not Done");
            heartDropdown.SelectValueInDropdown("Normal");
            absLeftUpperDropdown.SelectValueInDropdown("Not Applicable");
            absLeftLowerDropdown.SelectValueInDropdown("Normal");
            absRightUpperDropdown.SelectValueInDropdown("Not Done");
            absRightLowerDropdown.SelectValueInDropdown("Not Applicable");
            GUDropdown.SelectValueInDropdown("Not Done");
            Thread.Sleep(2000);
        }

        public static void EnterExtremitiesDetails()
        {
            examsTabs.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
            rightUpperDropdown.SelectValueInDropdown("Normal");
            rightLowerDropdown.SelectValueInDropdown("Not Applicable");
            leftLowerDropdown.SelectValueInDropdown("Not Done");
            leftUpperDropdown.SelectValueInDropdown("Normal");
            Thread.Sleep(2000);
        }

        public static void EnterBackDetails()
        {
            examsTabs.ClickOnSpecificNumber(3);
            Thread.Sleep(2000);
            backCervicalDropdown.SelectValueInDropdown("Normal");
            backThoracicDropdown.SelectValueInDropdown("Normal");
            backLumbarDropdown.SelectValueInDropdown("Not Done");
            unspecifiedDropdown.SelectValueInDropdown("Not Applicable");
            Thread.Sleep(2000);
        }

        public static void EnterNotesDetails()
        {
            examsTabs.ClickOnSpecificNumber(4);
            Thread.Sleep(2000);
            //notesTimeTextbox.EnterText("15:12");
            //notesDateTextbox.EnterText("08/26/2017");
            notesTextarea.EnterText("test test ");
            Thread.Sleep(2000);
            closeButton.ClickOnSpecificNumber(7);
        }


    }
}
