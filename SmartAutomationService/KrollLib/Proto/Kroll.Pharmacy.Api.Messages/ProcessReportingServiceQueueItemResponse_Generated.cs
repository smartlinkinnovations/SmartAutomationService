
        // Generated from: ProcessReportingServiceQueueItemResponse.proto
        // Note: requires additional types generated from: ProcessReportingServiceQueueItemResponseData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProcessReportingServiceQueueItemResponse")]
        public partial class ProcessReportingServiceQueueItemResponse : global::ProtoBuf.IExtensible
        {
        public ProcessReportingServiceQueueItemResponse() {}
        

        private Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemResponseData mResponseData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ResponseData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemResponseData ResponseData
        {
        get { return mResponseData; }
        set { mResponseData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        