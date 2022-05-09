
        // Generated from: PackagerBatchSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PackagerBatchSearchOptions")]
        public partial class PackagerBatchSearchOptions : global::ProtoBuf.IExtensible
        {
        public PackagerBatchSearchOptions() {}
        

        private bool mIncludePackagerBatchRxs
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludePackagerBatchRxs", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePackagerBatchRxs
        {
        get { return mIncludePackagerBatchRxs; }
        set { mIncludePackagerBatchRxs = value; }
        }

        private bool mIncludePackagerBatchRxDoses
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludePackagerBatchRxDoses", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePackagerBatchRxDoses
        {
        get { return mIncludePackagerBatchRxDoses; }
        set { mIncludePackagerBatchRxDoses = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        