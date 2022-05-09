
        // Generated from: ProcessReportingServiceQueueItemRequestData.proto
        // Note: requires additional types generated from: ReportingServiceQueueDeferReason_Enum.proto
        // Note: requires additional types generated from: ProcessReportingServiceQueueItemActionType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProcessReportingServiceQueueItemRequestData")]
        public partial class ProcessReportingServiceQueueItemRequestData : global::ProtoBuf.IExtensible
        {
        public ProcessReportingServiceQueueItemRequestData() {}
        

        private int mReportingServiceQueueId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ReportingServiceQueueId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReportingServiceQueueId
        {
        get { return mReportingServiceQueueId; }
        set { mReportingServiceQueueId = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemActionType mActionType
            = Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemActionType.ProcessReportingServiceQueueItemActionType_RemoveItemFromQueue;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ActionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemActionType.ProcessReportingServiceQueueItemActionType_RemoveItemFromQueue)]
        
        public Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemActionType ActionType
        {
        get { return mActionType; }
        set { mActionType = value; }
        }

        private Kroll.Pharmacy.Api.Data.ReportingServiceQueueDeferReason mDeferReason
            = Kroll.Pharmacy.Api.Data.ReportingServiceQueueDeferReason.ReportingServiceQueueDeferReason_None;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DeferReason", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ReportingServiceQueueDeferReason.ReportingServiceQueueDeferReason_None)]
        
        public Kroll.Pharmacy.Api.Data.ReportingServiceQueueDeferReason DeferReason
        {
        get { return mDeferReason; }
        set { mDeferReason = value; }
        }

        private double mDeferUntil
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DeferUntil", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeferUntil
        {
        get { return mDeferUntil; }
        set { mDeferUntil = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        