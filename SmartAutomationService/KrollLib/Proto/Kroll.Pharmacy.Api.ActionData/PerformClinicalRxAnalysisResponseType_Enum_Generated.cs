
        // Generated from: PerformClinicalRxAnalysisResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        public enum PerformClinicalRxAnalysisResponseType
        {
        PerformClinicalRxAnalysisResponseType_Successful = 0
            ,
        PerformClinicalRxAnalysisResponseType_UnknownError = 1
            ,
        PerformClinicalRxAnalysisResponseType_NoDrugToAnalyzeSpecified = 2
            ,
        PerformClinicalRxAnalysisResponseType_InvalidRxNum = 3
            ,
        PerformClinicalRxAnalysisResponseType_InvalidPatId = 4
            ,
        PerformClinicalRxAnalysisResponseType_InvalidDontCheckInteractionsOlderThanDays = 5
            ,
        PerformClinicalRxAnalysisResponseType_RxNumNotFound = 6
            ,
        PerformClinicalRxAnalysisResponseType_PatIdNotFound = 7
            ,
        PerformClinicalRxAnalysisResponseType_PatIdCannotBeSpecifiedWhenRxNumSpecified = 8
            ,
        PerformClinicalRxAnalysisResponseType_RxNumMustBeSpecified = 9
            ,
        PerformClinicalRxAnalysisResponseType_RxNumOrPatIdMustBeSpecified = 10
            ,
        PerformClinicalRxAnalysisResponseType_CannotSpecifyDrugsToAnalyzeWhenRxLookupSelected = 11
            ,
        PerformClinicalRxAnalysisResponseType_CannotSpecifyDrugsToAnalyzeAgainstWhenProfileLookupSelected = 12
            ,
        PerformClinicalRxAnalysisResponseType_CannotSpecifyPatientAllergiesWhenPatientLookupSelected = 13
            ,
        PerformClinicalRxAnalysisResponseType_CannotSpecifyPatientConditionsWhenPatientLookupSelected = 14
            ,
        PerformClinicalRxAnalysisResponseType_InvalidDIN = 15
        }
    
            }
        