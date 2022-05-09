
        // Generated from: SearchReportingServiceQueueResponse.proto
        // Note: requires additional types generated from: ReportingServiceQueue.proto
            namespace Kroll.Pharmacy.Api.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SearchReportingServiceQueueResponse")]
        public partial class SearchReportingServiceQueueResponse : global::ProtoBuf.IExtensible
        {
        public SearchReportingServiceQueueResponse() {}
        
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReportingServiceQueue> mSearchResults = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReportingServiceQueue>();
        [global::ProtoBuf.ProtoMember(1, Name=@"SearchResults", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ReportingServiceQueue> SearchResults
        {
        get { return mSearchResults; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        