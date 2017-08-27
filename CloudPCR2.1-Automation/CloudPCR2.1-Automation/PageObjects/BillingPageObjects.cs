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
   public class BillingPageObjects : SelectingBrowsers
    {
        #region Billing Objects
        static By conditionCodesDropdown = By.CssSelector(ReturnSelectObject("e07_35"));
        static By paymentMethodDropdown = By.CssSelector(ReturnSelectObject("e07_01"));
        static By necessityCertificateDropdown = By.CssSelector(ReturnSelectObject("e07_02"));
        static By patientEmailTextbox = By.CssSelector(ReturnInputObject("patientEmail"));
        #endregion

        #region  Employer
        static By workRelatedDropdown = By.CssSelector(ReturnSelectObject("e07_15"));
        static By employerTextbox = By.CssSelector(ReturnInputObject("e07_27"));
        static By employerPhoneTextbox   = By.CssSelector(ReturnInputObject("e07_32"));
        static By patientOccupationDropdown = By.CssSelector(ReturnSelectObject("e07_17"));
        static By occupationIndustryDropdown = By.CssSelector(ReturnSelectObject("e07_16"));
        #endregion      

        #region employer address textarea
        static By employerAddressTextarea = By.Id("employerAddressTextArea");
        static By employergoogleLocSearchTextbox = By.CssSelector(ReturnInputObject("employerAddress.geocomplete"));
        static By employerstreetAddressTextbox = By.CssSelector(ReturnInputObject("employerAddress.street"));
        static By employerstreetAddress2Textbox = By.CssSelector(ReturnInputObject("employerAddress.street2"));
        static By employercityTextbox = By.CssSelector(ReturnInputObject("employerAddress.city"));
        static By employerstateDropdown = By.CssSelector(ReturnSelectObject("employerAddress.state"));
        static By employerzipTextbox = By.CssSelector(ReturnInputObject("employerAddress.zip"));
        static By employermunicipalityPickerDropdown = By.CssSelector(ReturnSelectObject("employerAddress.fipsPicker"));
        static By employermunicipalCodeTextbox = By.CssSelector(ReturnInputObject("employerAddress.municipalityCode"));
        static By employercountryCodeTextbox = By.CssSelector(ReturnInputObject("employerAddress.countyCode"));
        static By employeradditionalNotesTextbox = By.CssSelector(ReturnInputObject("employerAddress.notes"));
        #endregion

        #region Guardian/Patient
        static By checkboxValue = By.CssSelector("div.tools input");
        static By lastNameTextbox = By.CssSelector(ReturnInputObject("e07_18"));
        static By firstNameTextbox = By.CssSelector(ReturnInputObject("e07_19"));
        static By miTextbox = By.CssSelector(ReturnInputObject("e07_20"));
        static By phoneTextbox = By.CssSelector(ReturnInputObject("e07_25"));
        static By relationshipDropdown = By.CssSelector(ReturnSelectObject("e07_26"));
        static By guardianAddressTextarea = By.Id(("guardianAddressTextArea"));
        #endregion

        #region  Guardian Textarea
        static By guardiangoogleLocSearchTextbox = By.CssSelector(ReturnInputObject("guardianAddress.geocomplete"));
        static By guardianstreetAddressTextbox = By.CssSelector(ReturnInputObject("guardianAddress.street"));
        static By guardianstreetAddress2Textbox = By.CssSelector(ReturnInputObject("guardianAddress.street2"));
        static By guardiancityTextbox = By.CssSelector(ReturnInputObject("guardianAddress.city"));
        static By guardianstateDropdown = By.CssSelector(ReturnSelectObject("guardianAddress.state"));
        static By guardianzipTextbox = By.CssSelector(ReturnInputObject("guardianAddress.zip"));
        static By guardianmunicipalityPickerDropdown = By.CssSelector(ReturnSelectObject("guardianAddress.fipsPicker"));
        static By guardianmunicipalCodeTextbox = By.CssSelector(ReturnInputObject("guardianAddress.municipalityCode"));
        static By guardiancountryCodeTextbox = By.CssSelector(ReturnInputObject("guardianAddress.countyCode"));
        static By guardianadditionalNotesTextbox = By.CssSelector(ReturnInputObject("guardianAddress.notes"));
        #endregion

        #region  Insurance New 
        static By newButtons = By.CssSelector("a[data-toggle='modal']");
        static By insuranceTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_03"));
        static By billingPriorityDropdown = By.CssSelector(ReturnSelectObject("forms.insurances.e07_04"));
        static By groupTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_09"));
        static By policyTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_10"));
        static By primaryLastNameTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_11"));
        static By primaryFirstNameTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_12"));
        static By primarymiddleNameTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_13"));
        static By relationshipToPatientDropdown = By.CssSelector(ReturnSelectObject("forms.insurances.e07_14"));
        static By streetTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_05"));
        static By cityTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_06"));
        static By stateDropdown = By.CssSelector(ReturnSelectObject("forms.insurances.e07_07"));
        static By zipTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_08"));
        #endregion

        static By closeButton = By.CssSelector("button.btn.btn-default");

        public static void EnterEmployerDetails()
        {
            workRelatedDropdown.SelectValueInDropdown("Not Applicable");
            employerTextbox.EnterText("abc");
            //address 
            employerAddressTextarea.Click();
            Thread.Sleep(2000);
            employergoogleLocSearchTextbox.EnterText("Colorado, United States");
            employerstreetAddressTextbox.EnterText("test");
            employerstreetAddress2Textbox.EnterText("test2");
            employercityTextbox.EnterText("test");
            employerstateDropdown.SelectValueInDropdown("AK");
            employerzipTextbox.EnterText("3213");
          //  employermunicipalityPickerDropdown.SelectValueInDropdown("test");
            employermunicipalCodeTextbox.EnterText("test");
            employercountryCodeTextbox.EnterText("test");
            employeradditionalNotesTextbox.EnterText("test");
            employeradditionalNotesTextbox.EnterText("test");
            employerPhoneTextbox.EnterText("2312321323");
            patientOccupationDropdown.SelectValueInDropdown("Not Applicable");
            occupationIndustryDropdown.SelectValueInDropdown("Not Applicable");
            closeButton.Click();
            Thread.Sleep(2000);
        }

        public static void EnterGuardianDetails()
        {
            checkboxValue.Click();
            Thread.Sleep(2000);
            lastNameTextbox.EnterText("abc");
            firstNameTextbox.EnterText("abc");
            miTextbox.EnterText("wera");
            phoneTextbox.EnterText("324234234");
            relationshipDropdown.SelectValueInDropdown("Not Applicable");
            //address 
            guardianAddressTextarea.Click();
            guardiangoogleLocSearchTextbox.EnterText("Colorado, United States");
            guardianstreetAddressTextbox.EnterText("test");
            guardianstreetAddress2Textbox.EnterText("test2");
            guardiancityTextbox.EnterText("test");
            guardianstateDropdown.SelectValueInDropdown("AK");
            guardianzipTextbox.EnterText("3213");
           // guardianmunicipalityPickerDropdown.SelectValueInDropdown("test");
            guardianmunicipalCodeTextbox.EnterText("test");
            guardiancountryCodeTextbox.EnterText("test");
            guardianadditionalNotesTextbox.EnterText("test");
            closeButton.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
        }

        public static void EnterInsuranceDetails()
        {
            newButtons.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
            insuranceTextbox.EnterText("abc");
            billingPriorityDropdown.SelectValueInDropdown("Not Applicable");
            groupTextbox.EnterText("abc");
            policyTextbox.EnterText("Not Applicable");
            primaryLastNameTextbox.EnterText("abc");
            primaryFirstNameTextbox.EnterText("abc");
            primarymiddleNameTextbox.EnterText("abc");
            relationshipToPatientDropdown.SelectValueInDropdown("Not Applicable");
            streetTextbox.EnterText("abc");
            cityTextbox.EnterText("abc");
            stateDropdown.SelectValueInDropdown("Not Applicable");
            zipTextbox.EnterText("234234");
            closeButton.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
        }

        public static void EnterBillingDetails()
        {
            conditionCodesDropdown.SelectValueInDropdown("Not Applicable");
            paymentMethodDropdown.SelectValueInDropdown("Not Applicable");
            necessityCertificateDropdown.SelectValueInDropdown("Not Applicable");
            patientEmailTextbox.EnterText("abc@test.com");
        }



    }
}
