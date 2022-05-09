
        // Generated from: ReportingServiceQueueSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ReportingServiceQueueSearchOptions")]
        public partial class ReportingServiceQueueSearchOptions : global::ProtoBuf.IExtensible
        {
        public ReportingServiceQueueSearchOptions() {}
        

        private bool mFillerParameter
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"FillerParameter", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FillerParameter
        {
        get { return mFillerParameter; }
        set { mFillerParameter = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        