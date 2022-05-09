
        // Generated from: ERxSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ERxSearchOptions")]
        public partial class ERxSearchOptions : global::ProtoBuf.IExtensible
        {
        public ERxSearchOptions() {}
        

        private bool mIncludeOrders
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeOrders", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeOrders
        {
        get { return mIncludeOrders; }
        set { mIncludeOrders = value; }
        }

        private bool mIncludeOrderIndications
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeOrderIndications", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeOrderIndications
        {
        get { return mIncludeOrderIndications; }
        set { mIncludeOrderIndications = value; }
        }

        private bool mIncludeOrderPasstimes
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IncludeOrderPasstimes", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeOrderPasstimes
        {
        get { return mIncludeOrderPasstimes; }
        set { mIncludeOrderPasstimes = value; }
        }

        private bool mIncludeDispenses
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IncludeDispenses", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeDispenses
        {
        get { return mIncludeDispenses; }
        set { mIncludeDispenses = value; }
        }

        private bool mIncludeDispensePasstimes
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IncludeDispensePasstimes", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeDispensePasstimes
        {
        get { return mIncludeDispensePasstimes; }
        set { mIncludeDispensePasstimes = value; }
        }

        private bool mIncludeAdministrations
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IncludeAdministrations", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAdministrations
        {
        get { return mIncludeAdministrations; }
        set { mIncludeAdministrations = value; }
        }

        private bool mIncludeTransmissions
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"IncludeTransmissions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeTransmissions
        {
        get { return mIncludeTransmissions; }
        set { mIncludeTransmissions = value; }
        }

        private bool mIncludeRxLinks
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"IncludeRxLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeRxLinks
        {
        get { return mIncludeRxLinks; }
        set { mIncludeRxLinks = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        