
        // Generated from: DeliveryOrder.proto
        // Note: requires additional types generated from: DeliveryOrderStatus_Enum.proto
        // Note: requires additional types generated from: RxCounselingRequired_Enum.proto
        // Note: requires additional types generated from: RxCounselingResponse_Enum.proto
        // Note: requires additional types generated from: CompressionType_Enum.proto
        // Note: requires additional types generated from: PhotoIdType_Enum.proto
        // Note: requires additional types generated from: PhotoIdVerified_Enum.proto
        // Note: requires additional types generated from: DeliveryOrderPackage.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DeliveryOrder")]
        public partial class DeliveryOrder : global::ProtoBuf.IExtensible
        {
        public DeliveryOrder() {}
        

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

        private int mDeliveryNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DeliveryNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryNum
        {
        get { return mDeliveryNum; }
        set { mDeliveryNum = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DeliveryOrderStatus mStatus
            = Kroll.Pharmacy.Api.Data.DeliveryOrderStatus.DeliveryOrderStatus_Pending;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeliveryOrderStatus.DeliveryOrderStatus_Pending)]
        
        public Kroll.Pharmacy.Api.Data.DeliveryOrderStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateCreatedSpecified
        {
        get { return mDateCreatedSpecified; }
        set { mDateCreatedSpecified = value; }
        }

        private double mDateShipped
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DateShipped", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateShipped
        {
        get { return mDateShipped; }
        set { mDateShipped = value; }
        }

        private bool mDateShippedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DateShippedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateShippedSpecified
        {
        get { return mDateShippedSpecified; }
        set { mDateShippedSpecified = value; }
        }

        private string mCreatedBy
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CreatedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CreatedBy
        {
        get { return mCreatedBy; }
        set { mCreatedBy = value; }
        }

        private string mShippedBy
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ShippedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippedBy
        {
        get { return mShippedBy; }
        set { mShippedBy = value; }
        }

        private int mDeliveryMethod
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DeliveryMethod", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryMethod
        {
        get { return mDeliveryMethod; }
        set { mDeliveryMethod = value; }
        }

        private bool mDeliveryMethodSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DeliveryMethodSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryMethodSpecified
        {
        get { return mDeliveryMethodSpecified; }
        set { mDeliveryMethodSpecified = value; }
        }

        private string mWaybill
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Waybill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Waybill
        {
        get { return mWaybill; }
        set { mWaybill = value; }
        }

        private int mPaymentMethod
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"PaymentMethod", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PaymentMethod
        {
        get { return mPaymentMethod; }
        set { mPaymentMethod = value; }
        }

        private bool mPaymentMethodSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PaymentMethodSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PaymentMethodSpecified
        {
        get { return mPaymentMethodSpecified; }
        set { mPaymentMethodSpecified = value; }
        }

        private double mTotalDeliveryOrderAmount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"TotalDeliveryOrderAmount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TotalDeliveryOrderAmount
        {
        get { return mTotalDeliveryOrderAmount; }
        set { mTotalDeliveryOrderAmount = value; }
        }

        private double mDeliveryChargeBeforeTaxes
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DeliveryChargeBeforeTaxes", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveryChargeBeforeTaxes
        {
        get { return mDeliveryChargeBeforeTaxes; }
        set { mDeliveryChargeBeforeTaxes = value; }
        }

        private double mActualShippingCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ActualShippingCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ActualShippingCost
        {
        get { return mActualShippingCost; }
        set { mActualShippingCost = value; }
        }

        private string mAddressLocation
            = "";
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"AddressLocation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AddressLocation
        {
        get { return mAddressLocation; }
        set { mAddressLocation = value; }
        }

        private string mAddress1
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"Address1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address1
        {
        get { return mAddress1; }
        set { mAddress1 = value; }
        }

        private string mAddress2
            = "";
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"Address2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address2
        {
        get { return mAddress2; }
        set { mAddress2 = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private string mProv
            = "";
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Prov
        {
        get { return mProv; }
        set { mProv = value; }
        }

        private string mPostal
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"Postal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Postal
        {
        get { return mPostal; }
        set { mPostal = value; }
        }

        private string mCountry
            = "";
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Country
        {
        get { return mCountry; }
        set { mCountry = value; }
        }

        private string mPhone
            = "";
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"Phone", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Phone
        {
        get { return mPhone; }
        set { mPhone = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private string mExtension
            = "";
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"Extension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Extension
        {
        get { return mExtension; }
        set { mExtension = value; }
        }

        private int mDeliveryRouteType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DeliveryRouteType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryRouteType
        {
        get { return mDeliveryRouteType; }
        set { mDeliveryRouteType = value; }
        }

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHId
        {
        get { return mNHId; }
        set { mNHId = value; }
        }

        private bool mNHIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"NHIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHIdSpecified
        {
        get { return mNHIdSpecified; }
        set { mNHIdSpecified = value; }
        }

        private int mNHWardId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"NHWardId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHWardId
        {
        get { return mNHWardId; }
        set { mNHWardId = value; }
        }

        private bool mNHWardIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"NHWardIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHWardIdSpecified
        {
        get { return mNHWardIdSpecified; }
        set { mNHWardIdSpecified = value; }
        }

        private double mDateChanged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private double mDateReceived
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"DateReceived", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateReceived
        {
        get { return mDateReceived; }
        set { mDateReceived = value; }
        }

        private bool mDateReceivedSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"DateReceivedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateReceivedSpecified
        {
        get { return mDateReceivedSpecified; }
        set { mDateReceivedSpecified = value; }
        }

        private double mDeliveryChargeTax1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"DeliveryChargeTax1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveryChargeTax1
        {
        get { return mDeliveryChargeTax1; }
        set { mDeliveryChargeTax1 = value; }
        }

        private double mDeliveryChargeTax2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"DeliveryChargeTax2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveryChargeTax2
        {
        get { return mDeliveryChargeTax2; }
        set { mDeliveryChargeTax2 = value; }
        }

        private int mDeliveryChargeTaxType1Id
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"DeliveryChargeTaxType1Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryChargeTaxType1Id
        {
        get { return mDeliveryChargeTaxType1Id; }
        set { mDeliveryChargeTaxType1Id = value; }
        }

        private bool mDeliveryChargeTaxType1IdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"DeliveryChargeTaxType1IdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryChargeTaxType1IdSpecified
        {
        get { return mDeliveryChargeTaxType1IdSpecified; }
        set { mDeliveryChargeTaxType1IdSpecified = value; }
        }

        private int mDeliveryChargeTaxType2Id
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"DeliveryChargeTaxType2Id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DeliveryChargeTaxType2Id
        {
        get { return mDeliveryChargeTaxType2Id; }
        set { mDeliveryChargeTaxType2Id = value; }
        }

        private bool mDeliveryChargeTaxType2IdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"DeliveryChargeTaxType2IdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryChargeTaxType2IdSpecified
        {
        get { return mDeliveryChargeTaxType2IdSpecified; }
        set { mDeliveryChargeTaxType2IdSpecified = value; }
        }

        private double mTotalDeliveryCharge
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"TotalDeliveryCharge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TotalDeliveryCharge
        {
        get { return mTotalDeliveryCharge; }
        set { mTotalDeliveryCharge = value; }
        }

        private double mTotalDetailAmount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"TotalDetailAmount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TotalDetailAmount
        {
        get { return mTotalDetailAmount; }
        set { mTotalDetailAmount = value; }
        }

        private double mTotalPatientPays
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"TotalPatientPays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TotalPatientPays
        {
        get { return mTotalPatientPays; }
        set { mTotalPatientPays = value; }
        }

        private string mShippingComment
            = "";
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"ShippingComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShippingComment
        {
        get { return mShippingComment; }
        set { mShippingComment = value; }
        }

        private int mReceivedByPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"ReceivedByPatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReceivedByPatId
        {
        get { return mReceivedByPatId; }
        set { mReceivedByPatId = value; }
        }

        private bool mReceivedByPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"ReceivedByPatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReceivedByPatIdSpecified
        {
        get { return mReceivedByPatIdSpecified; }
        set { mReceivedByPatIdSpecified = value; }
        }

        private string mReceivedByLastName
            = "";
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"ReceivedByLastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReceivedByLastName
        {
        get { return mReceivedByLastName; }
        set { mReceivedByLastName = value; }
        }

        private string mReceivedByFirstName
            = "";
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"ReceivedByFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReceivedByFirstName
        {
        get { return mReceivedByFirstName; }
        set { mReceivedByFirstName = value; }
        }

        private string mReceivedComment
            = "";
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"ReceivedComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReceivedComment
        {
        get { return mReceivedComment; }
        set { mReceivedComment = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCounselingRequired mCounselingRequired
            = Kroll.Pharmacy.Api.Data.RxCounselingRequired.RxCounselingRequired_AutoNotRequested;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"CounselingRequired", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCounselingRequired.RxCounselingRequired_AutoNotRequested)]
        
        public Kroll.Pharmacy.Api.Data.RxCounselingRequired CounselingRequired
        {
        get { return mCounselingRequired; }
        set { mCounselingRequired = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxCounselingResponse mCounselingResponse
            = Kroll.Pharmacy.Api.Data.RxCounselingResponse.RxCounselingResponse_Unknown;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"CounselingResponse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxCounselingResponse.RxCounselingResponse_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxCounselingResponse CounselingResponse
        {
        get { return mCounselingResponse; }
        set { mCounselingResponse = value; }
        }

        private int mClonedFromId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"ClonedFromId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ClonedFromId
        {
        get { return mClonedFromId; }
        set { mClonedFromId = value; }
        }

        private bool mClonedFromIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"ClonedFromIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClonedFromIdSpecified
        {
        get { return mClonedFromIdSpecified; }
        set { mClonedFromIdSpecified = value; }
        }

        private byte[] mWorkflowContextInfo
            = null;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"WorkflowContextInfo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] WorkflowContextInfo
        {
        get { return mWorkflowContextInfo; }
        set { mWorkflowContextInfo = value; }
        }

        private Kroll.Pharmacy.Api.Data.CompressionType mWorkflowContextInfoCompressionType
            = Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"WorkflowContextInfoCompressionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CompressionType.CompressionType_NotSet)]
        
        public Kroll.Pharmacy.Api.Data.CompressionType WorkflowContextInfoCompressionType
        {
        get { return mWorkflowContextInfoCompressionType; }
        set { mWorkflowContextInfoCompressionType = value; }
        }

        private Kroll.Pharmacy.Api.Data.PhotoIdType mReceivedByIdentificationType
            = Kroll.Pharmacy.Api.Data.PhotoIdType.PhotoIdType_None;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"ReceivedByIdentificationType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PhotoIdType.PhotoIdType_None)]
        
        public Kroll.Pharmacy.Api.Data.PhotoIdType ReceivedByIdentificationType
        {
        get { return mReceivedByIdentificationType; }
        set { mReceivedByIdentificationType = value; }
        }

        private string mReceivedByIdentificationDescription
            = "";
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"ReceivedByIdentificationDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReceivedByIdentificationDescription
        {
        get { return mReceivedByIdentificationDescription; }
        set { mReceivedByIdentificationDescription = value; }
        }

        private string mReceivedByIdentificationNumber
            = "";
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"ReceivedByIdentificationNumber", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReceivedByIdentificationNumber
        {
        get { return mReceivedByIdentificationNumber; }
        set { mReceivedByIdentificationNumber = value; }
        }

        private Kroll.Pharmacy.Api.Data.PhotoIdVerified mReceivedByIdentificationVerified
            = Kroll.Pharmacy.Api.Data.PhotoIdVerified.PhotoIdVerified_No;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"ReceivedByIdentificationVerified", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PhotoIdVerified.PhotoIdVerified_No)]
        
        public Kroll.Pharmacy.Api.Data.PhotoIdVerified ReceivedByIdentificationVerified
        {
        get { return mReceivedByIdentificationVerified; }
        set { mReceivedByIdentificationVerified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrderPackage> mPackages = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrderPackage>();
        [global::ProtoBuf.ProtoMember(66, Name=@"Packages", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DeliveryOrderPackage> Packages
        {
        get { return mPackages; }
        }
    

        private int mCreatedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"CreatedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CreatedByUserId
        {
        get { return mCreatedByUserId; }
        set { mCreatedByUserId = value; }
        }

        private bool mCreatedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"CreatedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CreatedByUserIdSpecified
        {
        get { return mCreatedByUserIdSpecified; }
        set { mCreatedByUserIdSpecified = value; }
        }

        private int mShippedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"ShippedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ShippedByUserId
        {
        get { return mShippedByUserId; }
        set { mShippedByUserId = value; }
        }

        private bool mShippedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"ShippedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ShippedByUserIdSpecified
        {
        get { return mShippedByUserIdSpecified; }
        set { mShippedByUserIdSpecified = value; }
        }

        private int mReceivedByElectronicSignatureId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"ReceivedByElectronicSignatureId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ReceivedByElectronicSignatureId
        {
        get { return mReceivedByElectronicSignatureId; }
        set { mReceivedByElectronicSignatureId = value; }
        }

        private bool mReceivedByElectronicSignatureIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"ReceivedByElectronicSignatureIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ReceivedByElectronicSignatureIdSpecified
        {
        get { return mReceivedByElectronicSignatureIdSpecified; }
        set { mReceivedByElectronicSignatureIdSpecified = value; }
        }

        private int mPatDocumentId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"PatDocumentId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatDocumentId
        {
        get { return mPatDocumentId; }
        set { mPatDocumentId = value; }
        }

        private bool mPatDocumentIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"PatDocumentIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatDocumentIdSpecified
        {
        get { return mPatDocumentIdSpecified; }
        set { mPatDocumentIdSpecified = value; }
        }

        private double mDeliveryTimeFrom
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"DeliveryTimeFrom", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveryTimeFrom
        {
        get { return mDeliveryTimeFrom; }
        set { mDeliveryTimeFrom = value; }
        }

        private bool mDeliveryTimeFromSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"DeliveryTimeFromSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryTimeFromSpecified
        {
        get { return mDeliveryTimeFromSpecified; }
        set { mDeliveryTimeFromSpecified = value; }
        }

        private double mDeliveryTimeTo
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"DeliveryTimeTo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DeliveryTimeTo
        {
        get { return mDeliveryTimeTo; }
        set { mDeliveryTimeTo = value; }
        }

        private bool mDeliveryTimeToSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"DeliveryTimeToSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DeliveryTimeToSpecified
        {
        get { return mDeliveryTimeToSpecified; }
        set { mDeliveryTimeToSpecified = value; }
        }

        private bool mCallBeforeDelivery
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"CallBeforeDelivery", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CallBeforeDelivery
        {
        get { return mCallBeforeDelivery; }
        set { mCallBeforeDelivery = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        