
        // Generated from: ARGLCategory.proto
        // Note: requires additional types generated from: ARGLType_Enum.proto
        // Note: requires additional types generated from: ARTaxType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ARGLCategory")]
        public partial class ARGLCategory : global::ProtoBuf.IExtensible
        {
        public ARGLCategory() {}
        

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

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.ARGLType mGLType
            = Kroll.Pharmacy.Api.Data.ARGLType.ARGLType_Charge;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"GLType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ARGLType.ARGLType_Charge)]
        
        public Kroll.Pharmacy.Api.Data.ARGLType GLType
        {
        get { return mGLType; }
        set { mGLType = value; }
        }

        private string mGLAccountNumber
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"GLAccountNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string GLAccountNumber
        {
        get { return mGLAccountNumber; }
        set { mGLAccountNumber = value; }
        }

        private Kroll.Pharmacy.Api.Data.ARTaxType mTaxType
            = Kroll.Pharmacy.Api.Data.ARTaxType.ARTaxType_None;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"TaxType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ARTaxType.ARTaxType_None)]
        
        public Kroll.Pharmacy.Api.Data.ARTaxType TaxType
        {
        get { return mTaxType; }
        set { mTaxType = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        