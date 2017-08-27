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
   public class PatientHomePageObjects : SelectingBrowsers
    {
        #region  patient info
        static By firstNameTextbox = By.CssSelector(ReturnInputObject("e06_02"));
        static By lastNameTextbox = By.CssSelector(ReturnInputObject("e06_01"));
        static By miTextbox = By.CssSelector(ReturnInputObject("e06_03"));
        static By phoneTextbox = By.CssSelector(ReturnInputObject("e06_17"));
        static By weightTextbox = By.CssSelector(ReturnInputObject("e16_01"));
        static By raceDropdown = By.CssSelector(ReturnSelectObject("e06_12"));
        static By dobTextbox   = By.CssSelector(ReturnInputObject("e06_16_Date"));
        static By etnicityDropdown = By.CssSelector(ReturnSelectObject("e06_13"));
        static By genderDropdown = By.CssSelector(ReturnSelectObject("e06_11"));
        static By ssnTextbox = By.CssSelector(ReturnInputObject("e06_10"));
        #endregion

        #region  patient address
        static By patientAddressTextarea = By.Id("patientAddressTextArea");
        static By googleLocSearchTextbox = By.CssSelector(ReturnInputObject("patientAddress.geocomplete"));
        static By streetAddressTextbox = By.CssSelector(ReturnInputObject("patientAddress.street"));
        static By streetAddress2Textbox = By.CssSelector(ReturnInputObject("patientAddress.street2"));
        static By cityTextbox = By.CssSelector(ReturnInputObject("patientAddress.city"));
        static By stateDropdown = By.CssSelector(ReturnSelectObject("patientAddress.state"));
        static By zipTextbox = By.CssSelector(ReturnInputObject("patientAddress.zip"));
        static By municipalityPickerDropdown = By.CssSelector(ReturnSelectObject("patientAddress.fipsPicker"));
        static By municipalCodeTextbox = By.CssSelector(ReturnInputObject("patientAddress.municipalityCode"));
        static By countryCodeTextbox = By.CssSelector(ReturnInputObject("patientAddress.countyCode"));
        static By additionalNotesTextbox = By.CssSelector(ReturnInputObject("patientAddress.notes"));
        #endregion

        #region personal
        static By dlNumberTextbox = By.CssSelector(ReturnInputObject("e06_19"));
        static By ptPractionerNameTextbox = By.CssSelector(ReturnInputObject("e12_06"));
        static By dlStateDropdown = By.CssSelector(ReturnSelectObject("e06_18"));
        #endregion

        #region  medical Info
        static By historyDropdown = By.CssSelector(ReturnSelectObject("e12_10"));
        static By historyObtainedDropdown = By.CssSelector(ReturnSelectObject("e12_11"));
        static By allergiesMedsDropdown = By.CssSelector(ReturnSelectObject("e12_08"));
        static By emergencyFormDropdown = By.CssSelector(ReturnSelectObject("e12_18"));
        static By allergiesOthersDropdown = By.CssSelector(ReturnSelectObject("e12_09"));
        static By advancedDirectivesDropdown = By.CssSelector(ReturnSelectObject("e12_07"));
        static By triageColorDropdown = By.CssSelector(ReturnSelectObject("customTriageColor"));
        static By triageCategoryDropdown = By.CssSelector(ReturnSelectObject("customTriageCategory"));
        static By pregnantDropdown = By.CssSelector(ReturnSelectObject("e12_20"));

        static By newButtons = By.CssSelector("a[data-toggle='modal']");
        static By saveButtons = By.CssSelector("button.btn.btn-default");
        #endregion

        #region  patient medication 
        static By routeDropdown = By.CssSelector(ReturnSelectObject("forms.patientMedications.e12_17"));
        static By dosageTextbox = By.CssSelector(ReturnInputObject("forms.patientMedications.e12_15"));
        static By unitsDropdown = By.CssSelector(ReturnSelectObject("forms.patientMedications.e12_16"));
        #endregion

        #region  immunization
        static By typeDropdown = By.CssSelector(ReturnSelectObject("forms.immunizations.e12_12"));
        static By yearTextbox = By.CssSelector(ReturnInputObject("forms.immunizations.e12_13"));
        #endregion

        public static void EnterPatientInfoDetails()
        {
            firstNameTextbox.EnterText("Testing");
            lastNameTextbox.EnterText("Testing");
            miTextbox.EnterText("Testing");
            phoneTextbox.EnterText("1234569708");
            weightTextbox.EnterText("80");
            raceDropdown.SelectValueInDropdown("Asian");
            dobTextbox.EnterText("12121988");
            etnicityDropdown.EnterText("Not Known");
            genderDropdown.EnterText("Male");
            ssnTextbox.EnterText("1234567980");
        }

        public static void EnterPatientAddressDetails()
        {
            patientAddressTextarea.Click();
            Thread.Sleep(2000);
            googleLocSearchTextbox.EnterText("testing");
            streetAddressTextbox.EnterText("testing");
            streetAddress2Textbox.EnterText("testing");
            cityTextbox.EnterText("Denver");
            stateDropdown.SelectValueInDropdown("CO");
            zipTextbox.EnterText("12345");
            municipalCodeTextbox.EnterText("12345");
            countryCodeTextbox.EnterText("001");
            additionalNotesTextbox.EnterText("testing");
            saveButtons.ClickOnSpecificNumber(0);
            Thread.Sleep(2000);
        }

        public static void EnterPersonalDetails()
        {
            dlNumberTextbox.EnterText("123456");
            ptPractionerNameTextbox.EnterText("Tsting");
            dlStateDropdown.SelectValueInDropdown("CO");
        }

        public static void EnterMedicalInfoDetails()
        {
            historyDropdown.SelectValueInDropdown("Not Known");
            historyObtainedDropdown.SelectValueInDropdown("Not Available");
            allergiesMedsDropdown.SelectValueInDropdown("Not Available");
            emergencyFormDropdown.SelectValueInDropdown("Not Known");
            allergiesOthersDropdown.SelectValueInDropdown("Not Known");
            advancedDirectivesDropdown.SelectValueInDropdown("Not Known");
            triageColorDropdown.SelectValueInDropdown("Black");
            triageCategoryDropdown.SelectValueInDropdown("Medical");
            pregnantDropdown.SelectValueInDropdown("No");
        }

        public static void EnterPatientMedicationsDetails()
        {
            newButtons.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
            routeDropdown.SelectValueInDropdown("Not Available");
            dosageTextbox.EnterText("12345");
            unitsDropdown.SelectValueInDropdown("GMS");
            saveButtons.ClickOnSpecificNumber(2);
        }

        public static void EnterPatientImmunizationsDetails()
        {
            newButtons.ClickOnSpecificNumber(1);
            typeDropdown.SelectValueInDropdown("Small Pox");
            yearTextbox.EnterText("2015");
            saveButtons.ClickOnSpecificNumber(1);
        }
    }
}
