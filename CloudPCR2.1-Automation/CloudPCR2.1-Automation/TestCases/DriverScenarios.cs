using CloudPCR2._1_Automation.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.TestCases
{
    [TestClass]
    public class DriverScenarios : SelectingBrowsers
    {
        [TestInitialize]
        public void StartBrowser()
        {
            string Url = GlobalVariables.URL;

            OpenBrowser("Chrome", Url);
        }

        [TestCleanup]
        public void CloseBrowser()
        {
            driver.Close();
        }

        public PCRVariables SeedData(PCRVariables pcr)
        {
            pcr.IncidentNumber = "1234";
            pcr.DispositionOutcome = "Cancelled";
            pcr.ResponseUrgency = "Not Applicable";
            pcr.TypeOfLocation = "Not Applicable";
            pcr.NatureOfIncident = "Not Applicable";
            pcr.CmsLevel = "Not Applicable";
            pcr.SceneAddressGoogleLocSearch = "testing";
            pcr.SceneAddressStreetAddress = "testing";
            pcr.SceneAddressstreetAddress2 = "testing";
            pcr.SceneAddressCity = "Denver";
            pcr.SceneAddressState = "CO";
            pcr.SceneAddressZip = "12345";
            pcr.SceneAddressMunicipalCode = "12345";
            pcr.SceneAddressCountryCode = "001";
            pcr.SceneAddressAdditionalNotes = "testing";
            pcr.NameCrew = "testing";
            pcr.CrewQuickSelect = "admin admin";
            pcr.StateId = "Stateid";
            pcr.RoleCrew = "Not Applicable";
            pcr.CertLevel = "Not Known";
            pcr.IncidentTimeOnset = "1234";
            pcr.IncidentTimeReceived = "1234";
            pcr.IncidentTimeNotified = "1234";
            pcr.IncidentTimeDispatch = "1234";
            pcr.IncidentTimeEnroute = "1234";
            pcr.IncidentTimeArrival = "1234";
            pcr.IncidentTimeAvailable = "1234";
            pcr.IncidentTimeAtBase = "1234";
            pcr.IncidentTimeCancelled = "1234";
            pcr.IncidentLocationemdPerformed = "No";
            pcr.IncidentLocationemdCardNo = "12345";
            pcr.IncidentLocationlocationZone = "Not Applicable";
            pcr.IncidentLocationlocationFacilityCode = "Not Applicable";
            pcr.IncidentDispatchcallSign = "sign";
            pcr.IncidentDispatchvehicleNumber = "Number";
            pcr.IncidentDispatchmodeToScene = "No Lights or Sirens";
            pcr.IncidentDispatchvehicleIncidentNum = "12345";
            pcr.IncidentDispatchserviceRequested = "Standby";
            pcr.IncidentDispatchrole = "Rescue";
            pcr.IncidentMileagescene = "5678";
            pcr.IncidentMileageservice = "5900";
            pcr.IncidentMileagestart = "6000";
            pcr.IncidentDelaysdispatchDelays = "Not Applicable";
            pcr.IncidentDelaysresponse = "Not Applicable";
            pcr.IncidentDelayssceneDelays = "Not Applicable";
            pcr.IncidentDelaystransport = "Not Applicable";
            pcr.IncidentDelaysturnAround = "Not Applicable";
            pcr.IncidentOthersOnSceneserviceOnScene = "Not Available";
            pcr.IncidentOthersOnSceneotherEMSAgencies = "Not Available";
            pcr.IncidentOthersOnSceneemsSystem = "123456";
            pcr.IncidentOthersOnSceneresponseDifferntial = "Not Available";

            pcr.PatientInfoDetailsfirstName = "Testing";
            pcr.PatientInfoDetailslastName = "Testing";
            pcr.PatientInfoDetailsmi = "Testing";
            pcr.PatientInfoDetailsphone = "1234569708";
            pcr.PatientInfoDetailsweight = "80";
            pcr.PatientInfoDetailsrace = "Asian";
            pcr.PatientInfoDetailsdob = "12121988";
            pcr.PatientInfoDetailsetnicity = "Not Known";
            pcr.PatientInfoDetailsgender = "Male";
            pcr.PatientInfoDetailsssn = "1234567980"; 
            pcr.PatientAddressDetailsgoogleLocSearch = "testing";
            pcr.PatientAddressDetailsstreetAddress = "testing";
            pcr.PatientAddressDetailsstreetAddress2 = "testing";
            pcr.PatientAddressDetailscity = "Denver";
            pcr.PatientAddressDetailsstate = "CO";
            pcr.PatientAddressDetailszip = "12345";           
            pcr.PatientAddressDetailscountryCode = "001";
            pcr.PatientAddressDetailsmunicipalCode = "12345";
            pcr.PatientAddressDetailsadditionalNotes = "testing";
            pcr.PatientPersonalDetailsdlNumber = "123456";
            pcr.PatientPersonalDetailsptPractionerName = "Testing";
            pcr.PatientPersonalDetailsdlState = "CO";
            pcr.PatientMedicalInfohistory = "Not Known";
            pcr.PatientMedicalInfohistoryObtained = "Not Available";
            pcr.PatientMedicalInfoallergiesMeds = "Not Available";
            pcr.PatientMedicalInfoemergencyForm = "Not Known";
            pcr.PatientMedicalInfoallergiesOthers = "Not Known";
            pcr.PatientMedicalInfoadvancedDirectives = "Not Known";
            pcr.PatientMedicalInfotriageColor = "Black";
            pcr.PatientMedicalInfotriageCategory = "Medical";
            pcr.PatientMedicalInfopregnant = "No";
            pcr.PatientMedicationsroute = "Not Available";
            pcr.PatientMedicationsdosage = "12345";
            pcr.PatientMedicationsunits = "GMS"; 
            pcr.PatientImmunizationstype = "Small Pox";
            pcr.PatientImmunizationsyear = "2015";



            //AssessmentPage
            pcr.AssessmentComplaintchiefComplaint = "12345";
            pcr.AssessmentComplaintpossibleInjury = "Yes";
            pcr.AssessmentImpressioncomplaintLocation = "Back";
            pcr.AssessmentImpressionorganSystem= "Skin";
            pcr.AssessmentImpressionprimarySymptoms = "Fever";
            pcr.AssessmentImpressionimpression = "Not Known";
            pcr.AssessmentImpressionotherSymptoms = "Bleeding";
            pcr.AssessmentImpressionsecondaryImpression = "Not Known";
            pcr.AssessmentImpressiondrugsAlcohol = "Not Known";

            pcr.AssessmentProtocolprotocols = "Airway";

            pcr.AssessmentVehicleCollisionvehicleCollision = "Not Known";
            pcr.AssessmentVehicleCollisionreportNumber = "Not Known";
            pcr.AssessmentVehicleCollisionptLocation = "Not Known";
            pcr.AssessmentVehicleCollisionrow = "2";
            pcr.AssessmentVehicleCollisionsafetyEquipment = "Not Applicable";
            pcr.AssessmentVehicleCollisionairbags = "Not Known";
            pcr.AssessmentVehicleCollisioninjuryIndicators = "Not Available";

            pcr.AssessmentTraumaheightOfFall = "4";
            pcr.AssessmentTraumacauseOfInjury = "Not Known";
            pcr.AssessmentTraumaintentOfInjury = "Not Known";

            pcr.AssessmentPriorAidGivenpriorAid = "Not Known";
            pcr.AssessmentPriorAidGiventreatedBy = "Not Known";
            pcr.AssessmentPriorAidGivenaidOutcome = "Not Known";
            // cardiacArrestDropdown.Sel
            //cardiacArrestTimeDropdown
            pcr.AssessmentCardiacArrestDD = "Not Known";
            pcr.AssessmentCardiacArrestTime = "Not Known";
            pcr.AssessmentCardiacArrestetiology = "Other";
            pcr.AssessmentCardiacArrestwitnessed = "Not Available";
            pcr.AssessmentCardiacArrestfirstRythm = "Other";
            pcr.AssessmentCardiacArrestcirculationReturn = "Not Known";
            pcr.AssessmentCardiacArrestresusitations = "Not Applicable";
            pcr.AssessmentCardiacArrestdiscontinueReason = "Not Available";
            pcr.AssessmentCardiacArrestdiscontinueTime = "1234";
            pcr.AssessmentCardiacArrestdiscontinueDate = "12121988";

            //Billing 
            pcr.BillingEmployerworkRelated = "Not Applicable";
            pcr.BillingEmployeremployer = "abc";
            pcr.BillingEmployergoogleLocSearch = "Colorado, United States";
            pcr.BillingEmployerstreetAddress = "test";
            pcr.BillingEmployerstreetAddress2 = "test";
            pcr.BillingEmployercity = "test";
            pcr.BillingEmployerstate = "AK";
            pcr.BillingEmployerzip="23123";
            pcr.BillingEmployermunicipalCode = "test";
            pcr.BillingEmployercountryCode = "test";
            pcr.BillingEmployeradditionalNotes = "test";
            pcr.BillingEmployerPhone = "2312321323";
            pcr.BillingEmployerpatientOccupation = "Not Applicable";
            pcr.BillingEmployeroccupationIndustry = "Not Applicable";

            pcr.BillingGuardianlastName = "abc";
            pcr.BillingGuardianfirstName = "abc";
            pcr.BillingGuardianmi = "abcmn";
            pcr.BillingGuardianphone = "12345678";
            pcr.BillingGuardianrelationship = "Not Applicable";
            pcr.BillingGuardiangoogleLocSearch = "Colorado, United States";
            pcr.BillingGuardianstreetAddress = "test";
            pcr.BillingGuardianstreetAddress2 = "test";
            pcr.BillingGuardiancity = "test";
            pcr.BillingGuardianstate = "AK";
            pcr.BillingGuardianzip = "3241";
            pcr.BillingGuardianmunicipalCode = "test";
            pcr.BillingGuardiancountryCode = "test";
            pcr.BillingGuardianadditionalNotes = "test";


            pcr.BillingInsurance = "abc";
            pcr.BillingInsurancebillingPriority = "Not Applicable";
            pcr.BillingInsurancegroup = "abc";
            pcr.BillingInsurancepolicy = "Not Applicable";
            pcr.BillingInsuranceprimaryLastName = "abc";
            pcr.BillingInsuranceprimaryFirstName = "abc";
            pcr.BillingInsuranceprimarymiddleName = "abc";
            pcr.BillingInsurancerelationshipToPatient = "Not Applicable";
            pcr.BillingInsurancestreet = "abc";
            pcr.BillingInsurancecity = "abc";
            pcr.BillingInsurancestate = "CO";
            pcr.BillingInsurancezip = "3241";

            pcr.BillingDetailsconditionCodes = "Not Applicable";
            pcr.BillingDetailspaymentMethod = "Not Applicable";
            pcr.BillingDetailsnecessityCertificate = "Not Applicable";
            pcr.BillingDetailspatientEmail = "abc@mailinator.com";

            pcr.TimelineMedicationDrop = "Alteplase";
            pcr.TimelineMedicationdosage = "test";
            pcr.TimelineMedicationunits = "GMS";
            pcr.TimelineMedicationroute = "Not Applicable";
            pcr.TimelineMedicationresponse = "Improved";
            pcr.TimelineMedicationcomplication = "Not Applicable";
            pcr.TimelineMedicationauthorization = "Not Applicable";
            pcr.TimelineMedicationauthPhysician = "test";
            pcr.TimelineMedicationisPriorAid = "Yes";
            pcr.TimelineMedicationnotes = "test";

            pcr.TimelineVitalsBP = "test";
            pcr.TimelineVitaldBP = "test";
            pcr.TimelineVitalbPDevice ="Arterial Line";
            pcr.TimelineVitalaVPU = "Not Known";
            pcr.TimelineVitalrespiration = "test";
            pcr.TimelineVitalpulseOx = "test";
            pcr.TimelineVitalpulseRhythm = "Not Applicable";
            pcr.TimelineVitalrespirationEffort = "Not Applicable";
            pcr.TimelineVitalpulseRate = "test";
            pcr.TimelineVitalgCSEyes = "test";
            pcr.TimelineVitalgCSVerbal = "test";
            pcr.TimelineVitalgCSMotor = "test";
            pcr.TimelineVitalgCSQaul = "Not Applicable";
            pcr.TimelineVitalgCSTotal = "test";


            pcr.TimelineProcedureDrop = "Chest Decompression";
            pcr.TimelineProcedureequipSize = "test";
            pcr.TimelineProceduresuccess = "Yes";
            pcr.TimelineProcedureattempts = "test";
            pcr.TimelineProcedureresponse = "Not Applicable";
            pcr.TimelineProcedurecomplication = "Not Applicable";
            pcr.TimelineProcedureauthorization = "Not Applicable";
            pcr.TimelineProcedureauthPhys = "test";
            pcr.TimelineProcedureprocedureisPriorAid = "Not Applicable";
            pcr.TimelineProcedureiVSuccess = "Not Applicable";
            pcr.TimelineProceduretubeConfirmation = "Not Applicable";
            pcr.TimelineProceduretubeDestination = "Not Applicable";
            pcr.TimelineProcedureprocedureNotes = "test";

            pcr.TimelineHeadNeckhead = "Not Available";
            pcr.TimelineHeadNeckmental = "Not Known";
            pcr.TimelineHeadNeckneuro = "Not Applicable";
            pcr.TimelineHeadNeckface = "Normal";
            pcr.TimelineHeadNeckleftEye = "Not Known";
            pcr.TimelineHeadNeckrightEye = "Not Applicable";
            pcr.TimelineHeadNeckDrop = "Not Done";
            pcr.TimelineHeadNeckskin = "Normal";


            pcr.TimelineChestAbschest = "Not Done";
            pcr.TimelineChestAbsheart = "Normal";
            pcr.TimelineChestAbsLeftUpper = "Not Applicable";
            pcr.TimelineChestAbsLeftLower = "Normal";
            pcr.TimelineChestAbsRightUpper = "Not Done";
            pcr.TimelineChestAbsRightLower = "Not Applicable";
            pcr.TimelineChestAbsGU = "Not Done";



            pcr.TimelineExtremitiesrightUpper = "Normal";
            pcr.TimelineExtremitiesrightLower = "Not Applicable";
            pcr.TimelineExtremitiesleftLower = "Not Done";
            pcr.TimelineExtremitiesleftUpper = "Normal";

            pcr.TimelineBackCervical = "Normal";
            pcr.TimelineBackThoracic = "Normal";
            pcr.TimelineBackLumbar = "Not Done";
            pcr.TimelineBackunspecified = "Not Applicable";
           
            pcr.TimelineNotesTextarea = "abc test ";


            pcr.OutcomeDestinationgoogleLocSearch = "Colorado, United States";
            pcr.OutcomeDestinationstreetAddress = "test";
            pcr.OutcomeDestinationstreetAddress2 = "test";
            pcr.OutcomeDestinationcity = "test";
            pcr.OutcomeDestinationstate = "AK";
            pcr.OutcomeDestinationzip = "3241";
            pcr.OutcomeDestinationmunicipalCode = "test";
            pcr.OutcomeDestinationcountryCode = "test";
            pcr.OutcomeDestinationadditionalNotes = "test";

            pcr.OutcomeTransportInfomci = "Yes";
            pcr.OutcomeTransportInfonumberofPatients = "None";
            pcr.OutcomeTransportInfoerDisposition = "Death";
            pcr.OutcomeTransportInfotoAmbulanceVia = "Not Applicable";
            pcr.OutcomeTransportInfohospitalDisposition = "Not Applicable";
            pcr.OutcomeTransportInfotransportPosition = "Not Applicable";
            pcr.OutcomeTransportInfofromAmbulanceVia = "Carry";


            pcr.OutcomeOtherReportdischargeNeuro = "Not Available";
            pcr.OutcomeOtherReporttransferToRecord = "test";
            pcr.OutcomeOtherReporttraumaRegistryID = "test";
            pcr.OutcomeOtherReportdestinationRecord = "test";
            pcr.OutcomeOtherReportfireReport = "test";
            pcr.OutcomeOtherReportdestinationZone = "Not Applicable";
            pcr.OutcomeOtherReportpatientIDTag = "test";
            pcr.OutcomeOtherReportvehicleLatGPS = "test";
            pcr.OutcomeOtherReportdestinationLatGPS = "test";
            pcr.OutcomeOtherReportvehicleLongGPS = "test";
            pcr.OutcomeOtherReportdestinationLongGPS = "test";

            pcr.NarrativeOtherReportreviewRequested = "Not Applicable";
            pcr.NarrativeOtherReportfluidExposureorInjuryType = "Not Applicable";
            pcr.NarrativeOtherReportpersonnelExposed = "Not Applicable";
            pcr.NarrativeOtherReportreqReportableCond = "Not Applicable";
            pcr.NarrativeOtherReportregistryCandidate = "Not Applicable";
            pcr.NarrativeOtherReportprotectiveEquipment = "Not Applicable";
            pcr.NarrativeOtherReportdisasters = "Not Known";
            pcr.NarrativeOtherReportnarrative = "test";

            pcr.AttachmentDetailsaddNoteTags = "Transfer Of Care";
            return pcr;
        }
    }
}
