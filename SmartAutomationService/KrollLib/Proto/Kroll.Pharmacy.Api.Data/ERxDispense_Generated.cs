
        // Generated from: ERxDispense.proto
        // Note: requires additional types generated from: ERxDispenseType_Enum.proto
        // Note: requires additional types generated from: NHUnitDoseType_Enum.proto
        // Note: requires additional types generated from: DrugLabelName_Enum.proto
        // Note: requires additional types generated from: ERxDispensePasstime.proto
        // Note: requires additional types generated from: TreatmentType_Enum.proto
        // Note: requires additional types generated from: ERxDispenseStatus_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ERxDispense")]
        public partial class ERxDispense : global::ProtoBuf.IExtensible
        {
        public ERxDispense() {}
        

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

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
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

        private int mPackagerBatchId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PackagerBatchId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PackagerBatchId
        {
        get { return mPackagerBatchId; }
        set { mPackagerBatchId = value; }
        }

        private bool mPackagerBatchIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PackagerBatchIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackagerBatchIdSpecified
        {
        get { return mPackagerBatchIdSpecified; }
        set { mPackagerBatchIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ERxDispenseType mDispenseType
            = Kroll.Pharmacy.Api.Data.ERxDispenseType.ERxDispenseType_IndividualRx;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DispenseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ERxDispenseType.ERxDispenseType_IndividualRx)]
        
        public Kroll.Pharmacy.Api.Data.ERxDispenseType DispenseType
        {
        get { return mDispenseType; }
        set { mDispenseType = value; }
        }

        private bool mIsCancelRequest
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IsCancelRequest", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsCancelRequest
        {
        get { return mIsCancelRequest; }
        set { mIsCancelRequest = value; }
        }

        private double mFillDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"FillDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double FillDate
        {
        get { return mFillDate; }
        set { mFillDate = value; }
        }

        private double mRxStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RxStartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RxStartDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"RxStopDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"RxStopDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"RxExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"RxExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxExpiryDateSpecified
        {
        get { return mRxExpiryDateSpecified; }
        set { mRxExpiryDateSpecified = value; }
        }

        private double mDrgExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DrgExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DrgExpiryDate
        {
        get { return mDrgExpiryDate; }
        set { mDrgExpiryDate = value; }
        }

        private bool mDrgExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"DrgExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgExpiryDateSpecified
        {
        get { return mDrgExpiryDateSpecified; }
        set { mDrgExpiryDateSpecified = value; }
        }

        private int mRxStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"RxStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DocId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"DocIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ExternalDocReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalDocReference
        {
        get { return mExternalDocReference; }
        set { mExternalDocReference = value; }
        }

        private string mDocLastName
            = "";
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"DocLastName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocLastName
        {
        get { return mDocLastName; }
        set { mDocLastName = value; }
        }

        private string mDocFirstName
            = "";
        [global::ProtoBuf.ProtoMember(25, IsRequired = false, Name=@"DocFirstName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DocFirstName
        {
        get { return mDocFirstName; }
        set { mDocFirstName = value; }
        }

        private string mDocLicense
            = "";
        [global::ProtoBuf.ProtoMember(26, IsRequired = false, Name=@"DocLicense", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(27, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(28, IsRequired = false, Name=@"DrgIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(29, IsRequired = false, Name=@"ExternalDrgReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"MixId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"MixIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(32, IsRequired = false, Name=@"ExternalMixReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(33, IsRequired = false, Name=@"IsMixture", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsMixture
        {
        get { return mIsMixture; }
        set { mIsMixture = value; }
        }

        private string mDIN
            = "";
        [global::ProtoBuf.ProtoMember(34, IsRequired = false, Name=@"DIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DIN
        {
        get { return mDIN; }
        set { mDIN = value; }
        }

        private int mDINType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(35, IsRequired = false, Name=@"DINType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DINType
        {
        get { return mDINType; }
        set { mDINType = value; }
        }

        private bool mDINTypeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(36, IsRequired = false, Name=@"DINTypeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DINTypeSpecified
        {
        get { return mDINTypeSpecified; }
        set { mDINTypeSpecified = value; }
        }

        private string mDrgBrandName
            = "";
        [global::ProtoBuf.ProtoMember(37, IsRequired = false, Name=@"DrgBrandName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgBrandName
        {
        get { return mDrgBrandName; }
        set { mDrgBrandName = value; }
        }

        private string mDrgGenericName
            = "";
        [global::ProtoBuf.ProtoMember(38, IsRequired = false, Name=@"DrgGenericName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgGenericName
        {
        get { return mDrgGenericName; }
        set { mDrgGenericName = value; }
        }

        private string mDrgStrength
            = "";
        [global::ProtoBuf.ProtoMember(39, IsRequired = false, Name=@"DrgStrength", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgStrength
        {
        get { return mDrgStrength; }
        set { mDrgStrength = value; }
        }

        private string mDrgForm
            = "";
        [global::ProtoBuf.ProtoMember(40, IsRequired = false, Name=@"DrgForm", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgForm
        {
        get { return mDrgForm; }
        set { mDrgForm = value; }
        }

        private string mDrgManufacturer
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"DrgManufacturer", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgManufacturer
        {
        get { return mDrgManufacturer; }
        set { mDrgManufacturer = value; }
        }

        private string mDrgDescription
            = "";
        [global::ProtoBuf.ProtoMember(42, IsRequired = false, Name=@"DrgDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgDescription
        {
        get { return mDrgDescription; }
        set { mDrgDescription = value; }
        }

        private string mDrgEquivTo
            = "";
        [global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"DrgEquivTo", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgEquivTo
        {
        get { return mDrgEquivTo; }
        set { mDrgEquivTo = value; }
        }

        private string mDrgSchedule
            = "";
        [global::ProtoBuf.ProtoMember(44, IsRequired = false, Name=@"DrgSchedule", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgSchedule
        {
        get { return mDrgSchedule; }
        set { mDrgSchedule = value; }
        }

        private double mDrgPackSize
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(45, IsRequired = false, Name=@"DrgPackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"DrgPackSizeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(47, IsRequired = false, Name=@"Sig", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Sig
        {
        get { return mSig; }
        set { mSig = value; }
        }

        private string mSigExpansion
            = "";
        [global::ProtoBuf.ProtoMember(48, IsRequired = false, Name=@"SigExpansion", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SigExpansion
        {
        get { return mSigExpansion; }
        set { mSigExpansion = value; }
        }

        private double mAuthQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(49, IsRequired = false, Name=@"AuthQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(50, IsRequired = false, Name=@"AuthQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AuthQtySpecified
        {
        get { return mAuthQtySpecified; }
        set { mAuthQtySpecified = value; }
        }

        private double mDispQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(51, IsRequired = false, Name=@"DispQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(52, IsRequired = false, Name=@"DispQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DispQtySpecified
        {
        get { return mDispQtySpecified; }
        set { mDispQtySpecified = value; }
        }

        private double mRemQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(53, IsRequired = false, Name=@"RemQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(54, IsRequired = false, Name=@"RemQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RemQtySpecified
        {
        get { return mRemQtySpecified; }
        set { mRemQtySpecified = value; }
        }

        private int mDaysSupply
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(55, IsRequired = false, Name=@"DaysSupply", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"DaysSupplySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"UnlimitedRefills", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnlimitedRefills
        {
        get { return mUnlimitedRefills; }
        set { mUnlimitedRefills = value; }
        }

        private string mOralWritten
            = "";
        [global::ProtoBuf.ProtoMember(58, IsRequired = false, Name=@"OralWritten", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OralWritten
        {
        get { return mOralWritten; }
        set { mOralWritten = value; }
        }

        private int mProductSelection
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(59, IsRequired = false, Name=@"ProductSelection", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(60, IsRequired = false, Name=@"ProductSelectionSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(61, IsRequired = false, Name=@"MinIntervalDays", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"MinIntervalDaysSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"RouteDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RouteDescription
        {
        get { return mRouteDescription; }
        set { mRouteDescription = value; }
        }

        private string mFDBRouteCode
            = "";
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"FDBRouteCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBRouteCode
        {
        get { return mFDBRouteCode; }
        set { mFDBRouteCode = value; }
        }

        private string mFDBDosageFormCode
            = "";
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"FDBDosageFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBDosageFormCode
        {
        get { return mFDBDosageFormCode; }
        set { mFDBDosageFormCode = value; }
        }

        private string mFDBDosageFormDescription
            = "";
        [global::ProtoBuf.ProtoMember(66, IsRequired = false, Name=@"FDBDosageFormDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FDBDosageFormDescription
        {
        get { return mFDBDosageFormDescription; }
        set { mFDBDosageFormDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHUnitDoseType mNHUnitDoseType
            = Kroll.Pharmacy.Api.Data.NHUnitDoseType.NHUnitDoseType_EveryDay;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"NHUnitDoseType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(68, IsRequired = false, Name=@"NHUnitDoseFreq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"NHUnitDoseFreqSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"NHUnitDoseAnchorDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"NHUnitDoseAnchorDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"NHMedTypeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"NHMedTypeIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"NHMedTypeDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(75, IsRequired = false, Name=@"IsPRN", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(76, IsRequired = false, Name=@"IsPRNSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPRNSpecified
        {
        get { return mIsPRNSpecified; }
        set { mIsPRNSpecified = value; }
        }

        private int mNHCycleId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(77, IsRequired = false, Name=@"NHCycleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHCycleId
        {
        get { return mNHCycleId; }
        set { mNHCycleId = value; }
        }

        private bool mNHCycleIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(78, IsRequired = false, Name=@"NHCycleIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHCycleIdSpecified
        {
        get { return mNHCycleIdSpecified; }
        set { mNHCycleIdSpecified = value; }
        }

        private bool mNHBatchFill
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(79, IsRequired = false, Name=@"NHBatchFill", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHBatchFill
        {
        get { return mNHBatchFill; }
        set { mNHBatchFill = value; }
        }

        private bool mNHUnitDose
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(80, IsRequired = false, Name=@"NHUnitDose", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHUnitDose
        {
        get { return mNHUnitDose; }
        set { mNHUnitDose = value; }
        }

        private bool mNHWardStock
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(81, IsRequired = false, Name=@"NHWardStock", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NHWardStock
        {
        get { return mNHWardStock; }
        set { mNHWardStock = value; }
        }

        private string mNHComment
            = "";
        [global::ProtoBuf.ProtoMember(82, IsRequired = false, Name=@"NHComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NHComment
        {
        get { return mNHComment; }
        set { mNHComment = value; }
        }

        private string mWarningLabels
            = "";
        [global::ProtoBuf.ProtoMember(83, IsRequired = false, Name=@"WarningLabels", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string WarningLabels
        {
        get { return mWarningLabels; }
        set { mWarningLabels = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugLabelName mFirstDrugName
            = Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"FirstDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrugLabelName FirstDrugName
        {
        get { return mFirstDrugName; }
        set { mFirstDrugName = value; }
        }

        private Kroll.Pharmacy.Api.Data.DrugLabelName mSecondDrugName
            = Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default;
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"SecondDrugName", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DrugLabelName.DrugLabelName_Default)]
        
        public Kroll.Pharmacy.Api.Data.DrugLabelName SecondDrugName
        {
        get { return mSecondDrugName; }
        set { mSecondDrugName = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxDispensePasstime> mERxDispensePasstimes = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxDispensePasstime>();
        [global::ProtoBuf.ProtoMember(90, Name=@"ERxDispensePasstimes", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.ERxDispensePasstime> ERxDispensePasstimes
        {
        get { return mERxDispensePasstimes; }
        }
    

        private string mDrgFormAbbreviation
            = "";
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"DrgFormAbbreviation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgFormAbbreviation
        {
        get { return mDrgFormAbbreviation; }
        set { mDrgFormAbbreviation = value; }
        }

        private string mDrgManufacturerAbbreviation
            = "";
        [global::ProtoBuf.ProtoMember(92, IsRequired = false, Name=@"DrgManufacturerAbbreviation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DrgManufacturerAbbreviation
        {
        get { return mDrgManufacturerAbbreviation; }
        set { mDrgManufacturerAbbreviation = value; }
        }

        private int mDrugSource
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"DrugSource", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrugSource
        {
        get { return mDrugSource; }
        set { mDrugSource = value; }
        }

        private string mPasstimeCode
            = "";
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"PasstimeCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PasstimeCode
        {
        get { return mPasstimeCode; }
        set { mPasstimeCode = value; }
        }

        private Kroll.Pharmacy.Api.Data.TreatmentType mTreatmentType
            = Kroll.Pharmacy.Api.Data.TreatmentType.TreatmentType_NotSpecified;
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"TreatmentType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.TreatmentType.TreatmentType_NotSpecified)]
        
        public Kroll.Pharmacy.Api.Data.TreatmentType TreatmentType
        {
        get { return mTreatmentType; }
        set { mTreatmentType = value; }
        }

        private Kroll.Pharmacy.Api.Data.ERxDispenseStatus mStatus
            = Kroll.Pharmacy.Api.Data.ERxDispenseStatus.ERxDispenseStatus_Filled;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"Status", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.ERxDispenseStatus.ERxDispenseStatus_Filled)]
        
        public Kroll.Pharmacy.Api.Data.ERxDispenseStatus Status
        {
        get { return mStatus; }
        set { mStatus = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        