
        // Generated from: ProcessReportingServiceQueueItemResponseData.proto
        // Note: requires additional types generated from: ProcessReportingServiceQueueItemResponseType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProcessReportingServiceQueueItemResponseData")]
        public partial class ProcessReportingServiceQueueItemResponseData : global::ProtoBuf.IExtensible
        {
        public ProcessReportingServiceQueueItemResponseData() {}
        

        private bool mIsSuccessful
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IsSuccessful", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsSuccessful
        {
        get { return mIsSuccessful; }
        set { mIsSuccessful = value; }
        }

        private Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemResponseType mResponseType
            = Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemResponseType.ProcessReportingServiceQueueItemResponseType_Successful;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ResponseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemResponseType.ProcessReportingServiceQueueItemResponseType_Successful)]
        
        public Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemResponseType ResponseType
        {
        get { return mResponseType; }
        set { mResponseType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        