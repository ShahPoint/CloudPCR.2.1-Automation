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
    public class AssessmentPageObjects : SelectingBrowsers
    {
        //patient complaints
        static By chiefComplaintTextbox = By.CssSelector(ReturnInputObject("e09_05"));
        static By possibleInjuryDropdown = By.CssSelector(ReturnSelectObject("e09_04"));
     
        //Impression
        static By complaintLocationDropdown = By.CssSelector(ReturnSelectObject("e09_11"));
        static By organSystemDropdown = By.CssSelector(ReturnSelectObject("e09_12"));
        static By primarySymptomsDropdown = By.CssSelector(ReturnSelectObject("e09_13"));
        static By impressionDropdown = By.CssSelector(ReturnSelectObject("e09_15"));
        static By otherSymptomsDropdown = By.CssSelector(ReturnSelectObject("e09_14"));
        static By secondaryImpressionDropdown = By.CssSelector(ReturnSelectObject("e09_16"));
        static By drugsAlcoholDropdown = By.CssSelector(ReturnSelectObject("e12_19"));

        static By protocolsDropdown = By.CssSelector(ReturnSelectObject("e17_01"));
         
        //vehicle collision
        static By vehicleCollisionDropdown = By.CssSelector(ReturnSelectObject("e10_05"));
        static By reportNumberTextbox = By.CssSelector(ReturnInputObject("e22_03"));
        static By ptLocationDropdown = By.CssSelector(ReturnSelectObject("e10_07"));
        static By rowDropdown = By.CssSelector(ReturnSelectObject("e10_06"));
        static By safetyEquipmentDropdown = By.CssSelector(ReturnSelectObject("e10_08"));
        static By airbagsDropdown = By.CssSelector(ReturnSelectObject("e10_09"));
        static By injuryIndicatorsDropdown = By.CssSelector(ReturnSelectObject("e10_04"));

        static By checkboxValue = By.CssSelector("div.tools input");

        //trauma
        static By heightOfFallTextbox = By.CssSelector(ReturnInputObject("e10_10"));
        static By causeOfInjuryDropdown = By.CssSelector(ReturnSelectObject("e10_01"));
        static By intentOfInjuryDropdown = By.CssSelector(ReturnSelectObject("e10_02"));      

        //prior aid given
        static By priorAidDropdown = By.CssSelector(ReturnSelectObject("e09_01"));
        static By treatedByDropdown = By.CssSelector(ReturnSelectObject("e09_02"));
        static By aidOutcomeDropdown = By.CssSelector(ReturnSelectObject("e09_03"));

        //cardiac arrest
        static By cardiacArrestDropdown = By.CssSelector(ReturnSelectObject("e11_01"));
        static By cardiacArrestTimeDropdown = By.CssSelector(ReturnSelectObject("e11_08"));
        static By etiologyDropdown = By.CssSelector(ReturnSelectObject("e11_02"));
        static By witnessedByDropdown = By.CssSelector(ReturnSelectObject("e11_04"));
        static By firstRythmDropdown = By.CssSelector(ReturnSelectObject("e11_05"));
        static By circulationReturnDropdown = By.CssSelector(ReturnSelectObject("e11_06"));
        static By resusitationsDropdown = By.CssSelector(ReturnSelectObject("e11_03"));
        static By discontinueReasonDropdown = By.CssSelector(ReturnSelectObject("e11_10"));
        static By discontinueTimeTextbox = By.CssSelector(ReturnInputObject("e11_09_Time"));
        static By discontinueDateTextbox = By.CssSelector(ReturnInputObject("e11_09_Date"));


        public static void EnterPatientComplaintDetails()
        {
            chiefComplaintTextbox.EnterText("12345");
            possibleInjuryDropdown.SelectValueInDropdown("Yes");
        }

        public static void EnterImpressionDetails()
        {
            complaintLocationDropdown.SelectValueInDropdown("Back");
            organSystemDropdown.SelectValueInDropdown("Skin");
            primarySymptomsDropdown.SelectValueInDropdown("Fever");
            impressionDropdown.SelectValueInDropdown("Not Known");
            otherSymptomsDropdown.SelectValueInDropdown("Bleeding");
            secondaryImpressionDropdown.SelectValueInDropdown("Not Known");
            drugsAlcoholDropdown.SelectValueInDropdown("Not Known");
        }

        public static void EnterProtocolDetails()
        {
            protocolsDropdown.SelectValueInDropdown("Airway");
        }

        public static void EnterVehicleCollisionDetails()
        {
            checkboxValue.ClickOnSpecificNumber(0);
            Thread.Sleep(1000);
            vehicleCollisionDropdown.SelectValueInDropdown("Not Known");
            reportNumberTextbox.EnterText("Not Known");
            ptLocationDropdown.SelectValueInDropdown("Not Known");
            rowDropdown.SelectValueInDropdown("2");
            safetyEquipmentDropdown.SelectValueInDropdown("Not Applicable");
            airbagsDropdown.SelectValueInDropdown("Not Known");
            injuryIndicatorsDropdown.SelectValueInDropdown("Not Available");
        }

        public static void EnterTraumaDetails()
        {
            checkboxValue.ClickOnSpecificNumber(1);
            Thread.Sleep(1000);
            heightOfFallTextbox.EnterText("4");
            causeOfInjuryDropdown.SelectValueInDropdown("Not Known");
            intentOfInjuryDropdown.SelectValueInDropdown("Not Known");
        }

        public static void EnterPriorAidGivenDetails()
        {
            checkboxValue.ClickOnSpecificNumber(2);
            Thread.Sleep(1000);
            priorAidDropdown.SelectValueInDropdown("Not Known");
            treatedByDropdown.SelectValueInDropdown("Not Known");
            aidOutcomeDropdown.SelectValueInDropdown("Not Known");
        }

        public static void EnterCardiacArrestDetails()
        {
            checkboxValue.ClickOnSpecificNumber(3);
            Thread.Sleep(1000);
            cardiacArrestDropdown.SelectValueInDropdown("Not Known");
            cardiacArrestTimeDropdown.SelectValueInDropdown("Not Known");
            etiologyDropdown.SelectValueInDropdown("Other");
            witnessedByDropdown.SelectValueInDropdown("Not Available");
            firstRythmDropdown.SelectValueInDropdown("Other");
            circulationReturnDropdown.SelectValueInDropdown("Not Known");
            resusitationsDropdown.SelectValueInDropdown("Not Applicable");
            discontinueReasonDropdown.SelectValueInDropdown("Not Available");
            discontinueTimeTextbox.EnterText("1234");
            discontinueDateTextbox.EnterText("12121988");
        }

    }
}
