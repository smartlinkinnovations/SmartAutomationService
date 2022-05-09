
        // Generated from: PatPrcGrpSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatPrcGrpSearchOptions")]
        public partial class PatPrcGrpSearchOptions : global::ProtoBuf.IExtensible
        {
        public PatPrcGrpSearchOptions() {}
        

        private bool mIncludePricingStrategyLookup
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludePricingStrategyLookup", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePricingStrategyLookup
        {
        get { return mIncludePricingStrategyLookup; }
        set { mIncludePricingStrategyLookup = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        