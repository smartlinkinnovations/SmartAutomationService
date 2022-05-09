
        // Generated from: DrgMixSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgMixSearchOptions")]
        public partial class DrgMixSearchOptions : global::ProtoBuf.IExtensible
        {
        public DrgMixSearchOptions() {}
        

        private bool mIncludeComments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeComments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeComments
        {
        get { return mIncludeComments; }
        set { mIncludeComments = value; }
        }

        private bool mIncludeGroups
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeGroups", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeGroups
        {
        get { return mIncludeGroups; }
        set { mIncludeGroups = value; }
        }

        private bool mIncludeIngredients
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IncludeIngredients", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeIngredients
        {
        get { return mIncludeIngredients; }
        set { mIncludeIngredients = value; }
        }

        private bool mIncludePlans
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IncludePlans", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePlans
        {
        get { return mIncludePlans; }
        set { mIncludePlans = value; }
        }

        private bool mIncludeExternalLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IncludeExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeExternalLinks
        {
        get { return mIncludeExternalLinks; }
        set { mIncludeExternalLinks = value; }
        }

        private bool mIncludeAlerts
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IncludeAlerts", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAlerts
        {
        get { return mIncludeAlerts; }
        set { mIncludeAlerts = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        