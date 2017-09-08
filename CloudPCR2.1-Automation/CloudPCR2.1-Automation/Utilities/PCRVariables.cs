using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloudPCR2._1_Automation.Utilities
{
    public class PCRVariables
    {
        public string IncidentNumber { get; set; }
        public string DispositionOutcome { get; set; }
        public string ResponseUrgency { get; set; }
        public string TypeOfLocation { get; set; }
        public string NatureOfIncident { get; set; }
        public string CmsLevel { get; set; }
        public string SceneAddressGoogleLocSearch { get; set; }
        public string SceneAddressStreetAddress { get; set; }
        public string SceneAddressstreetAddress2 { get; set; }
        public string SceneAddressCity { get; set; }
        public string SceneAddressState { get; set; }
        public string SceneAddressZip { get; set; }
        public string SceneAddressMunicipalCode { get; set; }
        public string SceneAddressCountryCode { get; set; }
        public string SceneAddressAdditionalNotes { get; set; }
        public string NameCrew { get; set; }
        public string CrewQuickSelect { get; set; }
        public string StateId { get; set; }
        public string RoleCrew { get; set; }
        public string CertLevel { get; set; }
        public string IncidentLocationemdPerformed { get; set; }
        public string IncidentLocationemdCardNo { get; set; }
        public string IncidentLocationlocationZone { get; set; }
        public string IncidentLocationlocationFacilityCode { get; set; }
        public string IncidentTimeOnset { get; set; }
        public string IncidentTimeReceived { get; set; }
        public string IncidentTimeNotified { get; set; }
        public string IncidentTimeDispatch { get; set; }
        public string IncidentTimeEnroute { get; set; }
        public string IncidentTimeArrival { get; set; }
        public string IncidentTimeAvailable { get; set; }
        public string IncidentTimeAtBase { get; set; }
        public string IncidentTimeCancelled { get; set; }
        public string IncidentDispatchcallSign { get; set; }
        public string IncidentDispatchvehicleNumber { get; set; }
        public string IncidentDispatchmodeToScene { get; set; }
        public string IncidentDispatchvehicleIncidentNum { get; set; }
        public string IncidentDispatchserviceRequested { get; set; }
        public string IncidentDispatchrole { get; set; }
        public string IncidentMileagestart { get; set; }
        public string IncidentMileagescene { get; set; }
        public string IncidentMileageservice { get; set; }
        public string IncidentDelayscheckboxValue { get; set; }
        public string IncidentDelaysdispatchDelays { get; set; }
        public string IncidentDelaysresponse { get; set; }
        public string IncidentDelayssceneDelays { get; set; }
        public string IncidentDelaystransport { get; set; }
        public string IncidentDelaysturnAround { get; set; } 
        public string IncidentOthersOnSceneserviceOnScene { get; set; }
        public string IncidentOthersOnSceneotherEMSAgencies { get; set; }
        public string IncidentOthersOnSceneemsSystem { get; set; }
        public string IncidentOthersOnSceneresponseDifferntial { get; set; }

        //patients
        public string PatientInfoDetailsfirstName { get; set; }
        public string PatientInfoDetailslastName { get; set; }
        public string PatientInfoDetailsmi { get; set; }
        public string PatientInfoDetailsphone { get; set; }
        public string PatientInfoDetailsweight { get; set; }
        public string PatientInfoDetailsrace { get; set; }
        public string PatientInfoDetailsdob { get; set; }
        public string PatientInfoDetailsetnicity { get; set; }
        public string PatientInfoDetailsgender { get; set; }
        public string PatientInfoDetailsssn { get; set; } 
        public string PatientAddressDetailsgoogleLocSearch { get; set; }
        public string PatientAddressDetailsstreetAddress { get; set; }
        public string PatientAddressDetailsstreetAddress2 { get; set; }
        public string PatientAddressDetailscity { get; set; }
        public string PatientAddressDetailsstate { get; set; }
        public string PatientAddressDetailszip { get; set; }
        public string PatientAddressDetailsmunicipalCode { get; set; }
        public string PatientAddressDetailscountryCode { get; set; }
        public string PatientAddressDetailsadditionalNotes { get; set; }
        public string PatientPersonalDetailsdlNumber { get; set; }
        public string PatientPersonalDetailsptPractionerName { get; set; }
        public string PatientPersonalDetailsdlState { get; set; }
        public string PatientMedicalInfohistory { get; set; }
        public string PatientMedicalInfohistoryObtained { get; set; }
        public string PatientMedicalInfoallergiesMeds { get; set; }
        public string PatientMedicalInfoemergencyForm { get; set; }
        public string PatientMedicalInfoallergiesOthers { get; set; }
        public string PatientMedicalInfoadvancedDirectives { get; set; }
        public string PatientMedicalInfotriageColor { get; set; }
        public string PatientMedicalInfotriageCategory { get; set; }
        public string PatientMedicalInfopregnant { get; set; }
        public string PatientMedicationsroute { get; set; } 
        public string PatientMedicationsdosage { get; set; }
        public string PatientMedicationsunits { get; set; } 
        public string PatientImmunizationstype { get; set; }
        public string PatientImmunizationsyear { get; set; } 


        //Assesment
        public string AssessmentComplaintchiefComplaint { get; set; }
        public string AssessmentComplaintpossibleInjury { get; set; }
        public string AssessmentImpressioncomplaintLocation { get; set; }
        public string AssessmentImpressionorganSystem { get; set; }
        public string AssessmentImpressionprimarySymptoms { get; set; }
        public string AssessmentImpressionimpression { get; set; }
        public string AssessmentImpressionotherSymptoms { get; set; }
        public string AssessmentImpressionsecondaryImpression { get; set; }
        public string AssessmentImpressiondrugsAlcohol { get; set; }
        public string AssessmentProtocolprotocols { get; set; }
       // public string AssessmentVehicleCollisioncheckboxValue { get; set; }
        public string AssessmentVehicleCollisionvehicleCollision { get; set; }
        public string AssessmentVehicleCollisionreportNumber { get; set; }
        public string AssessmentVehicleCollisionptLocation { get; set; }
        public string AssessmentVehicleCollisionrow { get; set; }
        public string AssessmentVehicleCollisionsafetyEquipment { get; set; }
        public string AssessmentVehicleCollisionairbags { get; set; }
        public string AssessmentVehicleCollisioninjuryIndicators { get; set; }
       // public string AssessmentTraumacheckboxValue { get; set; }
        public string AssessmentTraumaheightOfFall { get; set; }
        public string AssessmentTraumacauseOfInjury { get; set; }
        public string AssessmentTraumaintentOfInjury { get; set; }
      //  public string AssessmentPriorAidGivencheckbox { get; set; }
        public string AssessmentPriorAidGivenpriorAid { get; set; }
        public string AssessmentPriorAidGiventreatedBy { get; set; }
        public string AssessmentPriorAidGivenaidOutcome { get; set; }
        public string AssessmentCardiacArrestetiology { get; set; }
        public string AssessmentCardiacArrestDD { get; set; }
        public string AssessmentCardiacArrestTime { get; set; }
        public string AssessmentCardiacArrestwitnessed { get; set; }
        public string AssessmentCardiacArrestfirstRythm { get; set; }
        public string AssessmentCardiacArrestcirculationReturn { get; set; }
        public string AssessmentCardiacArrestresusitations { get; set; }
        public string AssessmentCardiacArrestdiscontinueReason { get; set; }
        public string AssessmentCardiacArrestdiscontinueTime { get; set; }
        public string AssessmentCardiacArrestdiscontinueDate { get; set; }


        //Billing 
        public string BillingEmployerworkRelated { get; set; }
        public string BillingEmployeremployer { get; set; }
        public string BillingEmployerAddress { get; set; }
        public string BillingEmployergoogleLocSearch { get; set; }
        public string BillingEmployerstreetAddress { get; set; }
        public string BillingEmployerstreetAddress2 { get; set; }
        public string BillingEmployercity { get; set; }
        public string BillingEmployerstate { get; set; }
        public string BillingEmployerzip { get; set; }
        public string BillingEmployermunicipalCode { get; set; }
        public string BillingEmployercountryCode { get; set; }
        public string BillingEmployeradditionalNotes { get; set; }
        public string BillingEmployerPhone { get; set; }
        public string BillingEmployerpatientOccupation { get; set; }
        public string BillingEmployeroccupationIndustry { get; set; }
        //public string BillingEmployerclose { get; set; }


        //public string BillingGuardiancheckboxValue { get; set; }
        public string BillingGuardianlastName { get; set; }
        public string BillingGuardianfirstName { get; set; }
        public string BillingGuardianmi { get; set; }
        public string BillingGuardianphone { get; set; }
        public string BillingGuardianrelationship { get; set; }
        public string BillingGuardianAddress { get; set; }
        public string BillingGuardiangoogleLocSearch { get; set; }
        public string BillingGuardianstreetAddress { get; set; }
        public string BillingGuardianstreetAddress2 { get; set; }
        public string BillingGuardiancity { get; set; }
        public string BillingGuardianstate { get; set; }
        public string BillingGuardianzip { get; set; }
        public string BillingGuardianmunicipalCode { get; set; }
        public string BillingGuardiancountryCode { get; set; }
        public string BillingGuardianadditionalNotes { get; set; }


        public string BillingInsurancenew { get; set; }
        public string BillingInsurancebillingPriority { get; set; }
        public string BillingInsurance { get; set; }
        public string BillingInsurancegroup { get; set; }
        public string BillingInsurancepolicy { get; set; }
        public string BillingInsuranceprimaryLastName { get; set; }
        public string BillingInsuranceprimaryFirstName { get; set; }
        public string BillingInsuranceprimarymiddleName { get; set; }
        public string BillingInsurancerelationshipToPatient { get; set; }
        public string BillingInsurancestreet { get; set; }
        public string BillingInsurancecity { get; set; }
        public string BillingInsurancestate { get; set; }
        public string BillingInsurancezip { get; set; }
        //public string BillingInsuranceclose { get; set; }

        public string BillingDetailsconditionCodes { get; set; }
        public string BillingDetailspaymentMethod { get; set; }
        public string BillingDetailsnecessityCertificate { get; set; }
        public string BillingDetailspatientEmail { get; set; }


        //Timeline Objects
       // public string TimelineMedicationButtonLink { get; set; }
        public string TimelineMedicationDrop { get; set; }
        public string TimelineMedicationdosage { get; set; }
        public string TimelineMedicationunits { get; set; }
        public string TimelineMedicationroute { get; set; }
        public string TimelineMedicationresponse { get; set; }
        public string TimelineMedicationcomplication { get; set; }
        public string TimelineMedicationauthorization { get; set; }
        public string TimelineMedicationauthPhysician { get; set; }
        public string TimelineMedicationisPriorAid { get; set; }
        public string TimelineMedicationnotes { get; set; }
        //public string TimelineMedicationclose { get; set; }


        //public string TimelineVitalButtonLink { get; set; }
        public string TimelineVitalsBP { get; set; }
        public string TimelineVitaldBP { get; set; }
        public string TimelineVitalbPDevice { get; set; }
        public string TimelineVitalaVPU { get; set; }
        public string TimelineVitalrespiration { get; set; }
        public string TimelineVitalpulseOx { get; set; }
        public string TimelineVitalpulseRhythm { get; set; }
        public string TimelineVitalrespirationEffort { get; set; }
        public string TimelineVitalpulseRate { get; set; }
        public string TimelineVitalgCSEyes { get; set; }
        public string TimelineVitalgCSVerbal { get; set; }
        public string TimelineVitalgCSMotor { get; set; }
        public string TimelineVitalgCSQaul { get; set; }
        public string TimelineVitalgCSTotal { get; set; }
        //public string TimelineVitalclose { get; set; }


        //public string TimelineProcedureButtonLink { get; set; }
        public string TimelineProcedureDrop { get; set; }
        public string TimelineProcedureequipSize { get; set; }
        public string TimelineProceduresuccess { get; set; }
        public string TimelineProcedureattempts { get; set; }
        public string TimelineProcedureresponse { get; set; }
        public string TimelineProcedurecomplication { get; set; }
        public string TimelineProcedureauthorization { get; set; }
        public string TimelineProcedureauthPhys { get; set; }
        public string TimelineProcedureprocedureisPriorAid { get; set; }
        public string TimelineProcedureiVSuccess { get; set; }
        public string TimelineProceduretubeConfirmation { get; set; }
        public string TimelineProceduretubeDestination { get; set; }
        public string TimelineProcedureprocedureNotes { get; set; }
       // public string TimelineProcedureclose { get; set; }

        //public string TimelineExamButton { get; set; }

        public string TimelineHeadNeckhead { get; set; }
        public string TimelineHeadNeckmental { get; set; }
        public string TimelineHeadNeckneuro { get; set; }
        public string TimelineHeadNeckface { get; set; }
        public string TimelineHeadNeckleftEye { get; set; }
        public string TimelineHeadNeckrightEye { get; set; }
        public string TimelineHeadNeckDrop { get; set; }
        public string TimelineHeadNeckskin { get; set; }

       // public string TimelineChestAbsexamsTabs { get; set; }
        public string TimelineChestAbschest { get; set; }
        public string TimelineChestAbsheart { get; set; }
        public string TimelineChestAbsLeftUpper { get; set; }
        public string TimelineChestAbsLeftLower { get; set; }
        public string TimelineChestAbsRightUpper { get; set; }
        public string TimelineChestAbsRightLower { get; set; }
        public string TimelineChestAbsGU { get; set; }

        //public string TimelineExtremitiesexamsTabs { get; set; }
        public string TimelineExtremitiesrightUpper { get; set; }
        public string TimelineExtremitiesrightLower { get; set; }
        public string TimelineExtremitiesleftLower { get; set; }
        public string TimelineExtremitiesleftUpper { get; set; }


        //public string TimelineBackexamsTabs { get; set; }
        public string TimelineBackCervical { get; set; }
        public string TimelineBackThoracic { get; set; }
        public string TimelineBackLumbar { get; set; }
        public string TimelineBackunspecified { get; set; }

       // public string TimelineNotesexamsTabs { get; set; }
        public string TimelineNotesTextarea { get; set; }
        //public string TimelineNotesclose { get; set; }

        //Outcome
     
        //public string OutcomeDestinationAddress { get; set; }
        public string OutcomeDestinationgoogleLocSearch { get; set; }
        public string OutcomeDestinationstreetAddress { get; set; }
        public string OutcomeDestinationstreetAddress2 { get; set; }
        public string OutcomeDestinationcity { get; set; }
        public string OutcomeDestinationstate { get; set; }
        public string OutcomeDestinationzip { get; set; }
        public string OutcomeDestinationmunicipalCode { get; set; }
        public string OutcomeDestinationcountryCode { get; set; }
        public string OutcomeDestinationadditionalNotes { get; set; }
       // public string OutcomeDestinationclose { get; set; }

        public string OutcomeTransportInfomci { get; set; }
        public string OutcomeTransportInfonumberofPatients { get; set; }
        public string OutcomeTransportInfoerDisposition { get; set; }
        public string OutcomeTransportInfotoAmbulanceVia { get; set; }
        public string OutcomeTransportInfohospitalDisposition { get; set; }
        public string OutcomeTransportInfotransportPosition { get; set; }
        public string OutcomeTransportInfofromAmbulanceVia { get; set; }

        public string OutcomeOtherReportdischargeNeuro { get; set; }
        public string OutcomeOtherReporttransferToRecord { get; set; }
        public string OutcomeOtherReporttraumaRegistryID { get; set; }
        public string OutcomeOtherReportdestinationRecord { get; set; }
        public string OutcomeOtherReportfireReport { get; set; }
        public string OutcomeOtherReportdestinationZone { get; set; }
        public string OutcomeOtherReportpatientIDTag { get; set; }
        public string OutcomeOtherReportvehicleLatGPS { get; set; }
        public string OutcomeOtherReportdestinationLatGPS { get; set; }
        public string OutcomeOtherReportvehicleLongGPS { get; set; }
        public string OutcomeOtherReportdestinationLongGPS { get; set; }


        //NarrativePageObjects
        public string NarrativeOtherReportreviewRequested { get; set; }
        public string NarrativeOtherReportfluidExposureorInjuryType { get; set; }
        public string NarrativeOtherReportpersonnelExposed { get; set; }
        public string NarrativeOtherReportreqReportableCond { get; set; }
        public string NarrativeOtherReportregistryCandidate { get; set; }
        public string NarrativeOtherReportprotectiveEquipment { get; set; }
        public string NarrativeOtherReportdisasters { get; set; }
        public string NarrativeOtherReportnarrative { get; set; }

        //AttachmentsFormsPageObjects

        public string AttachmentDetailsaddNoteTags { get; set; }

        //SignaturesPageObjects
        public string SignaturesDetailssign { get; set; }
        public string SignaturesDetailsname { get; set; }
        public string SignaturesDetailsaccept { get; set; }

        //NotesPageObjects
        public string NotesaddNoteBut { get; set; }
        public string NotesaddNoteText { get; set; }
        public string NotesaddNoteTag { get; set; }
        public string NotessaveButton { get; set; }



    }
}
