
        // Generated from: OCMCommType.proto
        // Note: requires additional types generated from: OCMCommTypes_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCMCommType")]
        public partial class OCMCommType : global::ProtoBuf.IExtensible
        {
        public OCMCommType() {}
        

        private int mId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Id
        {
        get { return mId; }
        set { mId = value; }
        }

        private Kroll.Pharmacy.Api.Data.OCMCommTypes mCommType
            = Kroll.Pharmacy.Api.Data.OCMCommTypes.OCMCommTypes_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CommType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.OCMCommTypes.OCMCommTypes_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.OCMCommTypes CommType
        {
        get { return mCommType; }
        set { mCommType = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private bool mAvailableForPat
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"AvailableForPat", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AvailableForPat
        {
        get { return mAvailableForPat; }
        set { mAvailableForPat = value; }
        }

        private bool mAvailableForDoc
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AvailableForDoc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AvailableForDoc
        {
        get { return mAvailableForDoc; }
        set { mAvailableForDoc = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        