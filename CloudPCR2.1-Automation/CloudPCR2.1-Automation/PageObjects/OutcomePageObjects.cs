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

        #region DestinationTransferto Objects
        static By destinationReasonDropdown = By.CssSelector(ReturnSelectObject("e20_16"));
        static By transferConditionDropdown = By.CssSelector(ReturnSelectObject("e20_15"));
        static By destinationTypeDropdown = By.CssSelector(ReturnSelectObject("e20_17"));
        static By destinationCodeDropdown = By.CssSelector(ReturnSelectObject("e20_02"));


        //destination custom object not spying
        static By destinationAddressTextarea = By.Id("destinationAddressTextArea");

        static By destinationgoogleLocSearchTextbox = By.CssSelector(ReturnInputObject("destinationAddress.geocomplete"));
        static By destinationstreetAddressTextbox = By.CssSelector(ReturnInputObject("destinationAddress.street"));
        static By destinationstreetAddress2Textbox = By.CssSelector(ReturnInputObject("destinationAddress.street2"));
        static By destinationcityTextbox = By.CssSelector(ReturnInputObject("destinationAddress.city"));
        static By destinationstateDropdown = By.CssSelector(ReturnSelectObject("destinationAddress.state"));
        static By destinationzipTextbox = By.CssSelector(ReturnInputObject("destinationAddress.zip"));
        static By destinationmunicipalityPickerDropdown = By.CssSelector(ReturnSelectObject("destinationAddress.fipsPicker"));
        static By destinationmunicipalCodeTextbox = By.CssSelector(ReturnInputObject("destinationAddress.municipalityCode"));
        static By destinationcountryCodeTextbox = By.CssSelector(ReturnInputObject("destinationAddress.countyCode"));
        static By destinationadditionalNotesTextbox = By.CssSelector(ReturnInputObject("destinationAddress.notes"));
        static By closeButtons = By.CssSelector("button.btn.btn-default");
        #endregion

        #region TransportInformation Objects 

        static By mciDropdown = By.CssSelector(ReturnSelectObject("e08_06"));
        static By rythmDestinationDropdown = By.CssSelector(ReturnSelectObject("e11_11"));
        static By numberofPatientsDropdown = By.CssSelector(ReturnSelectObject("e08_05"));
        static By erDispositionDropdown = By.CssSelector(ReturnSelectObject("e22_01"));
        static By toAmbulanceViaDropdown = By.CssSelector(ReturnSelectObject("e20_11"));
        static By hospitalDispositionDropdown = By.CssSelector(ReturnSelectObject("e22_02"));
        static By transportPositionDropdown = By.CssSelector(ReturnSelectObject("e20_12"));
        static By fromAmbulanceViaDropdown = By.CssSelector(ReturnSelectObject("e20_13"));
        static By modeFromSceneDropdown = By.CssSelector(ReturnSelectObject("e20_14"));
        #endregion

        #region OtherReportingInfo Objects

        static By dischargeNeuroDropdown = By.CssSelector(ReturnSelectObject("e11_07"));
        static By transferToRecordTextbox = By.CssSelector(ReturnInputObject("e12_02"));
        static By traumaRegistryIDTextbox = By.CssSelector(ReturnInputObject("e22_04"));
        static By destinationRecordTextbox = By.CssSelector(ReturnInputObject("e12_03"));
        static By fireReportTextbox = By.CssSelector(ReturnInputObject("e22_05"));
        static By destinationZoneDropdown = By.CssSelector(ReturnSelectObject("e20_09"));
        static By patientIDTagTextbox = By.CssSelector(ReturnInputObject("e22_06"));
        static By vehicleLatGPSTextbox = By.CssSelector(ReturnInputObject("e02_15_Lat"));
        static By destinationLatGPSTextbox = By.CssSelector(ReturnInputObject("e20_08_Lat"));
        static By vehicleLongGPSTextbox = By.CssSelector(ReturnInputObject("e02_15_Long"));
        static By destinationLongGPSTextbox = By.CssSelector(ReturnInputObject("e20_08_Long"));
        #endregion

        public static void EnterDestinationDetails()
        {
            //destination
            //destinationReasonDropdown.SelectValueInDropdown("Not Available");
            //transferConditionDropdown.SelectValueInDropdown("Worse");
            //destinationTypeDropdown.SelectValueInDropdown("Home");
            //destinationCodeDropdown.SelectValueInDropdown("Not Available");
            //address 
            destinationAddressTextarea.Click();
            Thread.Sleep(2000);
            destinationgoogleLocSearchTextbox.EnterText("Colorado, United States");
            destinationstreetAddressTextbox.EnterText("test");
            destinationstreetAddress2Textbox.EnterText("test2");
            destinationcityTextbox.EnterText("test");
            destinationstateDropdown.SelectValueInDropdown("AK");
            destinationzipTextbox.EnterText("3213");
            //    destinationmunicipalityPickerDropdown.SelectValueInDropdown("test");
            destinationmunicipalCodeTextbox.EnterText("test");
            destinationcountryCodeTextbox.EnterText("test");
            destinationadditionalNotesTextbox.EnterText("test");
            closeButtons.ClickOnSpecificNumber(0);
            Thread.Sleep(2000);

        }

        public static void EnterTransportInformationDetails()
        {
            mciDropdown.SelectValueInDropdown("Yes");
          //  rythmDestinationDropdown.SelectValueInDropdown("Not Known");
            numberofPatientsDropdown.SelectValueInDropdown("None");
            erDispositionDropdown.SelectValueInDropdown("Death");
            toAmbulanceViaDropdown.SelectValueInDropdown("Not Applicable");
            hospitalDispositionDropdown.SelectValueInDropdown("Not Applicable");
            transportPositionDropdown.SelectValueInDropdown("Not Applicable");
            fromAmbulanceViaDropdown.SelectValueInDropdown("Carry");
           // modeFromSceneDropdown.SelectValueInDropdown("Not Known");
        }

        public static void EnterOtherReportInfoDetails()
        {
            dischargeNeuroDropdown.SelectValueInDropdown("Not Available");
            transferToRecordTextbox.EnterText("test");
            traumaRegistryIDTextbox.EnterText("test");
            destinationRecordTextbox.EnterText("test");
            fireReportTextbox.EnterText("test");
            destinationZoneDropdown.SelectValueInDropdown("Not Applicable");
            patientIDTagTextbox.EnterText("test");
            vehicleLatGPSTextbox.EnterText("test");
            destinationLatGPSTextbox.EnterText("test");
            vehicleLongGPSTextbox.EnterText("test");
            destinationLongGPSTextbox.EnterText("test");
        }


    }
}
