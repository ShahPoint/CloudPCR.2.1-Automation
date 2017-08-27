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
        #region Narrative
        static By narrativeTextarea = By.Name("pcr.e13_01");
        #endregion

        #region Other Fields
        static By reviewRequestedDropdown = By.CssSelector(ReturnSelectObject("e23_01"));
        static By emsFluidExposureorInjuryDropdown = By.CssSelector(ReturnSelectObject("e23_05"));
        static By fluidExposureorInjuryTypeDropdown = By.CssSelector(ReturnSelectObject("e23_06"));
        static By personnelExposedDropdown = By.CssSelector(ReturnSelectObject("e23_07"));
        static By reqReportableCondDropdown = By.CssSelector(ReturnSelectObject("e23_08"));
        static By registryCandidateDropdown = By.CssSelector(ReturnSelectObject("e23_02"));
        static By protectiveEquipmentDropdown = By.CssSelector(ReturnSelectObject("e23_03"));
        static By disastersDropdown = By.CssSelector(ReturnSelectObject("e23_04"));
        #endregion

        public static void EnterOtherFieldsDetails()
        {
          
            reviewRequestedDropdown.SelectValueInDropdown("Not Applicable");
          //  emsFluidExposureorInjuryDropdown.SelectValueInDropdown("No");
            fluidExposureorInjuryTypeDropdown.SelectValueInDropdown("Not Applicable");
            personnelExposedDropdown.SelectValueInDropdown("Not Applicable");
            reqReportableCondDropdown.SelectValueInDropdown("Not Applicable");
            registryCandidateDropdown.SelectValueInDropdown("Not Applicable");
            protectiveEquipmentDropdown.SelectValueInDropdown("Not Available");
            disastersDropdown.SelectValueInDropdown("Not Known");
            narrativeTextarea.EnterText("test");
            //custom objects 

        }


    }
}
