
        // Generated from: PlnSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlnSearchOptions")]
        public partial class PlnSearchOptions : global::ProtoBuf.IExtensible
        {
        public PlnSearchOptions() {}
        

        private bool mIncludePhoneNumbers
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludePhoneNumbers", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePhoneNumbers
        {
        get { return mIncludePhoneNumbers; }
        set { mIncludePhoneNumbers = value; }
        }

        private bool mIncludeSubPlans
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeSubPlans", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeSubPlans
        {
        get { return mIncludeSubPlans; }
        set { mIncludeSubPlans = value; }
        }

        private bool mIncludePlanStoreLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IncludePlanStoreLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePlanStoreLinks
        {
        get { return mIncludePlanStoreLinks; }
        set { mIncludePlanStoreLinks = value; }
        }

        private bool mIncludePreferredProviders
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IncludePreferredProviders", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePreferredProviders
        {
        get { return mIncludePreferredProviders; }
        set { mIncludePreferredProviders = value; }
        }

        private bool mIncludePricingStrategyLookup
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IncludePricingStrategyLookup", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        