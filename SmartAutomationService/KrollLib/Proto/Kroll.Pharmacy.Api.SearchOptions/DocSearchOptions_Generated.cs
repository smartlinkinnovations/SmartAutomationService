
        // Generated from: DocSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DocSearchOptions")]
        public partial class DocSearchOptions : global::ProtoBuf.IExtensible
        {
        public DocSearchOptions() {}
        

        private bool mIncludeAddress
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeAddress", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAddress
        {
        get { return mIncludeAddress; }
        set { mIncludeAddress = value; }
        }

        private bool mIncludeComments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeComments", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IncludeGroups", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeGroups
        {
        get { return mIncludeGroups; }
        set { mIncludeGroups = value; }
        }

        private bool mIncludePhone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IncludePhone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePhone
        {
        get { return mIncludePhone; }
        set { mIncludePhone = value; }
        }

        private bool mIncludeOutboundCommunications
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IncludeOutboundCommunications", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeOutboundCommunications
        {
        get { return mIncludeOutboundCommunications; }
        set { mIncludeOutboundCommunications = value; }
        }

        private bool mIncludeExternalLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IncludeExternalLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeExternalLinks
        {
        get { return mIncludeExternalLinks; }
        set { mIncludeExternalLinks = value; }
        }

        private bool mIncludeLicences
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IncludeLicences", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeLicences
        {
        get { return mIncludeLicences; }
        set { mIncludeLicences = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        