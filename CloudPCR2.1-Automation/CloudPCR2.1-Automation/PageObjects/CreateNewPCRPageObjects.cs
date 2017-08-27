using CloudPCR2._1_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.PageObjects
{
    public class CreateNewPCRPageObjects : SelectingBrowsers
    {

        #region
        static By dispositionDropdown = By.CssSelector(ReturnSelectObject("e20_10"));
        static By optionsDropdown = By.CssSelector("div.top-menu a.dropdown-toggle");
        static By saveLinkInsideOptionsDropdown = By.CssSelector("li.dropdown.open > ul > li:nth-child(2) > a");
        static By pcrSyncMessage = By.Id("toast-container");
        static By backButton = By.Id("undefined");
        #endregion

        #region  locations
        static By emdPerformedDropdown = By.CssSelector(ReturnSelectObject("e03_02"));
        static By emdCardNoTextbox = By.CssSelector(ReturnInputObject("e03_03"));
        static By locationZoneDropdown = By.CssSelector(ReturnSelectObject("e08_09"));
        static By locationFacilityCodeDropdown = By.CssSelector(ReturnSelectObject("e08_08"));
        #endregion

        #region incident
        static By incidentNumberTextbox = By.CssSelector(ReturnInputObject("e02_02"));
        static By responseUrgencyDropdown = By.CssSelector(ReturnSelectObject("e07_33"));
        static By cmsLevelDropdown = By.CssSelector(ReturnSelectObject("e07_34"));
        static By typeOfLocationDropdown = By.CssSelector(ReturnSelectObject("e08_07"));
        static By natureOfIncidentDropdown = By.CssSelector(ReturnSelectObject("e03_01"));
        #endregion

        #region scene address textarea
        static By sceneAddressTextarea = By.Id("sceneAddressTextArea");
        static By googleLocSearchTextbox = By.CssSelector(ReturnInputObject("sceneAddress.geocomplete"));
        static By streetAddressTextbox = By.CssSelector(ReturnInputObject("sceneAddress.street"));
        static By streetAddress2Textbox = By.CssSelector(ReturnInputObject("sceneAddress.street2"));
        static By cityTextbox = By.CssSelector(ReturnInputObject("sceneAddress.city"));
        static By stateDropdown = By.CssSelector(ReturnSelectObject("sceneAddress.state"));
        static By zipTextbox = By.CssSelector(ReturnInputObject("sceneAddress.zip"));
        static By municipalityPickerDropdown = By.CssSelector(ReturnSelectObject("sceneAddress.fipsPicker"));
        static By municipalCodeTextbox = By.CssSelector(ReturnInputObject("sceneAddress.municipalityCode"));
        static By countryCodeTextbox = By.CssSelector(ReturnInputObject("sceneAddress.countyCode"));
        static By additionalNotesTextbox = By.CssSelector(ReturnInputObject("sceneAddress.notes"));
        static By closeButton = By.CssSelector("button.btn.btn-default");
        #endregion

        #region  Dispatch
        static By callSignDropdown = By.CssSelector(ReturnSelectObject("e02_12"));
        static By vehicleNumberDropdown = By.CssSelector(ReturnSelectObject("e02_11"));
        static By modeToSceneDropdown = By.CssSelector(ReturnSelectObject("e02_20"));
        static By vehicleIncidentNumTextbox = By.CssSelector(ReturnInputObject("e02_03"));
        static By serviceRequestedDropdown = By.CssSelector(ReturnSelectObject("e02_04"));
        static By roleDropdown = By.CssSelector(ReturnSelectObject("e02_05"));
        #endregion
        
        #region Times
        static By onsetTextbox = By.CssSelector(ReturnInputObject("e05_01_Time"));
        static By receivedTextbox = By.CssSelector(ReturnInputObject("e05_02_Time"));
        static By notifiedTextbox = By.CssSelector(ReturnInputObject("e05_03_Time"));
        static By dispatchTextbox = By.CssSelector(ReturnInputObject("e05_04_Time"));
        static By enrouteTextbox = By.CssSelector(ReturnInputObject("e05_05_Time"));
        static By arrivalTextbox = By.CssSelector(ReturnInputObject("e05_06_Time"));
        static By availableTextbox = By.CssSelector(ReturnInputObject("e05_11_Time"));
        static By atBaseTextbox = By.CssSelector(ReturnInputObject("e05_13_Time"));
        static By cancelledTextbox = By.CssSelector(ReturnInputObject("e05_12_Time"));
        #endregion

        #region  Crew
        static By crewNewButton = By.CssSelector("a[data-toggle='modal']");
        static By nameCrewTextbox = By.CssSelector(ReturnInputObject("forms.crew.name"));
        static By crewQuickSelectDropdown = By.CssSelector("select[id='CrewSelect']");
        static By stateIdTextbox = By.CssSelector(ReturnInputObject("forms.crew.e04_01"));
        static By roleCrewDropdown = By.CssSelector(ReturnSelectObject("forms.crew.e04_02"));
        static By certLevelDropdown = By.CssSelector(ReturnSelectObject("forms.crew.e04_03"));
        static By crewSaveButton = By.CssSelector("button.btn.btn-default");
        #endregion

        #region  Mileage
        static By startTextbox = By.CssSelector(ReturnInputObject("e02_16"));
        static By sceneTextbox = By.CssSelector(ReturnInputObject("e02_17"));
        static By serviceTextbox = By.CssSelector(ReturnInputObject("e02_19"));

        static By checkboxValue = By.CssSelector("div.tools input");
        #endregion

        #region  Delays


        static By dispatchDelaysTextbox = By.CssSelector(ReturnSelectObject("e02_06"));
        static By responseTextbox = By.CssSelector(ReturnSelectObject("e02_07"));
        static By sceneDelaysTextbox = By.CssSelector(ReturnSelectObject("e02_08"));
        static By transportTextbox = By.CssSelector(ReturnSelectObject("e02_09"));
        static By turnAroundTextbox = By.CssSelector(ReturnSelectObject("e02_10"));
        #endregion

        #region  Others on Scene 
        static By serviceOnSceneTextbox = By.CssSelector(ReturnSelectObject("e08_02"));
        static By otherEMSAgenciesTextbox = By.CssSelector(ReturnSelectObject("e08_01"));
        static By emsSystemTextbox = By.CssSelector(ReturnInputObject("d04_17"));
        static By responseDifferntialDropdown = By.CssSelector(ReturnSelectObject("e08_03"));
        #endregion

        #region  Actions
        #endregion

        public static void SelectValueInDispositionDropdown(string value)
        {
            SelectElement element = new SelectElement(driver.FindElement(dispositionDropdown));
            element.SelectByText(value);
        }

        public static void EnterIncidentNum(string num)
        {
            var obj = driver.FindElement(incidentNumberTextbox);
            obj.Clear();
            obj.SendKeys(num);
        }

        public static void ClickSaveButtonFromOptionsDropdown()
        {
            driver.FindElements(optionsDropdown)[1].Click();
            Thread.Sleep(1000);
            driver.FindElement(saveLinkInsideOptionsDropdown).Click();
        }

        public static void VerifyPCRSyncMessageDisplay()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(driver.FindElement(pcrSyncMessage).Text.Contains("PCR sync"), "Message is not coming");
        }

        public static void ClickBackButton()
        {
            driver.FindElement(backButton).Click();
            Thread.Sleep(3000);
        }
        
        public static void EnterLocationDetails()
        {
            emdPerformedDropdown.SelectValueInDropdown("No");
            emdCardNoTextbox.EnterText("12345");
            locationZoneDropdown.SelectValueInDropdown("Not Applicable");
            locationFacilityCodeDropdown.SelectValueInDropdown("Not Applicable");
        }

        public static void EnterIncidentDetails(PCRVariables pcr)
        {
            incidentNumberTextbox.EnterText(pcr.IncidentNumber);
            responseUrgencyDropdown.SelectValueInDropdown("Not Applicable");
            typeOfLocationDropdown.SelectValueInDropdown("Not Applicable");
            natureOfIncidentDropdown.SelectValueInDropdown("Not Applicable");
            cmsLevelDropdown.SelectValueInDropdown("Not Applicable");
        }

        public static void EnterSceneAddressDetails()
        {
            sceneAddressTextarea.Click();
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
            closeButton.Click();

        }

        public static void EnterTimesDetails()
        {
            onsetTextbox.EnterText("1234");
            receivedTextbox.EnterText("1234");
            notifiedTextbox.EnterText("1234");
            dispatchTextbox.EnterText("1234");
            enrouteTextbox.EnterText("1234");
            arrivalTextbox.EnterText("1234");
            availableTextbox.EnterText("1234");
            atBaseTextbox.EnterText("1234");
            cancelledTextbox.EnterText("1234");
        }

        public static void EnterDispatchDetails()
        {
            callSignDropdown.SelectValueInDropdown("sign");
            vehicleNumberDropdown.SelectValueInDropdown("Number");
            modeToSceneDropdown.SelectValueInDropdown("No Lights or Sirens");
            vehicleIncidentNumTextbox.EnterText("12345");
            serviceRequestedDropdown.SelectValueInDropdown("Standby");
            roleDropdown.SelectValueInDropdown("Rescue");
        }

        public static void EnterCrewDetails()
        {
            Thread.Sleep(2000);
            crewNewButton.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
            nameCrewTextbox.EnterText("test");
            crewQuickSelectDropdown.SelectValueInDropdown("admin admin");
            stateIdTextbox.EnterText("Stateid");
            roleCrewDropdown.SelectValueInDropdown("Not Applicable");
            certLevelDropdown.SelectValueInDropdown("Not Known");
            crewSaveButton.ClickOnSpecificNumber(1);
        }

        public static void EnterMileageDetails()
        {
            startTextbox.EnterText("5678");
            sceneTextbox.EnterText("5900");
            serviceTextbox.EnterText("6000");
        }
              
        public static void EnterDelaysDetails()
        {
            Thread.Sleep(2000);
            checkboxValue.ClickOnSpecificNumber(0);
            Thread.Sleep(2000);
            dispatchDelaysTextbox.SelectValueInDropdown("Not Applicable");
            responseTextbox.SelectValueInDropdown("Not Applicable");
            sceneDelaysTextbox.SelectValueInDropdown("Not Available");
            transportTextbox.SelectValueInDropdown("Not Applicable");
            turnAroundTextbox.SelectValueInDropdown("Not Available");
        }

        public static void EnterOthersOnSceneDetails()
        {
            Thread.Sleep(2000);
            checkboxValue.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
            serviceOnSceneTextbox.SelectValueInDropdown("Not Available");
            otherEMSAgenciesTextbox.SelectValueInDropdown("Not Available");
            emsSystemTextbox.EnterText("123456");
            responseDifferntialDropdown.SelectValueInDropdown("Not Available");  
        }
    }
}