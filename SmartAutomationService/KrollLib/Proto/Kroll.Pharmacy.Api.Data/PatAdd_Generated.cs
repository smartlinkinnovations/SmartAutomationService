
        // Generated from: PatAdd.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatAdd")]
        public partial class PatAdd : global::ProtoBuf.IExtensible
        {
        public PatAdd() {}
        

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

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private string mLocation
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Location", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Location
        {
        get { return mLocation; }
        set { mLocation = value; }
        }

        private string mAddress1
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Address1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address1
        {
        get { return mAddress1; }
        set { mAddress1 = value; }
        }

        private string mAddress2
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Address2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address2
        {
        get { return mAddress2; }
        set { mAddress2 = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private string mProvince
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Province", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Province
        {
        get { return mProvince; }
        set { mProvince = value; }
        }

        private string mPostalCode
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PostalCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PostalCode
        {
        get { return mPostalCode; }
        set { mPostalCode = value; }
        }

        private string mCountry
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Country
        {
        get { return mCountry; }
        set { mCountry = value; }
        }

        private string mPhone
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Phone
        {
        get { return mPhone; }
        set { mPhone = value; }
        }

        private string mPhoneExtension
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PhoneExtension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PhoneExtension
        {
        get { return mPhoneExtension; }
        set { mPhoneExtension = value; }
        }

        private string mFax
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Fax", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Fax
        {
        get { return mFax; }
        set { mFax = value; }
        }

        private string mFaxExtension
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"FaxExtension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FaxExtension
        {
        get { return mFaxExtension; }
        set { mFaxExtension = value; }
        }

        private bool mUseForDelivery
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"UseForDelivery", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseForDelivery
        {
        get { return mUseForDelivery; }
        set { mUseForDelivery = value; }
        }

        private bool mUseForBilling
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"UseForBilling", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseForBilling
        {
        get { return mUseForBilling; }
        set { mUseForBilling = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        