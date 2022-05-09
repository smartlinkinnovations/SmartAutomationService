
        // Generated from: OCMQueueStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        public enum OCMQueueStatus
        {
        OCMQueueStatus_Unknown = 0
            ,
        OCMQueueStatus_WaitingForActionDate = 1
            ,
        OCMQueueStatus_Processing = 2
            ,
        OCMQueueStatus_Queued = 3
            ,
        OCMQueueStatus_CompletedSuccessfully = 4
            ,
        OCMQueueStatus_CompletedWithErrors = 5
            ,
        OCMQueueStatus_Cancelled = 6
            ,
        OCMQueueStatus_ContactNotEnabledForOcm = 7
            ,
        OCMQueueStatus_ProcessingFailedWithErrorsDoNotRetry = 8
            ,
        OCMQueueStatus_MessageTypeNotEnabledForOcm = 9
            ,
        OCMQueueStatus_ProcessingFailedWithErrorsRetryLater = 10
            ,
        OCMQueueStatus_WaitingForKWinUserAction = 11
        }
    
            }
        