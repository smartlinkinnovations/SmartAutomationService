
        // Generated from: CFOrder.proto
        // Note: requires additional types generated from: CFDestinationType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CFOrder")]
        public partial class CFOrder : global::ProtoBuf.IExtensible
        {
        public CFOrder() {}
        

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

        private string mHostOrderId
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"HostOrderId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HostOrderId
        {
        get { return mHostOrderId; }
        set { mHostOrderId = value; }
        }

        private string mShippingName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ShippingName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingName
        {
        get { return mShippingName; }
        set { mShippingName = value; }
        }

        private string mShippingAddress1
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ShippingAddress1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingAddress1
        {
        get { return mShippingAddress1; }
        set { mShippingAddress1 = value; }
        }

        private string mShippingAddress2
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ShippingAddress2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingAddress2
        {
        get { return mShippingAddress2; }
        set { mShippingAddress2 = value; }
        }

        private string mShippingCity
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ShippingCity", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingCity
        {
        get { return mShippingCity; }
        set { mShippingCity = value; }
        }

        private string mShippingProv
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ShippingProv", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingProv
        {
        get { return mShippingProv; }
        set { mShippingProv = value; }
        }

        private string mShippingPostalCode
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ShippingPostalCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingPostalCode
        {
        get { return mShippingPostalCode; }
        set { mShippingPostalCode = value; }
        }

        private string mShippingCountry
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ShippingCountry", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingCountry
        {
        get { return mShippingCountry; }
        set { mShippingCountry = value; }
        }

        private string mShippingPhoneNumber
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ShippingPhoneNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingPhoneNumber
        {
        get { return mShippingPhoneNumber; }
        set { mShippingPhoneNumber = value; }
        }

        private string mBillingName
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"BillingName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingName
        {
        get { return mBillingName; }
        set { mBillingName = value; }
        }

        private string mBillingAddress1
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"BillingAddress1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingAddress1
        {
        get { return mBillingAddress1; }
        set { mBillingAddress1 = value; }
        }

        private string mBillingAddress2
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"BillingAddress2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingAddress2
        {
        get { return mBillingAddress2; }
        set { mBillingAddress2 = value; }
        }

        private string mBillingCity
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"BillingCity", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingCity
        {
        get { return mBillingCity; }
        set { mBillingCity = value; }
        }

        private string mBillingProv
            = "";
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"BillingProv", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingProv
        {
        get { return mBillingProv; }
        set { mBillingProv = value; }
        }

        private string mBillingPostalCode
            = "";
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"BillingPostalCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingPostalCode
        {
        get { return mBillingPostalCode; }
        set { mBillingPostalCode = value; }
        }

        private string mBillingCountry
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"BillingCountry", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingCountry
        {
        get { return mBillingCountry; }
        set { mBillingCountry = value; }
        }

        private string mBillingPhoneNumber
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"BillingPhoneNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingPhoneNumber
        {
        get { return mBillingPhoneNumber; }
        set { mBillingPhoneNumber = value; }
        }

        private Kroll.Pharmacy.Api.Data.CFDestinationType mDestinationType
            = Kroll.Pharmacy.Api.Data.CFDestinationType.CFDestinationType_ShipToStore;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DestinationType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CFDestinationType.CFDestinationType_ShipToStore)]
        
        public Kroll.Pharmacy.Api.Data.CFDestinationType DestinationType
        {
        get { return mDestinationType; }
        set { mDestinationType = value; }
        }

        private int mShippingPriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ShippingPriority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ShippingPriority
        {
        get { return mShippingPriority; }
        set { mShippingPriority = value; }
        }

        private bool mAllowMultipleShipments
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"AllowMultipleShipments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AllowMultipleShipments
        {
        get { return mAllowMultipleShipments; }
        set { mAllowMultipleShipments = value; }
        }

        private bool mIncludePackingSlip
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"IncludePackingSlip", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludePackingSlip
        {
        get { return mIncludePackingSlip; }
        set { mIncludePackingSlip = value; }
        }

        private bool mIncludeInvoice
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"IncludeInvoice", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IncludeInvoice
        {
        get { return mIncludeInvoice; }
        set { mIncludeInvoice = value; }
        }

        private bool mHoldOrder
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"HoldOrder", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HoldOrder
        {
        get { return mHoldOrder; }
        set { mHoldOrder = value; }
        }

        private bool mBilled
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"Billed", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Billed
        {
        get { return mBilled; }
        set { mBilled = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mSentDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"SentDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SentDate
        {
        get { return mSentDate; }
        set { mSentDate = value; }
        }

        private bool mSentDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"SentDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SentDateSpecified
        {
        get { return mSentDateSpecified; }
        set { mSentDateSpecified = value; }
        }

        private int mCFHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"CFHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFHostId
        {
        get { return mCFHostId; }
        set { mCFHostId = value; }
        }

        private bool mCFHostIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"CFHostIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFHostIdSpecified
        {
        get { return mCFHostIdSpecified; }
        set { mCFHostIdSpecified = value; }
        }

        private string mShippingPhoneExtension
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"ShippingPhoneExtension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingPhoneExtension
        {
        get { return mShippingPhoneExtension; }
        set { mShippingPhoneExtension = value; }
        }

        private string mBillingPhoneExtension
            = "";
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"BillingPhoneExtension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string BillingPhoneExtension
        {
        get { return mBillingPhoneExtension; }
        set { mBillingPhoneExtension = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        