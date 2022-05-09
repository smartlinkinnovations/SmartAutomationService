
        // Generated from: ProcessReportingServiceQueueItemRequest.proto
        // Note: requires additional types generated from: ProcessReportingServiceQueueItemRequestData.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ProcessReportingServiceQueueItemRequest")]
        public partial class ProcessReportingServiceQueueItemRequest : global::ProtoBuf.IExtensible
        {
        public ProcessReportingServiceQueueItemRequest() {}
        

        private Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemRequestData mRequestData
            = null;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"RequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.ActionData.ProcessReportingServiceQueueItemRequestData RequestData
        {
        get { return mRequestData; }
        set { mRequestData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        