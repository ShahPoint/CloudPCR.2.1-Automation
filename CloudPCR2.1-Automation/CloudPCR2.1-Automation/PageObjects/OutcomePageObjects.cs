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
    public class OutcomePageObjects : SelectingBrowsers
    {
        PCRVariables pcrVar = new PCRVariables();

        public OutcomePageObjects(PCRVariables pcr)
        {
            pcrVar = pcr;
        }

        #region DestinationTransferto Objects
        By destinationReasonDropdown = By.CssSelector(ReturnSelectObject("e20_16"));
        By transferConditionDropdown = By.CssSelector(ReturnSelectObject("e20_15"));
        By destinationTypeDropdown = By.CssSelector(ReturnSelectObject("e20_17"));
        By destinationCodeDropdown = By.CssSelector(ReturnSelectObject("e20_02"));


        //destination custom object not spying
        By destinationAddressTextarea = By.Id("destinationAddressTextArea");
        
        By destinationgoogleLocSearchTextbox = By.CssSelector(ReturnInputObject("destinationAddress.geocomplete"));
        By destinationstreetAddressTextbox = By.CssSelector(ReturnInputObject("destinationAddress.street"));
        By destinationstreetAddress2Textbox = By.CssSelector(ReturnInputObject("destinationAddress.street2"));
        By destinationcityTextbox = By.CssSelector(ReturnInputObject("destinationAddress.city"));
        By destinationstateDropdown = By.CssSelector(ReturnSelectObject("destinationAddress.state"));
        By destinationzipTextbox = By.CssSelector(ReturnInputObject("destinationAddress.zip"));
        By destinationmunicipalityPickerDropdown = By.CssSelector(ReturnSelectObject("destinationAddress.fipsPicker"));
        By destinationmunicipalCodeTextbox = By.CssSelector(ReturnInputObject("destinationAddress.municipalityCode"));
        By destinationcountryCodeTextbox = By.CssSelector(ReturnInputObject("destinationAddress.countyCode"));
        By destinationadditionalNotesTextbox = By.CssSelector(ReturnInputObject("destinationAddress.notes"));
        By closeButtons = By.CssSelector("button.btn.btn-default");
        #endregion

        #region TransportInformation Objects 

        By mciDropdown = By.CssSelector(ReturnSelectObject("e08_06"));
        By rythmDestinationDropdown = By.CssSelector(ReturnSelectObject("e11_11"));
        By numberofPatientsDropdown = By.CssSelector(ReturnSelectObject("e08_05"));
        By erDispositionDropdown = By.CssSelector(ReturnSelectObject("e22_01"));
        By toAmbulanceViaDropdown = By.CssSelector(ReturnSelectObject("e20_11"));
        By hospitalDispositionDropdown = By.CssSelector(ReturnSelectObject("e22_02"));
        By transportPositionDropdown = By.CssSelector(ReturnSelectObject("e20_12"));
        By fromAmbulanceViaDropdown = By.CssSelector(ReturnSelectObject("e20_13"));
        By modeFromSceneDropdown = By.CssSelector(ReturnSelectObject("e20_14"));
        #endregion

        #region OtherReportingInfo Objects

        By dischargeNeuroDropdown = By.CssSelector(ReturnSelectObject("e11_07"));
        By transferToRecordTextbox = By.CssSelector(ReturnInputObject("e12_02"));
        By traumaRegistryIDTextbox = By.CssSelector(ReturnInputObject("e22_04"));
        By destinationRecordTextbox = By.CssSelector(ReturnInputObject("e12_03"));
        By fireReportTextbox = By.CssSelector(ReturnInputObject("e22_05"));
        By destinationZoneDropdown = By.CssSelector(ReturnSelectObject("e20_09"));
        By patientIDTagTextbox = By.CssSelector(ReturnInputObject("e22_06"));
        By vehicleLatGPSTextbox = By.CssSelector(ReturnInputObject("e02_15_Lat"));
        By destinationLatGPSTextbox = By.CssSelector(ReturnInputObject("e20_08_Lat"));
        By vehicleLongGPSTextbox = By.CssSelector(ReturnInputObject("e02_15_Long"));
        By destinationLongGPSTextbox = By.CssSelector(ReturnInputObject("e20_08_Long"));
        #endregion

        public void EnterDestinationDetails()
        {
            //destination
            //destinationReasonDropdown.SelectValueInDropdown("Not Available");
            //transferConditionDropdown.SelectValueInDropdown("Worse");
            //destinationTypeDropdown.SelectValueInDropdown("Home");
            //destinationCodeDropdown.SelectValueInDropdown("Not Available");
            //address 
            destinationAddressTextarea.Click();
            Thread.Sleep(2000);
            destinationgoogleLocSearchTextbox.EnterText(pcrVar.OutcomeDestinationgoogleLocSearch);
            destinationstreetAddressTextbox.EnterText(pcrVar.OutcomeDestinationstreetAddress);
            destinationstreetAddress2Textbox.EnterText(pcrVar.OutcomeDestinationstreetAddress2);
            destinationcityTextbox.EnterText(pcrVar.OutcomeDestinationcity);
            destinationstateDropdown.SelectValueInDropdown(pcrVar.OutcomeDestinationstate);
            destinationzipTextbox.EnterText(pcrVar.OutcomeDestinationzip);
            //destinationmunicipalityPickerDropdown.SelectValueInDropdown("test");
            destinationmunicipalCodeTextbox.EnterText(pcrVar.OutcomeDestinationmunicipalCode);
            destinationcountryCodeTextbox.EnterText(pcrVar.OutcomeDestinationcountryCode);
            destinationadditionalNotesTextbox.EnterText(pcrVar.OutcomeDestinationadditionalNotes);
            closeButtons.ClickOnSpecificNumber(0);
            Thread.Sleep(2000);

        }

        public void EnterTransportInformationDetails()
        {
            mciDropdown.SelectValueInDropdown(pcrVar.OutcomeTransportInfomci);
            // rythmDestinationDropdown.SelectValueInDropdown("Not Known");
            numberofPatientsDropdown.SelectValueInDropdown(pcrVar.OutcomeTransportInfonumberofPatients);
            erDispositionDropdown.SelectValueInDropdown(pcrVar.OutcomeTransportInfoerDisposition);
            toAmbulanceViaDropdown.SelectValueInDropdown(pcrVar.OutcomeTransportInfotoAmbulanceVia);
            hospitalDispositionDropdown.SelectValueInDropdown(pcrVar.OutcomeTransportInfohospitalDisposition);
            transportPositionDropdown.SelectValueInDropdown(pcrVar.OutcomeTransportInfotransportPosition);
            fromAmbulanceViaDropdown.SelectValueInDropdown(pcrVar.OutcomeTransportInfofromAmbulanceVia);
           // modeFromSceneDropdown.SelectValueInDropdown("Not Known");
        }

        public void EnterOtherReportInfoDetails()
        {
            dischargeNeuroDropdown.SelectValueInDropdown(pcrVar.OutcomeOtherReportdischargeNeuro);
            transferToRecordTextbox.EnterText(pcrVar.OutcomeOtherReporttransferToRecord);
            traumaRegistryIDTextbox.EnterText(pcrVar.OutcomeOtherReporttraumaRegistryID);
            destinationRecordTextbox.EnterText(pcrVar.OutcomeOtherReportdestinationRecord);
            fireReportTextbox.EnterText(pcrVar.OutcomeOtherReportfireReport);
            destinationZoneDropdown.SelectValueInDropdown(pcrVar.OutcomeOtherReportdestinationZone);
            patientIDTagTextbox.EnterText(pcrVar.OutcomeOtherReportpatientIDTag);
            vehicleLatGPSTextbox.EnterText(pcrVar.OutcomeOtherReportvehicleLatGPS);
            destinationLatGPSTextbox.EnterText(pcrVar.OutcomeOtherReportdestinationLatGPS);
            vehicleLongGPSTextbox.EnterText(pcrVar.OutcomeOtherReportvehicleLongGPS);
            destinationLongGPSTextbox.EnterText(pcrVar.OutcomeOtherReportdestinationLongGPS);
        }


    }
}
