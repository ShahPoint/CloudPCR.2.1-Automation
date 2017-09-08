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
        PCRVariables pcrVar = new PCRVariables();

        public BillingPageObjects(PCRVariables pcr)
        {
            pcrVar = pcr;
        }

        #region Billing Objects
        By conditionCodesDropdown = By.CssSelector(ReturnSelectObject("e07_35"));
        By paymentMethodDropdown = By.CssSelector(ReturnSelectObject("e07_01"));
        By necessityCertificateDropdown = By.CssSelector(ReturnSelectObject("e07_02"));
        By patientEmailTextbox = By.CssSelector(ReturnInputObject("patientEmail"));
        #endregion

        #region  Employer
        By workRelatedDropdown = By.CssSelector(ReturnSelectObject("e07_15"));
        By employerTextbox = By.CssSelector(ReturnInputObject("e07_27"));
        By employerPhoneTextbox   = By.CssSelector(ReturnInputObject("e07_32"));
        By patientOccupationDropdown = By.CssSelector(ReturnSelectObject("e07_17"));
        By occupationIndustryDropdown = By.CssSelector(ReturnSelectObject("e07_16"));
        #endregion      

        #region employer address textarea
        By employerAddressTextarea = By.Id("employerAddressTextArea");
        By employergoogleLocSearchTextbox = By.CssSelector(ReturnInputObject("employerAddress.geocomplete"));
        By employerstreetAddressTextbox = By.CssSelector(ReturnInputObject("employerAddress.street"));
        By employerstreetAddress2Textbox = By.CssSelector(ReturnInputObject("employerAddress.street2"));
        By employercityTextbox = By.CssSelector(ReturnInputObject("employerAddress.city"));
        By employerstateDropdown = By.CssSelector(ReturnSelectObject("employerAddress.state"));
        By employerzipTextbox = By.CssSelector(ReturnInputObject("employerAddress.zip"));
        By employermunicipalityPickerDropdown = By.CssSelector(ReturnSelectObject("employerAddress.fipsPicker"));
        By employermunicipalCodeTextbox = By.CssSelector(ReturnInputObject("employerAddress.municipalityCode"));
        By employercountryCodeTextbox = By.CssSelector(ReturnInputObject("employerAddress.countyCode"));
        By employeradditionalNotesTextbox = By.CssSelector(ReturnInputObject("employerAddress.notes"));
        #endregion

        #region Guardian/Patient
        By checkboxValue = By.CssSelector("div.tools input");
        By lastNameTextbox = By.CssSelector(ReturnInputObject("e07_18"));
        By firstNameTextbox = By.CssSelector(ReturnInputObject("e07_19"));
        By miTextbox = By.CssSelector(ReturnInputObject("e07_20"));
        By phoneTextbox = By.CssSelector(ReturnInputObject("e07_25"));
        By relationshipDropdown = By.CssSelector(ReturnSelectObject("e07_26"));
        By guardianAddressTextarea = By.Id(("guardianAddressTextArea"));
        #endregion

        #region  Guardian Textarea
        By guardiangoogleLocSearchTextbox = By.CssSelector(ReturnInputObject("guardianAddress.geocomplete"));
        By guardianstreetAddressTextbox = By.CssSelector(ReturnInputObject("guardianAddress.street"));
        By guardianstreetAddress2Textbox = By.CssSelector(ReturnInputObject("guardianAddress.street2"));
        By guardiancityTextbox = By.CssSelector(ReturnInputObject("guardianAddress.city"));
        By guardianstateDropdown = By.CssSelector(ReturnSelectObject("guardianAddress.state"));
        By guardianzipTextbox = By.CssSelector(ReturnInputObject("guardianAddress.zip"));
        By guardianmunicipalityPickerDropdown = By.CssSelector(ReturnSelectObject("guardianAddress.fipsPicker"));
        By guardianmunicipalCodeTextbox = By.CssSelector(ReturnInputObject("guardianAddress.municipalityCode"));
        By guardiancountryCodeTextbox = By.CssSelector(ReturnInputObject("guardianAddress.countyCode"));
        By guardianadditionalNotesTextbox = By.CssSelector(ReturnInputObject("guardianAddress.notes"));
        #endregion

        #region  Insurance New 
        By newButtons = By.CssSelector("a[data-toggle='modal']");
        By insuranceTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_03"));
        By billingPriorityDropdown = By.CssSelector(ReturnSelectObject("forms.insurances.e07_04"));
        By groupTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_09"));
        By policyTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_10"));
        By primaryLastNameTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_11"));
        By primaryFirstNameTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_12"));
        By primarymiddleNameTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_13"));
        By relationshipToPatientDropdown = By.CssSelector(ReturnSelectObject("forms.insurances.e07_14"));
        By streetTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_05"));
        By cityTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_06"));
        By stateDropdown = By.CssSelector(ReturnSelectObject("forms.insurances.e07_07"));
        By zipTextbox = By.CssSelector(ReturnInputObject("forms.insurances.e07_08"));
        #endregion

        static By closeButton = By.CssSelector("button.btn.btn-default");

        public void EnterEmployerDetails()
        {
            workRelatedDropdown.SelectValueInDropdown(pcrVar.BillingEmployerworkRelated);
            employerTextbox.EnterText(pcrVar.BillingEmployeremployer);
            //address 
            employerAddressTextarea.Click();
            Thread.Sleep(2000);
            employergoogleLocSearchTextbox.EnterText(pcrVar.BillingEmployergoogleLocSearch);
            employerstreetAddressTextbox.EnterText(pcrVar.BillingEmployerstreetAddress);
            employerstreetAddress2Textbox.EnterText(pcrVar.BillingEmployerstreetAddress2);
            employercityTextbox.EnterText(pcrVar.BillingEmployercity);
            employerstateDropdown.SelectValueInDropdown(pcrVar.BillingEmployerstate);
            employerzipTextbox.EnterText(pcrVar.BillingEmployerzip);
          //employermunicipalityPickerDropdown.SelectValueInDropdown("test");
            employermunicipalCodeTextbox.EnterText(pcrVar.BillingEmployermunicipalCode);
            employercountryCodeTextbox.EnterText(pcrVar.BillingEmployercountryCode);
            employeradditionalNotesTextbox.EnterText(pcrVar.BillingEmployeradditionalNotes);
            employeradditionalNotesTextbox.EnterText(pcrVar.BillingEmployeradditionalNotes);
            employerPhoneTextbox.EnterText(pcrVar.BillingEmployerPhone);
            patientOccupationDropdown.SelectValueInDropdown(pcrVar.BillingEmployerpatientOccupation);
            occupationIndustryDropdown.SelectValueInDropdown(pcrVar.BillingEmployeroccupationIndustry);
            closeButton.Click();
            Thread.Sleep(2000);
        }

        public  void EnterGuardianDetails()
        {
            checkboxValue.Click();
            Thread.Sleep(2000);
            lastNameTextbox.EnterText(pcrVar.BillingGuardianlastName);
            firstNameTextbox.EnterText(pcrVar.BillingGuardianfirstName);
            miTextbox.EnterText(pcrVar.BillingGuardianmi);
            phoneTextbox.EnterText(pcrVar.BillingGuardianphone);
            relationshipDropdown.SelectValueInDropdown(pcrVar.BillingGuardianrelationship);
            //address 
            guardianAddressTextarea.Click();
            guardiangoogleLocSearchTextbox.EnterText(pcrVar.BillingGuardiangoogleLocSearch);
            guardianstreetAddressTextbox.EnterText(pcrVar.BillingGuardianstreetAddress);
            guardianstreetAddress2Textbox.EnterText(pcrVar.BillingGuardianstreetAddress2);
            guardiancityTextbox.EnterText(pcrVar.BillingGuardiancity);
            guardianstateDropdown.SelectValueInDropdown(pcrVar.BillingGuardianstate);
            guardianzipTextbox.EnterText(pcrVar.BillingGuardianzip);
           // guardianmunicipalityPickerDropdown.SelectValueInDropdown("test");
            guardianmunicipalCodeTextbox.EnterText(pcrVar.BillingGuardianmunicipalCode);
            guardiancountryCodeTextbox.EnterText(pcrVar.BillingGuardiancountryCode);
            guardianadditionalNotesTextbox.EnterText(pcrVar.BillingGuardianadditionalNotes);
            closeButton.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
        }

        public  void EnterInsuranceDetails()
        {
            newButtons.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
            insuranceTextbox.EnterText(pcrVar.BillingInsurance);
            billingPriorityDropdown.SelectValueInDropdown(pcrVar.BillingInsurancebillingPriority);
            groupTextbox.EnterText(pcrVar.BillingInsurancegroup);
            policyTextbox.EnterText(pcrVar.BillingInsurancepolicy);
            primaryLastNameTextbox.EnterText(pcrVar.BillingInsuranceprimaryLastName);
            primaryFirstNameTextbox.EnterText(pcrVar.BillingInsuranceprimaryFirstName);
            primarymiddleNameTextbox.EnterText(pcrVar.BillingInsuranceprimarymiddleName);
            relationshipToPatientDropdown.SelectValueInDropdown(pcrVar.BillingInsurancerelationshipToPatient);
            streetTextbox.EnterText(pcrVar.BillingInsurancestreet);
            cityTextbox.EnterText(pcrVar.BillingInsurancecity);
            stateDropdown.SelectValueInDropdown(pcrVar.BillingInsurancestate);
            zipTextbox.EnterText(pcrVar.BillingInsurancezip);
            closeButton.ClickOnSpecificNumber(2);
            Thread.Sleep(2000);
        }

        public  void EnterBillingDetails()
        {
            conditionCodesDropdown.SelectValueInDropdown(pcrVar.BillingDetailsconditionCodes);
            paymentMethodDropdown.SelectValueInDropdown(pcrVar.BillingDetailspaymentMethod);
            necessityCertificateDropdown.SelectValueInDropdown(pcrVar.BillingDetailsnecessityCertificate);
            patientEmailTextbox.EnterText(pcrVar.BillingDetailspatientEmail);
        }



    }
}
