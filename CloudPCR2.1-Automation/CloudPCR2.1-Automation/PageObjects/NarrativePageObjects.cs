using CloudPCR2._1_Automation.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.PageObjects
{
    public class NarrativePageObjects:SelectingBrowsers
    {
        PCRVariables pcrVar = new PCRVariables();

        public NarrativePageObjects(PCRVariables pcr)
        {
            pcrVar = pcr;
        }

        #region Narrative
        By narrativeTextarea = By.Name("pcr.e13_01");
        #endregion

        #region Other Fields
        By reviewRequestedDropdown = By.CssSelector(ReturnSelectObject("e23_01"));
        By emsFluidExposureorInjuryDropdown = By.CssSelector(ReturnSelectObject("e23_05"));
        By fluidExposureorInjuryTypeDropdown = By.CssSelector(ReturnSelectObject("e23_06"));
        By personnelExposedDropdown = By.CssSelector(ReturnSelectObject("e23_07"));
        By reqReportableCondDropdown = By.CssSelector(ReturnSelectObject("e23_08"));
        By registryCandidateDropdown = By.CssSelector(ReturnSelectObject("e23_02"));
        By protectiveEquipmentDropdown = By.CssSelector(ReturnSelectObject("e23_03"));
        By disastersDropdown = By.CssSelector(ReturnSelectObject("e23_04"));
        #endregion

        public void EnterOtherFieldsDetails()
        {
          
            reviewRequestedDropdown.SelectValueInDropdown(pcrVar.NarrativeOtherReportreviewRequested);
          //  emsFluidExposureorInjuryDropdown.SelectValueInDropdown("No");
            fluidExposureorInjuryTypeDropdown.SelectValueInDropdown(pcrVar.NarrativeOtherReportfluidExposureorInjuryType);
            personnelExposedDropdown.SelectValueInDropdown(pcrVar.NarrativeOtherReportpersonnelExposed);
            reqReportableCondDropdown.SelectValueInDropdown(pcrVar.NarrativeOtherReportreqReportableCond);
            registryCandidateDropdown.SelectValueInDropdown(pcrVar.NarrativeOtherReportregistryCandidate);
            protectiveEquipmentDropdown.SelectValueInDropdown(pcrVar.NarrativeOtherReportprotectiveEquipment);
            disastersDropdown.SelectValueInDropdown(pcrVar.NarrativeOtherReportdisasters);
            narrativeTextarea.EnterText(pcrVar.NarrativeOtherReportnarrative);
            //custom objects 

        }


    }
}
