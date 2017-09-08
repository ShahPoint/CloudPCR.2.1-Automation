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
        PCRVariables pcrVar = new PCRVariables();

        public CreateNewPCRPageObjects(PCRVariables pcr)
        {
            pcrVar = pcr;
        }

        #region
        By dispositionDropdown = By.CssSelector(ReturnSelectObject("e20_10"));
         By optionsDropdown = By.CssSelector("div.top-menu a.dropdown-toggle");
         By saveLinkInsideOptionsDropdown = By.CssSelector("li.dropdown.open > ul > li:nth-child(2) > a");
         By pcrSyncMessage = By.Id("toast-container");
         By backButton = By.Id("undefined");
        #endregion

        #region  locations
          By emdPerformedDropdown = By.CssSelector(ReturnSelectObject("e03_02"));
          By emdCardNoTextbox = By.CssSelector(ReturnInputObject("e03_03"));
          By locationZoneDropdown = By.CssSelector(ReturnSelectObject("e08_09"));
          By locationFacilityCodeDropdown = By.CssSelector(ReturnSelectObject("e08_08"));
        #endregion

        #region incident
          By incidentNumberTextbox = By.CssSelector(ReturnInputObject("e02_02"));
          By responseUrgencyDropdown = By.CssSelector(ReturnSelectObject("e07_33"));
          By cmsLevelDropdown = By.CssSelector(ReturnSelectObject("e07_34"));
          By typeOfLocationDropdown = By.CssSelector(ReturnSelectObject("e08_07"));
          By natureOfIncidentDropdown = By.CssSelector(ReturnSelectObject("e03_01"));
        #endregion

        #region scene address textarea
          By sceneAddressTextarea = By.Id("sceneAddressTextArea");
          By googleLocSearchTextbox = By.CssSelector(ReturnInputObject("sceneAddress.geocomplete"));
          By streetAddressTextbox = By.CssSelector(ReturnInputObject("sceneAddress.street"));
          By streetAddress2Textbox = By.CssSelector(ReturnInputObject("sceneAddress.street2"));
          By cityTextbox = By.CssSelector(ReturnInputObject("sceneAddress.city"));
          By stateDropdown = By.CssSelector(ReturnSelectObject("sceneAddress.state"));
          By zipTextbox = By.CssSelector(ReturnInputObject("sceneAddress.zip"));
          By municipalityPickerDropdown = By.CssSelector(ReturnSelectObject("sceneAddress.fipsPicker"));
          By municipalCodeTextbox = By.CssSelector(ReturnInputObject("sceneAddress.municipalityCode"));
          By countryCodeTextbox = By.CssSelector(ReturnInputObject("sceneAddress.countyCode"));
          By additionalNotesTextbox = By.CssSelector(ReturnInputObject("sceneAddress.notes"));
          By closeButton = By.CssSelector("button.btn.btn-default");
        #endregion

        #region  Dispatch
          By callSignDropdown = By.CssSelector(ReturnSelectObject("e02_12"));
          By vehicleNumberDropdown = By.CssSelector(ReturnSelectObject("e02_11"));
          By modeToSceneDropdown = By.CssSelector(ReturnSelectObject("e02_20"));
          By vehicleIncidentNumTextbox = By.CssSelector(ReturnInputObject("e02_03"));
          By serviceRequestedDropdown = By.CssSelector(ReturnSelectObject("e02_04"));
          By roleDropdown = By.CssSelector(ReturnSelectObject("e02_05"));
        #endregion
        
        #region Times
          By onsetTextbox = By.CssSelector(ReturnInputObject("e05_01_Time"));
          By receivedTextbox = By.CssSelector(ReturnInputObject("e05_02_Time"));
          By notifiedTextbox = By.CssSelector(ReturnInputObject("e05_03_Time"));
          By dispatchTextbox = By.CssSelector(ReturnInputObject("e05_04_Time"));
          By enrouteTextbox = By.CssSelector(ReturnInputObject("e05_05_Time"));
          By arrivalTextbox = By.CssSelector(ReturnInputObject("e05_06_Time"));
          By availableTextbox = By.CssSelector(ReturnInputObject("e05_11_Time"));
          By atBaseTextbox = By.CssSelector(ReturnInputObject("e05_13_Time"));
          By cancelledTextbox = By.CssSelector(ReturnInputObject("e05_12_Time"));
        #endregion

        #region  Crew
          By crewNewButton = By.CssSelector("a[data-toggle='modal']");
          By nameCrewTextbox = By.CssSelector(ReturnInputObject("forms.crew.name"));
          By crewQuickSelectDropdown = By.CssSelector("select[id='CrewSelect']");
          By stateIdTextbox = By.CssSelector(ReturnInputObject("forms.crew.e04_01"));
          By roleCrewDropdown = By.CssSelector(ReturnSelectObject("forms.crew.e04_02"));
          By certLevelDropdown = By.CssSelector(ReturnSelectObject("forms.crew.e04_03"));
          By crewSaveButton = By.CssSelector("button.btn.btn-default");
        #endregion

        #region  Mileage
          By startTextbox = By.CssSelector(ReturnInputObject("e02_16"));
          By sceneTextbox = By.CssSelector(ReturnInputObject("e02_17"));
          By serviceTextbox = By.CssSelector(ReturnInputObject("e02_19"));

          By checkboxValue = By.CssSelector("div.tools input");
        #endregion

        #region  Delays


          By dispatchDelaysTextbox = By.CssSelector(ReturnSelectObject("e02_06"));
          By responseTextbox = By.CssSelector(ReturnSelectObject("e02_07"));
          By sceneDelaysTextbox = By.CssSelector(ReturnSelectObject("e02_08"));
          By transportTextbox = By.CssSelector(ReturnSelectObject("e02_09"));
          By turnAroundTextbox = By.CssSelector(ReturnSelectObject("e02_10"));
        #endregion

        #region  Others on Scene 
          By serviceOnSceneTextbox = By.CssSelector(ReturnSelectObject("e08_02"));
          By otherEMSAgenciesTextbox = By.CssSelector(ReturnSelectObject("e08_01"));
          By emsSystemTextbox = By.CssSelector(ReturnInputObject("d04_17"));
          By responseDifferntialDropdown = By.CssSelector(ReturnSelectObject("e08_03"));
        #endregion

    

        public void SelectValueInDispositionDropdown(string value)
        {
            SelectElement element = new SelectElement(driver.FindElement(dispositionDropdown));
            element.SelectByText(value);
        }

        public void EnterIncidentNum(string num)
        {
            var obj = driver.FindElement(incidentNumberTextbox);
            obj.Clear();
            obj.SendKeys(num);
        }

        public void ClickSaveButtonFromOptionsDropdown()
        {
            driver.FindElements(optionsDropdown)[1].Click();
            Thread.Sleep(1000);
            driver.FindElement(saveLinkInsideOptionsDropdown).Click();
        }

        public void VerifyPCRSyncMessageDisplay()
        {
            Thread.Sleep(5000);
            Assert.IsTrue(driver.FindElement(pcrSyncMessage).Text.Contains("PCR sync"), "Message is not coming");
        }

        public void ClickBackButton()
        {
            driver.FindElement(backButton).Click();
            Thread.Sleep(3000);
        }
        
        public void EnterLocationDetails()
        {
            emdPerformedDropdown.SelectValueInDropdown(pcrVar.IncidentLocationemdPerformed);
            emdCardNoTextbox.EnterText(pcrVar.IncidentLocationemdCardNo);
            locationZoneDropdown.SelectValueInDropdown(pcrVar.IncidentLocationlocationZone);
            locationFacilityCodeDropdown.SelectValueInDropdown(pcrVar.IncidentLocationlocationFacilityCode);
        }

        public void EnterIncidentDetails()
        {
            incidentNumberTextbox.EnterText(pcrVar.IncidentNumber);
            responseUrgencyDropdown.SelectValueInDropdown(pcrVar.ResponseUrgency);
            typeOfLocationDropdown.SelectValueInDropdown(pcrVar.TypeOfLocation);
            natureOfIncidentDropdown.SelectValueInDropdown(pcrVar.NatureOfIncident);
            cmsLevelDropdown.SelectValueInDropdown(pcrVar.CmsLevel);
        }

        public void EnterSceneAddressDetails()
        {
            sceneAddressTextarea.Click();
            Thread.Sleep(2000);
            googleLocSearchTextbox.EnterText(pcrVar.SceneAddressGoogleLocSearch);
            streetAddressTextbox.EnterText(pcrVar.SceneAddressStreetAddress);
            streetAddress2Textbox.EnterText(pcrVar.SceneAddressstreetAddress2);
            cityTextbox.EnterText(pcrVar.SceneAddressCity);
            stateDropdown.SelectValueInDropdown(pcrVar.SceneAddressState);
            zipTextbox.EnterText(pcrVar.SceneAddressZip); 
            municipalCodeTextbox.EnterText(pcrVar.SceneAddressMunicipalCode);
            countryCodeTextbox.EnterText(pcrVar.SceneAddressCountryCode);
            additionalNotesTextbox.EnterText(pcrVar.SceneAddressAdditionalNotes);
            closeButton.Click();

        }

        public void EnterCrewDetails()
        {
            Thread.Sleep(2000);
            crewNewButton.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
            nameCrewTextbox.EnterText(pcrVar.NameCrew);
            crewQuickSelectDropdown.SelectValueInDropdown(pcrVar.CrewQuickSelect);
            stateIdTextbox.EnterText(pcrVar.StateId);
            roleCrewDropdown.SelectValueInDropdown(pcrVar.RoleCrew);
            certLevelDropdown.SelectValueInDropdown(pcrVar.CertLevel);
            crewSaveButton.ClickOnSpecificNumber(1);
        }

        public void EnterTimesDetails()
        {
            onsetTextbox.EnterText(pcrVar.IncidentTimeOnset);
            receivedTextbox.EnterText(pcrVar.IncidentTimeReceived);
            notifiedTextbox.EnterText(pcrVar.IncidentTimeNotified);
            dispatchTextbox.EnterText(pcrVar.IncidentTimeDispatch);
            enrouteTextbox.EnterText(pcrVar.IncidentTimeEnroute);
            arrivalTextbox.EnterText(pcrVar.IncidentTimeArrival);
            availableTextbox.EnterText(pcrVar.IncidentTimeAvailable);
            atBaseTextbox.EnterText(pcrVar.IncidentTimeAtBase);
            cancelledTextbox.EnterText(pcrVar.IncidentTimeCancelled);
        }

        public void EnterDispatchDetails()
        {
            callSignDropdown.SelectValueInDropdown(pcrVar.IncidentDispatchcallSign);
            vehicleNumberDropdown.SelectValueInDropdown(pcrVar.IncidentDispatchvehicleNumber);
            modeToSceneDropdown.SelectValueInDropdown(pcrVar.IncidentDispatchmodeToScene);
            vehicleIncidentNumTextbox.EnterText(pcrVar.IncidentDispatchvehicleIncidentNum);
            serviceRequestedDropdown.SelectValueInDropdown(pcrVar.IncidentDispatchserviceRequested);
            roleDropdown.SelectValueInDropdown(pcrVar.IncidentDispatchrole);
        }
        public void EnterMileageDetails()
        {
            startTextbox.EnterText(pcrVar.IncidentMileagestart);
            sceneTextbox.EnterText(pcrVar.IncidentMileagescene);
            serviceTextbox.EnterText(pcrVar.IncidentMileageservice);
        }
              
        public void EnterDelaysDetails()
        {
            Thread.Sleep(2000);
            checkboxValue.ClickOnSpecificNumber(0);
            Thread.Sleep(2000);
            dispatchDelaysTextbox.SelectValueInDropdown(pcrVar.IncidentDelaysdispatchDelays);
            responseTextbox.SelectValueInDropdown(pcrVar.IncidentDelaysresponse);
            sceneDelaysTextbox.SelectValueInDropdown(pcrVar.IncidentDelayssceneDelays);
            transportTextbox.SelectValueInDropdown(pcrVar.IncidentDelaystransport);
            turnAroundTextbox.SelectValueInDropdown(pcrVar.IncidentDelaysturnAround);
        }

        public void EnterOthersOnSceneDetails()
        {
            Thread.Sleep(2000);
            checkboxValue.ClickOnSpecificNumber(1);
            Thread.Sleep(2000);
            serviceOnSceneTextbox.SelectValueInDropdown(pcrVar.IncidentOthersOnSceneserviceOnScene);
            otherEMSAgenciesTextbox.SelectValueInDropdown(pcrVar.IncidentOthersOnSceneotherEMSAgencies);
            emsSystemTextbox.EnterText(pcrVar.IncidentOthersOnSceneemsSystem);
            responseDifferntialDropdown.SelectValueInDropdown(pcrVar.IncidentOthersOnSceneresponseDifferntial);  
        }
    }
}