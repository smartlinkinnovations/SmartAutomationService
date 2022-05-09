
        // Generated from: AdtSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdtSearchOptions")]
        public partial class AdtSearchOptions : global::ProtoBuf.IExtensible
        {
        public AdtSearchOptions() {}
        

        private bool mIncludeAdtPat
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeAdtPat", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAdtPat
        {
        get { return mIncludeAdtPat; }
        set { mIncludeAdtPat = value; }
        }

        private bool mIncludeAdtPatAdd
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IncludeAdtPatAdd", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAdtPatAdd
        {
        get { return mIncludeAdtPatAdd; }
        set { mIncludeAdtPatAdd = value; }
        }

        private bool mIncludeAdtPatAlg
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"IncludeAdtPatAlg", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAdtPatAlg
        {
        get { return mIncludeAdtPatAlg; }
        set { mIncludeAdtPatAlg = value; }
        }

        private bool mIncludeAdtPatCnd
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"IncludeAdtPatCnd", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAdtPatCnd
        {
        get { return mIncludeAdtPatCnd; }
        set { mIncludeAdtPatCnd = value; }
        }

        private bool mIncludeAdtPatPhone
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"IncludeAdtPatPhone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAdtPatPhone
        {
        get { return mIncludeAdtPatPhone; }
        set { mIncludeAdtPatPhone = value; }
        }

        private bool mIncludeAdtPatPln
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"IncludeAdtPatPln", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeAdtPatPln
        {
        get { return mIncludeAdtPatPln; }
        set { mIncludeAdtPatPln = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        