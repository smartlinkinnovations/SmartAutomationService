
        // Generated from: NHSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NHSearchOptions")]
        public partial class NHSearchOptions : global::ProtoBuf.IExtensible
        {
        public NHSearchOptions() {}
        

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

        private bool mIncludeCycles
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeCycles", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeCycles
        {
        get { return mIncludeCycles; }
        set { mIncludeCycles = value; }
        }

        private bool mIncludeWards
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IncludeWards", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeWards
        {
        get { return mIncludeWards; }
        set { mIncludeWards = value; }
        }

        private bool mIncludeNHOrders
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IncludeNHOrders", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeNHOrders
        {
        get { return mIncludeNHOrders; }
        set { mIncludeNHOrders = value; }
        }

        private bool mIncludePhones
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IncludePhones", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePhones
        {
        get { return mIncludePhones; }
        set { mIncludePhones = value; }
        }

        private bool mIncludeNHSort
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IncludeNHSort", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeNHSort
        {
        get { return mIncludeNHSort; }
        set { mIncludeNHSort = value; }
        }

        private bool mIncludeNHMedTypeSort
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"IncludeNHMedTypeSort", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeNHMedTypeSort
        {
        get { return mIncludeNHMedTypeSort; }
        set { mIncludeNHMedTypeSort = value; }
        }

        private bool mIncludeDrgAlertLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"IncludeDrgAlertLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeDrgAlertLinks
        {
        get { return mIncludeDrgAlertLinks; }
        set { mIncludeDrgAlertLinks = value; }
        }

        private bool mIncludeWardCycleLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IncludeWardCycleLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeWardCycleLinks
        {
        get { return mIncludeWardCycleLinks; }
        set { mIncludeWardCycleLinks = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        