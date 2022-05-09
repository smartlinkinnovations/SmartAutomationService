
        // Generated from: ReportingServiceQueueSearchCriteria.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReportingServiceQueueSearchCriteria")]
        public partial class ReportingServiceQueueSearchCriteria : global::ProtoBuf.IExtensible
        {
        public ReportingServiceQueueSearchCriteria() {}
        

        private int mReportingServiceHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"ReportingServiceHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReportingServiceHostId
        {
        get { return mReportingServiceHostId; }
        set { mReportingServiceHostId = value; }
        }

        private int mMaxQueueItems
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MaxQueueItems", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MaxQueueItems
        {
        get { return mMaxQueueItems; }
        set { mMaxQueueItems = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        