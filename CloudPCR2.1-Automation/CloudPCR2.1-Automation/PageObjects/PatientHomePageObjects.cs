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
        PCRVariables pcrVar = new PCRVariables();

        public PatientHomePageObjects(PCRVariables pcr)
        {
            pcrVar = pcr;
        }

        #region  patient info
       By firstNameTextbox = By.CssSelector(ReturnInputObject("e06_02"));
       By lastNameTextbox = By.CssSelector(ReturnInputObject("e06_01"));
       By miTextbox = By.CssSelector(ReturnInputObject("e06_03"));
       By phoneTextbox = By.CssSelector(ReturnInputObject("e06_17"));
       By weightTextbox = By.CssSelector(ReturnInputObject("e16_01"));
       By raceDropdown = By.CssSelector(ReturnSelectObject("e06_12"));
       By dobTextbox   = By.CssSelector(ReturnInputObject("e06_16_Date"));
       By etnicityDropdown = By.CssSelector(ReturnSelectObject("e06_13"));
       By genderDropdown = By.CssSelector(ReturnSelectObject("e06_11"));
       By ssnTextbox = By.CssSelector(ReturnInputObject("e06_10"));
        #endregion

        #region  patient address
        By patientAddressTextarea = By.Id("patientAddressTextArea");
        By googleLocSearchTextbox = By.CssSelector(ReturnInputObject("patientAddress.geocomplete"));
        By streetAddressTextbox = By.CssSelector(ReturnInputObject("patientAddress.street"));
        By streetAddress2Textbox = By.CssSelector(ReturnInputObject("patientAddress.street2"));
        By cityTextbox = By.CssSelector(ReturnInputObject("patientAddress.city"));
        By stateDropdown = By.CssSelector(ReturnSelectObject("patientAddress.state"));
        By zipTextbox = By.CssSelector(ReturnInputObject("patientAddress.zip"));
        By municipalityPickerDropdown = By.CssSelector(ReturnSelectObject("patientAddress.fipsPicker"));
        By municipalCodeTextbox = By.CssSelector(ReturnInputObject("patientAddress.municipalityCode"));
        By countryCodeTextbox = By.CssSelector(ReturnInputObject("patientAddress.countyCode"));
        By additionalNotesTextbox = By.CssSelector(ReturnInputObject("patientAddress.notes"));
        #endregion

        #region personal
        By dlNumberTextbox = By.CssSelector(ReturnInputObject("e06_19"));
        By ptPractionerNameTextbox = By.CssSelector(ReturnInputObject("e12_06"));
        By dlStateDropdown = By.CssSelector(ReturnSelectObject("e06_18"));
        #endregion

        #region  medical Info
        By historyDropdown = By.CssSelector(ReturnSelectObject("e12_10"));
        By historyObtainedDropdown = By.CssSelector(ReturnSelectObject("e12_11"));
        By allergiesMedsDropdown = By.CssSelector(ReturnSelectObject("e12_08"));
        By emergencyFormDropdown = By.CssSelector(ReturnSelectObject("e12_18"));
        By allergiesOthersDropdown = By.CssSelector(ReturnSelectObject("e12_09"));
        By advancedDirectivesDropdown = By.CssSelector(ReturnSelectObject("e12_07"));
        By triageColorDropdown = By.CssSelector(ReturnSelectObject("customTriageColor"));
        By triageCategoryDropdown = By.CssSelector(ReturnSelectObject("customTriageCategory"));
        By pregnantDropdown = By.CssSelector(ReturnSelectObject("e12_20"));

        By newButtons = By.CssSelector("a[data-toggle='modal']");
        By saveButtons = By.CssSelector("button.btn.btn-default");
        #endregion

        #region  patient medication 
        By routeDropdown = By.CssSelector(ReturnSelectObject("forms.patientMedications.e12_17"));
        By dosageTextbox = By.CssSelector(ReturnInputObject("forms.patientMedications.e12_15"));
        By unitsDropdown = By.CssSelector(ReturnSelectObject("forms.patientMedications.e12_16"));
        #endregion

        #region  immunization
        By typeDropdown = By.CssSelector(ReturnSelectObject("forms.immunizations.e12_12"));
        By yearTextbox = By.CssSelector(ReturnInputObject("forms.immunizations.e12_13"));
        #endregion

        public void EnterPatientInfoDetails()
        {
            firstNameTextbox.EnterText(pcrVar.PatientInfoDetailsfirstName);
            lastNameTextbox.EnterText(pcrVar.PatientInfoDetailslastName);
            miTextbox.EnterText(pcrVar.PatientInfoDetailsmi);
            phoneTextbox.EnterText(pcrVar.PatientInfoDetailsphone);
            weightTextbox.EnterText(pcrVar.PatientInfoDetailsweight);
            raceDropdown.SelectValueInDropdown(pcrVar.PatientInfoDetailsrace);
            dobTextbox.EnterText(pcrVar.PatientInfoDetailsdob);
            etnicityDropdown.EnterText(pcrVar.PatientInfoDetailsetnicity);
            genderDropdown.EnterText(pcrVar.PatientInfoDetailsgender);
            ssnTextbox.EnterText(pcrVar.PatientInfoDetailsssn);
        }

        public void EnterPatientAddressDetails()
        {
            patientAddressTextarea.Click();
            Thread.Sleep(2000);
            googleLocSearchTextbox.EnterText(pcrVar.PatientAddressDetailsgoogleLocSearch);
            streetAddressTextbox.EnterText(pcrVar.PatientAddressDetailsstreetAddress);
            streetAddress2Textbox.EnterText(pcrVar.PatientAddressDetailsstreetAddress2);
            cityTextbox.EnterText(pcrVar.PatientAddressDetailscity);
            stateDropdown.SelectValueInDropdown(pcrVar.PatientAddressDetailsstate);
            zipTextbox.EnterText(pcrVar.PatientAddressDetailszip);
            municipalCodeTextbox.EnterText(pcrVar.PatientAddressDetailsmunicipalCode);
            countryCodeTextbox.EnterText(pcrVar.PatientAddressDetailscountryCode);
            additionalNotesTextbox.EnterText(pcrVar.PatientAddressDetailsadditionalNotes);
            saveButtons.ClickOnSpecificNumber(0);
            Thread.Sleep(2000);
        }

        public void EnterPersonalDetails()
        {
            dlNumberTextbox.EnterText(pcrVar.PatientPersonalDetailsdlNumber);
            ptPractionerNameTextbox.EnterText(pcrVar.PatientPersonalDetailsptPractionerName);
            dlStateDropdown.SelectValueInDropdown(pcrVar.PatientPersonalDetailsdlState);
        }

        public void EnterMedicalInfoDetails()
        {
            historyDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfohistory);
            historyObtainedDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfohistoryObtained);
            allergiesMedsDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfoallergiesMeds);
            emergencyFormDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfoemergencyForm);
            allergiesOthersDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfoallergiesOthers);
            advancedDirectivesDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfoadvancedDirectives);
            triageColorDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfotriageColor);
            triageCategoryDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfotriageCategory);
            pregnantDropdown.SelectValueInDropdown(pcrVar.PatientMedicalInfopregnant);
        }

        public void EnterPatientMedicationsDetails()
        {
            newButtons.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
            routeDropdown.SelectValueInDropdown(pcrVar.PatientMedicationsroute);
            dosageTextbox.EnterText(pcrVar.PatientMedicationsdosage);
            unitsDropdown.SelectValueInDropdown(pcrVar.PatientMedicationsunits);
            saveButtons.ClickOnSpecificNumber(2);
        }

        public void EnterPatientImmunizationsDetails()
        {
            newButtons.ClickOnSpecificNumber(1);
            typeDropdown.SelectValueInDropdown(pcrVar.PatientImmunizationstype);
            yearTextbox.EnterText(pcrVar.PatientImmunizationsyear);
            saveButtons.ClickOnSpecificNumber(1);
        }
    }
}
