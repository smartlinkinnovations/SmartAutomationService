
        // Generated from: SubmitAdtRequestData.proto
        // Note: requires additional types generated from: Adt.proto
        // Note: requires additional types generated from: AdtPat.proto
        // Note: requires additional types generated from: AdtType_Enum.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SubmitAdtRequestData")]
        public partial class SubmitAdtRequestData : global::ProtoBuf.IExtensible
        {
        public SubmitAdtRequestData() {}
        

        private Kroll.Pharmacy.Api.Data.AdtType mAdtType
            = Kroll.Pharmacy.Api.Data.AdtType.AdtType_Unknown;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"AdtType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtType.AdtType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.AdtType AdtType
        {
        get { return mAdtType; }
        set { mAdtType = value; }
        }

        private bool mIsCancelRequest
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IsCancelRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsCancelRequest
        {
        get { return mIsCancelRequest; }
        set { mIsCancelRequest = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private double mMessageTransmissionDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MessageTransmissionDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MessageTransmissionDate
        {
        get { return mMessageTransmissionDate; }
        set { mMessageTransmissionDate = value; }
        }

        private string mExternalMessageId
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ExternalMessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalMessageId
        {
        get { return mExternalMessageId; }
        set { mExternalMessageId = value; }
        }

        private string mExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalReference
        {
        get { return mExternalReference; }
        set { mExternalReference = value; }
        }

        private double mEffectiveDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"EffectiveDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EffectiveDate
        {
        get { return mEffectiveDate; }
        set { mEffectiveDate = value; }
        }

        private double mInitiatedOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"InitiatedOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InitiatedOnDate
        {
        get { return mInitiatedOnDate; }
        set { mInitiatedOnDate = value; }
        }

        private string mInitiatedBy
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"InitiatedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InitiatedBy
        {
        get { return mInitiatedBy; }
        set { mInitiatedBy = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private bool mStoreIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private string mRawRequestData
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RawRequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RawRequestData
        {
        get { return mRawRequestData; }
        set { mRawRequestData = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPat> mAdtPat = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPat>();
        [global::ProtoBuf.ProtoMember(13, Name=@"AdtPat", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.AdtPat> AdtPat
        {
        get { return mAdtPat; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        