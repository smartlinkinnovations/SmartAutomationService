
        // Generated from: ERxOrder.proto
        // Note: requires additional types generated from: ERxTransmissionOrigin_Enum.proto
        // Note: requires additional types generated from: NHUnitDoseType_Enum.proto
        // Note: requires additional types generated from: RxSuspendReasonType_Enum.proto
        // Note: requires additional types generated from: RxResumeReasonType_Enum.proto
        // Note: requires additional types generated from: ERxOrderType_Enum.proto
        // Note: requires additional types generated from: ERxOrderIndications.proto
        // Note: requires additional types generated from: ERxOrderPasstime.proto
        // Note: requires additional types generated from: DinType_Enum.proto
        // Note: requires additional types generated from: PrescriptiveAuthority_Enum.proto
        // Note: requires additional types generated from: TreatmentType_Enum.proto
        // Note: requires additional types generated from: Designation_Enum.proto
        // Note: requires additional types generated from: CeRxOrderType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ERxOrder")]
        public partial class ERxOrder : global::ProtoBuf.IExtensible
        {
        public ERxOrder() {}
        

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

        private int mERxId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ERxId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxId
        {
        get { return mERxId; }
        set { mERxId = value; }
        }

        private Kroll.Pharmacy.Api.Data.ERxOrderType mERxOrderType
            = Kroll.Pharmacy.Api.Data.ERxOrderType.ERxOrderType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"ERxOrderType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ERxOrderType.ERxOrderType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.ERxOrderType ERxOrderType
        {
        get { return mERxOrderType; }
        set { mERxOrderType = value; }
        }

        private Kroll.Pharmacy.Api.Data.ERxTransmissionOrigin mOrigin
            = Kroll.Pharmacy.Api.Data.ERxTransmissionOrigin.ERxTransmissionOrigin_External;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Origin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ERxTransmissionOrigin.ERxTransmissionOrigin_External)]
        
        public Kroll.Pharmacy.Api.Data.ERxTransmissionOrigin Origin
        {
        get { return mOrigin; }
        set { mOrigin = value; }
        }

        private int mERxTransmissionId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ERxTransmissionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxTransmissionId
        {
        get { return mERxTransmissionId; }
        set { mERxTransmissionId = value; }
        }

        private bool mERxTransmissionIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ERxTransmissionIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxTransmissionIdSpecified
        {
        get { return mERxTransmissionIdSpecified; }
        set { mERxTransmissionIdSpecified = value; }
        }

        private string mExternalMessageId
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ExternalMessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalMessageId
        {
        get { return mExternalMessageId; }
        set { mExternalMessageId = value; }
        }

        private double mEffectiveDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"EffectiveDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"InitiatedOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InitiatedOnDate
        {
        get { return mInitiatedOnDate; }
        set { mInitiatedOnDate = value; }
        }

        private bool mInitiatedOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"InitiatedOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InitiatedOnDateSpecified
        {
        get { return mInitiatedOnDateSpecified; }
        set { mInitiatedOnDateSpecified = value; }
        }

        private string mInitiatedBy
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"InitiatedBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string InitiatedBy
        {
        get { return mInitiatedBy; }
        set { mInitiatedBy = value; }
        }

        private double mHandledOnDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"HandledOnDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double HandledOnDate
        {
        get { return mHandledOnDate; }
        set { mHandledOnDate = value; }
        }

        private bool mHandledOnDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"HandledOnDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HandledOnDateSpecified
        {
        get { return mHandledOnDateSpecified; }
        set { mHandledOnDateSpecified = value; }
        }

        private string mHandledBy
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"HandledBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string HandledBy
        {
        get { return mHandledBy; }
        set { mHandledBy = value; }
        }

        private bool mIsCancelRequest
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"IsCancelRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsCancelRequest
        {
        get { return mIsCancelRequest; }
        set { mIsCancelRequest = value; }
        }

        private int mERxOrderIdToCancel
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ERxOrderIdToCancel", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxOrderIdToCancel
        {
        get { return mERxOrderIdToCancel; }
        set { mERxOrderIdToCancel = value; }
        }

        private bool mERxOrderIdToCancelSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ERxOrderIdToCancelSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxOrderIdToCancelSpecified
        {
        get { return mERxOrderIdToCancelSpecified; }
        set { mERxOrderIdToCancelSpecified = value; }
        }

        private int mCancelledByERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"CancelledByERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CancelledByERxOrderId
        {
        get { return mCancelledByERxOrderId; }
        set { mCancelledByERxOrderId = value; }
        }

        private bool mCancelledByERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"CancelledByERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CancelledByERxOrderIdSpecified
        {
        get { return mCancelledByERxOrderIdSpecified; }
        set { mCancelledByERxOrderIdSpecified = value; }
        }

        private bool mIsAcknowledgementRequest
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"IsAcknowledgementRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAcknowledgementRequest
        {
        get { return mIsAcknowledgementRequest; }
        set { mIsAcknowledgementRequest = value; }
        }

        private string mAcknowledgementComment
            = "";
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"AcknowledgementComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AcknowledgementComment
        {
        get { return mAcknowledgementComment; }
        set { mAcknowledgementComment = value; }
        }

        private int mERxOrderIdToAcknowledge
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ERxOrderIdToAcknowledge", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxOrderIdToAcknowledge
        {
        get { return mERxOrderIdToAcknowledge; }
        set { mERxOrderIdToAcknowledge = value; }
        }

        private bool mERxOrderIdToAcknowledgeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ERxOrderIdToAcknowledgeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxOrderIdToAcknowledgeSpecified
        {
        get { return mERxOrderIdToAcknowledgeSpecified; }
        set { mERxOrderIdToAcknowledgeSpecified = value; }
        }

        private int mAcknowledgedByERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"AcknowledgedByERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AcknowledgedByERxOrderId
        {
        get { return mAcknowledgedByERxOrderId; }
        set { mAcknowledgedByERxOrderId = value; }
        }

        private bool mAcknowledgedByERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"AcknowledgedByERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AcknowledgedByERxOrderIdSpecified
        {
        get { return mAcknowledgedByERxOrderIdSpecified; }
        set { mAcknowledgedByERxOrderIdSpecified = value; }
        }

        private int mRxStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"RxStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxStatus
        {
        get { return mRxStatus; }
        set { mRxStatus = value; }
        }

        private int mDocId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DocId
        {
        get { return mDocId; }
        set { mDocId = value; }
        }

        private bool mDocIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DocIdSpecified
        {
        get { return mDocIdSpecified; }
        set { mDocIdSpecified = value; }
        }

        private string mExternalDocReference
            = "";
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ExternalDocReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDocReference
        {
        get { return mExternalDocReference; }
        set { mExternalDocReference = value; }
        }

        private string mDocLastName
            = "";
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"DocLastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocLastName
        {
        get { return mDocLastName; }
        set { mDocLastName = value; }
        }

        private string mDocFirstName
            = "";
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"DocFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocFirstName
        {
        get { return mDocFirstName; }
        set { mDocFirstName = value; }
        }

        private string mDocLicense
            = "";
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"DocLicense", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocLicense
        {
        get { return mDocLicense; }
        set { mDocLicense = value; }
        }

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgId
        {
        get { return mDrgId; }
        set { mDrgId = value; }
        }

        private bool mDrgIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"DrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgIdSpecified
        {
        get { return mDrgIdSpecified; }
        set { mDrgIdSpecified = value; }
        }

        private string mExternalDrgReference
            = "";
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"ExternalDrgReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDrgReference
        {
        get { return mExternalDrgReference; }
        set { mExternalDrgReference = value; }
        }

        private int mMixId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"MixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MixId
        {
        get { return mMixId; }
        set { mMixId = value; }
        }

        private bool mMixIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"MixIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MixIdSpecified
        {
        get { return mMixIdSpecified; }
        set { mMixIdSpecified = value; }
        }

        private string mExternalMixReference
            = "";
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"ExternalMixReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalMixReference
        {
        get { return mExternalMixReference; }
        set { mExternalMixReference = value; }
        }

        private bool mIsMixture
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"IsMixture", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsMixture
        {
        get { return mIsMixture; }
        set { mIsMixture = value; }
        }

        private bool mIsMixtureSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"IsMixtureSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsMixtureSpecified
        {
        get { return mIsMixtureSpecified; }
        set { mIsMixtureSpecified = value; }
        }

        private string mDIN
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"DIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DIN
        {
        get { return mDIN; }
        set { mDIN = value; }
        }

        private string mDrgBrandName
            = "";
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"DrgBrandName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgBrandName
        {
        get { return mDrgBrandName; }
        set { mDrgBrandName = value; }
        }

        private string mDrgGenericName
            = "";
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"DrgGenericName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgGenericName
        {
        get { return mDrgGenericName; }
        set { mDrgGenericName = value; }
        }

        private string mDrgStrength
            = "";
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"DrgStrength", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgStrength
        {
        get { return mDrgStrength; }
        set { mDrgStrength = value; }
        }

        private string mDrgForm
            = "";
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"DrgForm", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgForm
        {
        get { return mDrgForm; }
        set { mDrgForm = value; }
        }

        private double mDrgPackSize
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"DrgPackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DrgPackSize
        {
        get { return mDrgPackSize; }
        set { mDrgPackSize = value; }
        }

        private bool mDrgPackSizeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"DrgPackSizeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgPackSizeSpecified
        {
        get { return mDrgPackSizeSpecified; }
        set { mDrgPackSizeSpecified = value; }
        }

        private string mSig
            = "";
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"Sig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Sig
        {
        get { return mSig; }
        set { mSig = value; }
        }

        private string mSigExpansion
            = "";
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"SigExpansion", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SigExpansion
        {
        get { return mSigExpansion; }
        set { mSigExpansion = value; }
        }

        private double mDispQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"DispQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DispQty
        {
        get { return mDispQty; }
        set { mDispQty = value; }
        }

        private bool mDispQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"DispQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DispQtySpecified
        {
        get { return mDispQtySpecified; }
        set { mDispQtySpecified = value; }
        }

        private double mAuthQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"AuthQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AuthQty
        {
        get { return mAuthQty; }
        set { mAuthQty = value; }
        }

        private bool mAuthQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"AuthQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AuthQtySpecified
        {
        get { return mAuthQtySpecified; }
        set { mAuthQtySpecified = value; }
        }

        private int mDaysSupply
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"DaysSupply", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DaysSupply
        {
        get { return mDaysSupply; }
        set { mDaysSupply = value; }
        }

        private bool mDaysSupplySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"DaysSupplySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DaysSupplySpecified
        {
        get { return mDaysSupplySpecified; }
        set { mDaysSupplySpecified = value; }
        }

        private bool mUnlimitedRefills
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"UnlimitedRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnlimitedRefills
        {
        get { return mUnlimitedRefills; }
        set { mUnlimitedRefills = value; }
        }

        private bool mUnlimitedRefillsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"UnlimitedRefillsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnlimitedRefillsSpecified
        {
        get { return mUnlimitedRefillsSpecified; }
        set { mUnlimitedRefillsSpecified = value; }
        }

        private double mRxStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"RxStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxStartDate
        {
        get { return mRxStartDate; }
        set { mRxStartDate = value; }
        }

        private bool mRxStartDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"RxStartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxStartDateSpecified
        {
        get { return mRxStartDateSpecified; }
        set { mRxStartDateSpecified = value; }
        }

        private double mRxStopDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"RxStopDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxStopDate
        {
        get { return mRxStopDate; }
        set { mRxStopDate = value; }
        }

        private bool mRxStopDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"RxStopDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxStopDateSpecified
        {
        get { return mRxStopDateSpecified; }
        set { mRxStopDateSpecified = value; }
        }

        private double mRxExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"RxExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RxExpiryDate
        {
        get { return mRxExpiryDate; }
        set { mRxExpiryDate = value; }
        }

        private bool mRxExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"RxExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxExpiryDateSpecified
        {
        get { return mRxExpiryDateSpecified; }
        set { mRxExpiryDateSpecified = value; }
        }

        private string mOralWritten
            = "";
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OralWritten
        {
        get { return mOralWritten; }
        set { mOralWritten = value; }
        }

        private string mReasonCode
            = "";
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"ReasonCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReasonCode
        {
        get { return mReasonCode; }
        set { mReasonCode = value; }
        }

        private int mProductSelection
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"ProductSelection", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ProductSelection
        {
        get { return mProductSelection; }
        set { mProductSelection = value; }
        }

        private bool mProductSelectionSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"ProductSelectionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ProductSelectionSpecified
        {
        get { return mProductSelectionSpecified; }
        set { mProductSelectionSpecified = value; }
        }

        private int mMinIntervalDays
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"MinIntervalDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MinIntervalDays
        {
        get { return mMinIntervalDays; }
        set { mMinIntervalDays = value; }
        }

        private bool mMinIntervalDaysSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"MinIntervalDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MinIntervalDaysSpecified
        {
        get { return mMinIntervalDaysSpecified; }
        set { mMinIntervalDaysSpecified = value; }
        }

        private string mRouteDescription
            = "";
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"RouteDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RouteDescription
        {
        get { return mRouteDescription; }
        set { mRouteDescription = value; }
        }

        private string mFDBRouteCode
            = "";
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"FDBRouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBRouteCode
        {
        get { return mFDBRouteCode; }
        set { mFDBRouteCode = value; }
        }

        private string mFDBDosageFormCode
            = "";
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"FDBDosageFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBDosageFormCode
        {
        get { return mFDBDosageFormCode; }
        set { mFDBDosageFormCode = value; }
        }

        private string mFDBDosageFormDescription
            = "";
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"FDBDosageFormDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBDosageFormDescription
        {
        get { return mFDBDosageFormDescription; }
        set { mFDBDosageFormDescription = value; }
        }

        private bool mNHUnitDoseSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"NHUnitDoseSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDoseSpecified
        {
        get { return mNHUnitDoseSpecified; }
        set { mNHUnitDoseSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHUnitDoseType mNHUnitDoseType
            = Kroll.Pharmacy.Api.Data.NHUnitDoseType.NHUnitDoseType_EveryDay;
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"NHUnitDoseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHUnitDoseType.NHUnitDoseType_EveryDay)]
        
        public Kroll.Pharmacy.Api.Data.NHUnitDoseType NHUnitDoseType
        {
        get { return mNHUnitDoseType; }
        set { mNHUnitDoseType = value; }
        }

        private int mNHUnitDoseFreq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"NHUnitDoseFreq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHUnitDoseFreq
        {
        get { return mNHUnitDoseFreq; }
        set { mNHUnitDoseFreq = value; }
        }

        private bool mNHUnitDoseFreqSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"NHUnitDoseFreqSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDoseFreqSpecified
        {
        get { return mNHUnitDoseFreqSpecified; }
        set { mNHUnitDoseFreqSpecified = value; }
        }

        private double mNHUnitDoseAnchorDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"NHUnitDoseAnchorDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double NHUnitDoseAnchorDate
        {
        get { return mNHUnitDoseAnchorDate; }
        set { mNHUnitDoseAnchorDate = value; }
        }

        private bool mNHUnitDoseAnchorDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"NHUnitDoseAnchorDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDoseAnchorDateSpecified
        {
        get { return mNHUnitDoseAnchorDateSpecified; }
        set { mNHUnitDoseAnchorDateSpecified = value; }
        }

        private int mNHMedTypeId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"NHMedTypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHMedTypeId
        {
        get { return mNHMedTypeId; }
        set { mNHMedTypeId = value; }
        }

        private bool mNHMedTypeIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"NHMedTypeIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHMedTypeIdSpecified
        {
        get { return mNHMedTypeIdSpecified; }
        set { mNHMedTypeIdSpecified = value; }
        }

        private string mNHMedTypeDescription
            = "";
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"NHMedTypeDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHMedTypeDescription
        {
        get { return mNHMedTypeDescription; }
        set { mNHMedTypeDescription = value; }
        }

        private bool mIsPRN
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"IsPRN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPRN
        {
        get { return mIsPRN; }
        set { mIsPRN = value; }
        }

        private bool mIsPRNSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"IsPRNSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPRNSpecified
        {
        get { return mIsPRNSpecified; }
        set { mIsPRNSpecified = value; }
        }

        private int mScriptImageId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"ScriptImageId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ScriptImageId
        {
        get { return mScriptImageId; }
        set { mScriptImageId = value; }
        }

        private bool mScriptImageIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"ScriptImageIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ScriptImageIdSpecified
        {
        get { return mScriptImageIdSpecified; }
        set { mScriptImageIdSpecified = value; }
        }

        private int mRxTransferId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"RxTransferId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxTransferId
        {
        get { return mRxTransferId; }
        set { mRxTransferId = value; }
        }

        private bool mRxTransferIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"RxTransferIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxTransferIdSpecified
        {
        get { return mRxTransferIdSpecified; }
        set { mRxTransferIdSpecified = value; }
        }

        private string mNHComment
            = "";
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"NHComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHComment
        {
        get { return mNHComment; }
        set { mNHComment = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private string mPasstimeCode
            = "";
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"PasstimeCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PasstimeCode
        {
        get { return mPasstimeCode; }
        set { mPasstimeCode = value; }
        }

        private double mSuspendDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(92, IsRequired = false, Name=@"SuspendDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SuspendDate
        {
        get { return mSuspendDate; }
        set { mSuspendDate = value; }
        }

        private bool mSuspendDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"SuspendDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SuspendDateSpecified
        {
        get { return mSuspendDateSpecified; }
        set { mSuspendDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxSuspendReasonType mSuspendReasonType
            = Kroll.Pharmacy.Api.Data.RxSuspendReasonType.RxSuspendReasonType_Unknown;
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"SuspendReasonType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxSuspendReasonType.RxSuspendReasonType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxSuspendReasonType SuspendReasonType
        {
        get { return mSuspendReasonType; }
        set { mSuspendReasonType = value; }
        }

        private string mSuspendReason
            = "";
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"SuspendReason", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SuspendReason
        {
        get { return mSuspendReason; }
        set { mSuspendReason = value; }
        }

        private double mResumeDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"ResumeDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ResumeDate
        {
        get { return mResumeDate; }
        set { mResumeDate = value; }
        }

        private bool mResumeDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(97, IsRequired = false, Name=@"ResumeDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResumeDateSpecified
        {
        get { return mResumeDateSpecified; }
        set { mResumeDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxResumeReasonType mResumeReasonType
            = Kroll.Pharmacy.Api.Data.RxResumeReasonType.RxResumeReasonType_Unknown;
        [global::ProtoBuf.ProtoMember(98, IsRequired = false, Name=@"ResumeReasonType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxResumeReasonType.RxResumeReasonType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.RxResumeReasonType ResumeReasonType
        {
        get { return mResumeReasonType; }
        set { mResumeReasonType = value; }
        }

        private string mResumeReason
            = "";
        [global::ProtoBuf.ProtoMember(99, IsRequired = false, Name=@"ResumeReason", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResumeReason
        {
        get { return mResumeReason; }
        set { mResumeReason = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(100, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(101, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(102, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(103, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrderIndications> mERxOrderIndications = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrderIndications>();
        [global::ProtoBuf.ProtoMember(104, Name=@"ERxOrderIndications", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrderIndications> ERxOrderIndications
        {
        get { return mERxOrderIndications; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrderPasstime> mERxOrderPasstimes = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrderPasstime>();
        [global::ProtoBuf.ProtoMember(105, Name=@"ERxOrderPasstimes", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxOrderPasstime> ERxOrderPasstimes
        {
        get { return mERxOrderPasstimes; }
        }
    

        private string mDrgFormAbbreviation
            = "";
        [global::ProtoBuf.ProtoMember(106, IsRequired = false, Name=@"DrgFormAbbreviation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgFormAbbreviation
        {
        get { return mDrgFormAbbreviation; }
        set { mDrgFormAbbreviation = value; }
        }

        private int mDrugSource
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(107, IsRequired = false, Name=@"DrugSource", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrugSource
        {
        get { return mDrugSource; }
        set { mDrugSource = value; }
        }

        private int mHandledStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(108, IsRequired = false, Name=@"HandledStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int HandledStatus
        {
        get { return mHandledStatus; }
        set { mHandledStatus = value; }
        }

        private int mRxSuspendId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(109, IsRequired = false, Name=@"RxSuspendId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxSuspendId
        {
        get { return mRxSuspendId; }
        set { mRxSuspendId = value; }
        }

        private bool mRxSuspendIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(110, IsRequired = false, Name=@"RxSuspendIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxSuspendIdSpecified
        {
        get { return mRxSuspendIdSpecified; }
        set { mRxSuspendIdSpecified = value; }
        }

        private string mDrgDescription
            = "";
        [global::ProtoBuf.ProtoMember(111, IsRequired = false, Name=@"DrgDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgDescription
        {
        get { return mDrgDescription; }
        set { mDrgDescription = value; }
        }

        private string mDrgManufacturer
            = "";
        [global::ProtoBuf.ProtoMember(112, IsRequired = false, Name=@"DrgManufacturer", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgManufacturer
        {
        get { return mDrgManufacturer; }
        set { mDrgManufacturer = value; }
        }

        private Kroll.Pharmacy.Api.Data.DinType mDINType
            = Kroll.Pharmacy.Api.Data.DinType.DinType_Din;
        [global::ProtoBuf.ProtoMember(113, IsRequired = false, Name=@"DINType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DinType.DinType_Din)]
        
        public Kroll.Pharmacy.Api.Data.DinType DINType
        {
        get { return mDINType; }
        set { mDINType = value; }
        }

        private int mGCN
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(114, IsRequired = false, Name=@"GCN", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int GCN
        {
        get { return mGCN; }
        set { mGCN = value; }
        }

        private bool mGCNSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(115, IsRequired = false, Name=@"GCNSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool GCNSpecified
        {
        get { return mGCNSpecified; }
        set { mGCNSpecified = value; }
        }

        private double mFirstFillQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(116, IsRequired = false, Name=@"FirstFillQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FirstFillQty
        {
        get { return mFirstFillQty; }
        set { mFirstFillQty = value; }
        }

        private bool mFirstFillQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(117, IsRequired = false, Name=@"FirstFillQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FirstFillQtySpecified
        {
        get { return mFirstFillQtySpecified; }
        set { mFirstFillQtySpecified = value; }
        }

        private double mRemQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(118, IsRequired = false, Name=@"RemQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double RemQty
        {
        get { return mRemQty; }
        set { mRemQty = value; }
        }

        private bool mRemQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(119, IsRequired = false, Name=@"RemQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RemQtySpecified
        {
        get { return mRemQtySpecified; }
        set { mRemQtySpecified = value; }
        }

        private int mAuthFills
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(120, IsRequired = false, Name=@"AuthFills", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AuthFills
        {
        get { return mAuthFills; }
        set { mAuthFills = value; }
        }

        private bool mAuthFillsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(121, IsRequired = false, Name=@"AuthFillsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AuthFillsSpecified
        {
        get { return mAuthFillsSpecified; }
        set { mAuthFillsSpecified = value; }
        }

        private int mRemFills
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(122, IsRequired = false, Name=@"RemFills", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RemFills
        {
        get { return mRemFills; }
        set { mRemFills = value; }
        }

        private bool mRemFillsSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(123, IsRequired = false, Name=@"RemFillsSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RemFillsSpecified
        {
        get { return mRemFillsSpecified; }
        set { mRemFillsSpecified = value; }
        }

        private string mIngredients
            = "";
        [global::ProtoBuf.ProtoMember(124, IsRequired = false, Name=@"Ingredients", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Ingredients
        {
        get { return mIngredients; }
        set { mIngredients = value; }
        }

        private Kroll.Pharmacy.Api.Data.PrescriptiveAuthority mPrescriptiveAuthority
            = Kroll.Pharmacy.Api.Data.PrescriptiveAuthority.PrescriptiveAuthority_Paper;
        [global::ProtoBuf.ProtoMember(125, IsRequired = false, Name=@"PrescriptiveAuthority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PrescriptiveAuthority.PrescriptiveAuthority_Paper)]
        
        public Kroll.Pharmacy.Api.Data.PrescriptiveAuthority PrescriptiveAuthority
        {
        get { return mPrescriptiveAuthority; }
        set { mPrescriptiveAuthority = value; }
        }

        private int mHandledByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(126, IsRequired = false, Name=@"HandledByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int HandledByUserId
        {
        get { return mHandledByUserId; }
        set { mHandledByUserId = value; }
        }

        private bool mHandledByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(127, IsRequired = false, Name=@"HandledByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HandledByUserIdSpecified
        {
        get { return mHandledByUserIdSpecified; }
        set { mHandledByUserIdSpecified = value; }
        }

        private int mInitiatedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(128, IsRequired = false, Name=@"InitiatedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int InitiatedByUserId
        {
        get { return mInitiatedByUserId; }
        set { mInitiatedByUserId = value; }
        }

        private bool mInitiatedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(129, IsRequired = false, Name=@"InitiatedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool InitiatedByUserIdSpecified
        {
        get { return mInitiatedByUserIdSpecified; }
        set { mInitiatedByUserIdSpecified = value; }
        }

        private double mDoNotDispenseBeforeDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(130, IsRequired = false, Name=@"DoNotDispenseBeforeDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DoNotDispenseBeforeDate
        {
        get { return mDoNotDispenseBeforeDate; }
        set { mDoNotDispenseBeforeDate = value; }
        }

        private bool mDoNotDispenseBeforeDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(131, IsRequired = false, Name=@"DoNotDispenseBeforeDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DoNotDispenseBeforeDateSpecified
        {
        get { return mDoNotDispenseBeforeDateSpecified; }
        set { mDoNotDispenseBeforeDateSpecified = value; }
        }

        private string mPharmacistInstructions
            = "";
        [global::ProtoBuf.ProtoMember(132, IsRequired = false, Name=@"PharmacistInstructions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PharmacistInstructions
        {
        get { return mPharmacistInstructions; }
        set { mPharmacistInstructions = value; }
        }

        private string mGenericDIN
            = "";
        [global::ProtoBuf.ProtoMember(133, IsRequired = false, Name=@"GenericDIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string GenericDIN
        {
        get { return mGenericDIN; }
        set { mGenericDIN = value; }
        }

        private bool mTrialEligible
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(134, IsRequired = false, Name=@"TrialEligible", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TrialEligible
        {
        get { return mTrialEligible; }
        set { mTrialEligible = value; }
        }

        private int mFirstFillDaysSupply
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(135, IsRequired = false, Name=@"FirstFillDaysSupply", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int FirstFillDaysSupply
        {
        get { return mFirstFillDaysSupply; }
        set { mFirstFillDaysSupply = value; }
        }

        private bool mFirstFillDaysSupplySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(136, IsRequired = false, Name=@"FirstFillDaysSupplySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FirstFillDaysSupplySpecified
        {
        get { return mFirstFillDaysSupplySpecified; }
        set { mFirstFillDaysSupplySpecified = value; }
        }

        private double mFirstFillExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(137, IsRequired = false, Name=@"FirstFillExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FirstFillExpiryDate
        {
        get { return mFirstFillExpiryDate; }
        set { mFirstFillExpiryDate = value; }
        }

        private bool mFirstFillExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(138, IsRequired = false, Name=@"FirstFillExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool FirstFillExpiryDateSpecified
        {
        get { return mFirstFillExpiryDateSpecified; }
        set { mFirstFillExpiryDateSpecified = value; }
        }

        private string mDetectedIssues
            = "";
        [global::ProtoBuf.ProtoMember(139, IsRequired = false, Name=@"DetectedIssues", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DetectedIssues
        {
        get { return mDetectedIssues; }
        set { mDetectedIssues = value; }
        }

        private int mAuthDaysSupply
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(140, IsRequired = false, Name=@"AuthDaysSupply", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AuthDaysSupply
        {
        get { return mAuthDaysSupply; }
        set { mAuthDaysSupply = value; }
        }

        private bool mAuthDaysSupplySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(141, IsRequired = false, Name=@"AuthDaysSupplySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AuthDaysSupplySpecified
        {
        get { return mAuthDaysSupplySpecified; }
        set { mAuthDaysSupplySpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.TreatmentType mTreatmentType
            = Kroll.Pharmacy.Api.Data.TreatmentType.TreatmentType_NotSpecified;
        [global::ProtoBuf.ProtoMember(143, IsRequired = false, Name=@"TreatmentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.TreatmentType.TreatmentType_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.TreatmentType TreatmentType
        {
        get { return mTreatmentType; }
        set { mTreatmentType = value; }
        }

        private string mPatLastName
            = "";
        [global::ProtoBuf.ProtoMember(144, IsRequired = false, Name=@"PatLastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatLastName
        {
        get { return mPatLastName; }
        set { mPatLastName = value; }
        }

        private string mPatFirstName
            = "";
        [global::ProtoBuf.ProtoMember(145, IsRequired = false, Name=@"PatFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PatFirstName
        {
        get { return mPatFirstName; }
        set { mPatFirstName = value; }
        }

        private string mCCDD
            = "";
        [global::ProtoBuf.ProtoMember(146, IsRequired = false, Name=@"CCDD", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CCDD
        {
        get { return mCCDD; }
        set { mCCDD = value; }
        }

        private string mDrgSchedule
            = "";
        [global::ProtoBuf.ProtoMember(147, IsRequired = false, Name=@"DrgSchedule", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgSchedule
        {
        get { return mDrgSchedule; }
        set { mDrgSchedule = value; }
        }

        private Kroll.Pharmacy.Api.Data.Designation mDocDesignation
            = Kroll.Pharmacy.Api.Data.Designation.Designation_Unknown;
        [global::ProtoBuf.ProtoMember(149, IsRequired = false, Name=@"DocDesignation", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.Designation.Designation_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.Designation DocDesignation
        {
        get { return mDocDesignation; }
        set { mDocDesignation = value; }
        }

        private string mFirstFillQtyUOM
            = "";
        [global::ProtoBuf.ProtoMember(150, IsRequired = false, Name=@"FirstFillQtyUOM", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FirstFillQtyUOM
        {
        get { return mFirstFillQtyUOM; }
        set { mFirstFillQtyUOM = value; }
        }

        private string mDispQtyUOM
            = "";
        [global::ProtoBuf.ProtoMember(151, IsRequired = false, Name=@"DispQtyUOM", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DispQtyUOM
        {
        get { return mDispQtyUOM; }
        set { mDispQtyUOM = value; }
        }

        private string mAuthQtyUOM
            = "";
        [global::ProtoBuf.ProtoMember(152, IsRequired = false, Name=@"AuthQtyUOM", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string AuthQtyUOM
        {
        get { return mAuthQtyUOM; }
        set { mAuthQtyUOM = value; }
        }

        private double mMaxDispQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(153, IsRequired = false, Name=@"MaxDispQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MaxDispQty
        {
        get { return mMaxDispQty; }
        set { mMaxDispQty = value; }
        }

        private bool mMaxDispQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(154, IsRequired = false, Name=@"MaxDispQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxDispQtySpecified
        {
        get { return mMaxDispQtySpecified; }
        set { mMaxDispQtySpecified = value; }
        }

        private bool mNoDocERenewal
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(155, IsRequired = false, Name=@"NoDocERenewal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoDocERenewal
        {
        get { return mNoDocERenewal; }
        set { mNoDocERenewal = value; }
        }

        private bool mNoDocERenewalSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(156, IsRequired = false, Name=@"NoDocERenewalSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoDocERenewalSpecified
        {
        get { return mNoDocERenewalSpecified; }
        set { mNoDocERenewalSpecified = value; }
        }

        private string mMaxDispQtyUOM
            = "";
        [global::ProtoBuf.ProtoMember(157, IsRequired = false, Name=@"MaxDispQtyUOM", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MaxDispQtyUOM
        {
        get { return mMaxDispQtyUOM; }
        set { mMaxDispQtyUOM = value; }
        }

        private string mRemQtyUOM
            = "";
        [global::ProtoBuf.ProtoMember(158, IsRequired = false, Name=@"RemQtyUOM", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RemQtyUOM
        {
        get { return mRemQtyUOM; }
        set { mRemQtyUOM = value; }
        }

        private string mExternalDocAddReference
            = "";
        [global::ProtoBuf.ProtoMember(159, IsRequired = false, Name=@"ExternalDocAddReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDocAddReference
        {
        get { return mExternalDocAddReference; }
        set { mExternalDocAddReference = value; }
        }

        private string mCeRxOrderId
            = "";
        [global::ProtoBuf.ProtoMember(160, IsRequired = false, Name=@"CeRxOrderId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CeRxOrderId
        {
        get { return mCeRxOrderId; }
        set { mCeRxOrderId = value; }
        }

        private Kroll.Pharmacy.Api.Data.CeRxOrderType mCeRxOrderType
            = Kroll.Pharmacy.Api.Data.CeRxOrderType.CeRxOrderType_None;
        [global::ProtoBuf.ProtoMember(161, IsRequired = false, Name=@"CeRxOrderType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CeRxOrderType.CeRxOrderType_None)]
        
        public Kroll.Pharmacy.Api.Data.CeRxOrderType CeRxOrderType
        {
        get { return mCeRxOrderType; }
        set { mCeRxOrderType = value; }
        }

        private int mERxOrderIdToUpdate
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(162, IsRequired = false, Name=@"ERxOrderIdToUpdate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ERxOrderIdToUpdate
        {
        get { return mERxOrderIdToUpdate; }
        set { mERxOrderIdToUpdate = value; }
        }

        private bool mERxOrderIdToUpdateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(163, IsRequired = false, Name=@"ERxOrderIdToUpdateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ERxOrderIdToUpdateSpecified
        {
        get { return mERxOrderIdToUpdateSpecified; }
        set { mERxOrderIdToUpdateSpecified = value; }
        }

        private int mUpdatedByERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(164, IsRequired = false, Name=@"UpdatedByERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UpdatedByERxOrderId
        {
        get { return mUpdatedByERxOrderId; }
        set { mUpdatedByERxOrderId = value; }
        }

        private bool mUpdatedByERxOrderIdSpecifid
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(165, IsRequired = false, Name=@"UpdatedByERxOrderIdSpecifid", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdatedByERxOrderIdSpecifid
        {
        get { return mUpdatedByERxOrderIdSpecifid; }
        set { mUpdatedByERxOrderIdSpecifid = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        