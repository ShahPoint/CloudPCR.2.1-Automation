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
        PCRVariables pcrVar = new PCRVariables();

        public AssessmentPageObjects(PCRVariables pcr)
        {
            pcrVar = pcr;
        }

        #region  patient complaints
         By chiefComplaintTextbox = By.CssSelector(ReturnInputObject("e09_05"));
         By possibleInjuryDropdown = By.CssSelector(ReturnSelectObject("e09_04"));
        #endregion

        #region Impression
        By complaintLocationDropdown = By.CssSelector(ReturnSelectObject("e09_11"));
        By organSystemDropdown = By.CssSelector(ReturnSelectObject("e09_12"));
        By primarySymptomsDropdown = By.CssSelector(ReturnSelectObject("e09_13"));
        By impressionDropdown = By.CssSelector(ReturnSelectObject("e09_15"));
        By otherSymptomsDropdown = By.CssSelector(ReturnSelectObject("e09_14"));
        By secondaryImpressionDropdown = By.CssSelector(ReturnSelectObject("e09_16"));
        By drugsAlcoholDropdown = By.CssSelector(ReturnSelectObject("e12_19"));

        static By protocolsDropdown = By.CssSelector(ReturnSelectObject("e17_01"));

        #endregion

        #region vehicle collision
        By vehicleCollisionDropdown = By.CssSelector(ReturnSelectObject("e10_05"));
        By reportNumberTextbox = By.CssSelector(ReturnInputObject("e22_03"));
        By ptLocationDropdown = By.CssSelector(ReturnSelectObject("e10_07"));
        By rowDropdown = By.CssSelector(ReturnSelectObject("e10_06"));
        By safetyEquipmentDropdown = By.CssSelector(ReturnSelectObject("e10_08"));
        By airbagsDropdown = By.CssSelector(ReturnSelectObject("e10_09"));
        By injuryIndicatorsDropdown = By.CssSelector(ReturnSelectObject("e10_04"));

        By checkboxValue = By.CssSelector("div.tools input");
        #endregion

        #region  Trauma
        By heightOfFallTextbox = By.CssSelector(ReturnInputObject("e10_10"));
        By causeOfInjuryDropdown = By.CssSelector(ReturnSelectObject("e10_01"));
        By intentOfInjuryDropdown = By.CssSelector(ReturnSelectObject("e10_02"));
        #endregion

        #region prior aid given
        By priorAidDropdown = By.CssSelector(ReturnSelectObject("e09_01"));
        By treatedByDropdown = By.CssSelector(ReturnSelectObject("e09_02"));
        By aidOutcomeDropdown = By.CssSelector(ReturnSelectObject("e09_03"));
        #endregion

        #region cardiac arrest
        By cardiacArrestDropdown = By.CssSelector(ReturnSelectObject("e11_01"));
        By cardiacArrestTimeDropdown = By.CssSelector(ReturnSelectObject("e11_08"));
        By etiologyDropdown = By.CssSelector(ReturnSelectObject("e11_02"));
        By witnessedByDropdown = By.CssSelector(ReturnSelectObject("e11_04"));
        By firstRythmDropdown = By.CssSelector(ReturnSelectObject("e11_05"));
        By circulationReturnDropdown = By.CssSelector(ReturnSelectObject("e11_06"));
        By resusitationsDropdown = By.CssSelector(ReturnSelectObject("e11_03"));
        By discontinueReasonDropdown = By.CssSelector(ReturnSelectObject("e11_10"));
        By discontinueTimeTextbox = By.CssSelector(ReturnInputObject("e11_09_Time"));
        By discontinueDateTextbox = By.CssSelector(ReturnInputObject("e11_09_Date"));
        #endregion

        public  void EnterPatientComplaintDetails()
        {
          
            chiefComplaintTextbox.EnterText(pcrVar.AssessmentComplaintchiefComplaint);
            possibleInjuryDropdown.SelectValueInDropdown(pcrVar.AssessmentComplaintpossibleInjury);
        }

        public  void EnterImpressionDetails()
        {
            complaintLocationDropdown.SelectValueInDropdown(pcrVar.AssessmentImpressioncomplaintLocation);
            organSystemDropdown.SelectValueInDropdown(pcrVar.AssessmentImpressionorganSystem);
            primarySymptomsDropdown.SelectValueInDropdown(pcrVar.AssessmentImpressionprimarySymptoms);
            impressionDropdown.SelectValueInDropdown(pcrVar.AssessmentImpressionimpression);
            otherSymptomsDropdown.SelectValueInDropdown(pcrVar.AssessmentImpressionotherSymptoms);
            secondaryImpressionDropdown.SelectValueInDropdown(pcrVar.AssessmentImpressionsecondaryImpression);
            drugsAlcoholDropdown.SelectValueInDropdown(pcrVar.AssessmentImpressiondrugsAlcohol);
        }

        public  void EnterProtocolDetails()
        {
            protocolsDropdown.SelectValueInDropdown(pcrVar.AssessmentProtocolprotocols);
        }

        public  void EnterVehicleCollisionDetails()
        {
            checkboxValue.ClickOnSpecificNumber(0);
            Thread.Sleep(1000);
            vehicleCollisionDropdown.SelectValueInDropdown(pcrVar.AssessmentVehicleCollisionvehicleCollision);
            reportNumberTextbox.EnterText(pcrVar.AssessmentVehicleCollisionreportNumber);
            ptLocationDropdown.SelectValueInDropdown(pcrVar.AssessmentVehicleCollisionptLocation);
            rowDropdown.SelectValueInDropdown(pcrVar.AssessmentVehicleCollisionrow);
            safetyEquipmentDropdown.SelectValueInDropdown(pcrVar.AssessmentVehicleCollisionsafetyEquipment);
            airbagsDropdown.SelectValueInDropdown(pcrVar.AssessmentVehicleCollisionairbags);
            injuryIndicatorsDropdown.SelectValueInDropdown(pcrVar.AssessmentVehicleCollisioninjuryIndicators);
        }

        public  void EnterTraumaDetails()
        {
            checkboxValue.ClickOnSpecificNumber(1);
            Thread.Sleep(1000);
            heightOfFallTextbox.EnterText(pcrVar.AssessmentTraumaheightOfFall);
            causeOfInjuryDropdown.SelectValueInDropdown(pcrVar.AssessmentTraumacauseOfInjury);
            intentOfInjuryDropdown.SelectValueInDropdown(pcrVar.AssessmentTraumaintentOfInjury);
        }

        public  void EnterPriorAidGivenDetails()
        {
            checkboxValue.ClickOnSpecificNumber(2);
            Thread.Sleep(1000);
            priorAidDropdown.SelectValueInDropdown(pcrVar.AssessmentPriorAidGivenpriorAid);
            treatedByDropdown.SelectValueInDropdown(pcrVar.AssessmentPriorAidGiventreatedBy);
            aidOutcomeDropdown.SelectValueInDropdown(pcrVar.AssessmentPriorAidGivenaidOutcome);
        }

        public  void EnterCardiacArrestDetails()
        {
            checkboxValue.ClickOnSpecificNumber(3);
            Thread.Sleep(1000);
            cardiacArrestDropdown.SelectValueInDropdown(pcrVar.AssessmentCardiacArrestDD);
            cardiacArrestTimeDropdown.SelectValueInDropdown(pcrVar.AssessmentCardiacArrestTime);
            etiologyDropdown.SelectValueInDropdown(pcrVar.AssessmentCardiacArrestetiology);
            witnessedByDropdown.SelectValueInDropdown(pcrVar.AssessmentCardiacArrestwitnessed);
            firstRythmDropdown.SelectValueInDropdown(pcrVar.AssessmentCardiacArrestfirstRythm);
            circulationReturnDropdown.SelectValueInDropdown(pcrVar.AssessmentCardiacArrestcirculationReturn);
            resusitationsDropdown.SelectValueInDropdown(pcrVar.AssessmentCardiacArrestresusitations);
            discontinueReasonDropdown.SelectValueInDropdown(pcrVar.AssessmentCardiacArrestdiscontinueReason);
            discontinueTimeTextbox.EnterText(pcrVar.AssessmentCardiacArrestdiscontinueTime);
            discontinueDateTextbox.EnterText(pcrVar.AssessmentCardiacArrestdiscontinueDate);
        }

    }
}
