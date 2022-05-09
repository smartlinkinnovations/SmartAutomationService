
        // Generated from: AdtPatPhone.proto
        // Note: requires additional types generated from: AdtPatPhoneType_Enum.proto
        // Note: requires additional types generated from: PhoneType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"AdtPatPhone")]
        public partial class AdtPatPhone : global::ProtoBuf.IExtensible
        {
        public AdtPatPhone() {}
        

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

        private int mAdtPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"AdtPatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdtPatId
        {
        get { return mAdtPatId; }
        set { mAdtPatId = value; }
        }

        private Kroll.Pharmacy.Api.Data.AdtPatPhoneType mAdtPatPhoneType
            = Kroll.Pharmacy.Api.Data.AdtPatPhoneType.AdtPatPhoneType_Insert;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"AdtPatPhoneType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.AdtPatPhoneType.AdtPatPhoneType_Insert)]
        
        public Kroll.Pharmacy.Api.Data.AdtPatPhoneType AdtPatPhoneType
        {
        get { return mAdtPatPhoneType; }
        set { mAdtPatPhoneType = value; }
        }

        private string mExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalReference
        {
        get { return mExternalReference; }
        set { mExternalReference = value; }
        }

        private int mPatPhoneId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PatPhoneId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatPhoneId
        {
        get { return mPatPhoneId; }
        set { mPatPhoneId = value; }
        }

        private bool mPatPhoneIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PatPhoneIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatPhoneIdSpecified
        {
        get { return mPatPhoneIdSpecified; }
        set { mPatPhoneIdSpecified = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private bool mDescriptionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DescriptionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DescriptionSpecified
        {
        get { return mDescriptionSpecified; }
        set { mDescriptionSpecified = value; }
        }

        private string mPhone
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Phone
        {
        get { return mPhone; }
        set { mPhone = value; }
        }

        private bool mPhoneSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"PhoneSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PhoneSpecified
        {
        get { return mPhoneSpecified; }
        set { mPhoneSpecified = value; }
        }

        private string mExtension
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Extension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Extension
        {
        get { return mExtension; }
        set { mExtension = value; }
        }

        private bool mExtensionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ExtensionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExtensionSpecified
        {
        get { return mExtensionSpecified; }
        set { mExtensionSpecified = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateCreated
        {
        get { return mDateCreated; }
        set { mDateCreated = value; }
        }

        private bool mDateCreatedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateChanged
        {
        get { return mDateChanged; }
        set { mDateChanged = value; }
        }

        private bool mDateChangedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.PhoneType mPhoneType
            = Kroll.Pharmacy.Api.Data.PhoneType.PhoneType_Unknown;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"PhoneType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PhoneType.PhoneType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PhoneType PhoneType
        {
        get { return mPhoneType; }
        set { mPhoneType = value; }
        }

        private bool mPhoneTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"PhoneTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PhoneTypeSpecified
        {
        get { return mPhoneTypeSpecified; }
        set { mPhoneTypeSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        