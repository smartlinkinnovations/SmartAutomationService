
        // Generated from: PackagerBatchSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PackagerBatchSearchCriteria")]
        public partial class PackagerBatchSearchCriteria : global::ProtoBuf.IExtensible
        {
        public PackagerBatchSearchCriteria() {}
        

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

        private bool mIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"IdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IdSpecified
        {
        get { return mIdSpecified; }
        set { mIdSpecified = value; }
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

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mDescriptionComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DescriptionComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator DescriptionComparisonOperator
        {
        get { return mDescriptionComparisonOperator; }
        set { mDescriptionComparisonOperator = value; }
        }

        private int mBatchNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"BatchNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int BatchNum
        {
        get { return mBatchNum; }
        set { mBatchNum = value; }
        }

        private bool mBatchNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"BatchNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BatchNumSpecified
        {
        get { return mBatchNumSpecified; }
        set { mBatchNumSpecified = value; }
        }

        private int mPackagerId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PackagerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PackagerId
        {
        get { return mPackagerId; }
        set { mPackagerId = value; }
        }

        private bool mPackagerIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PackagerIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackagerIdSpecified
        {
        get { return mPackagerIdSpecified; }
        set { mPackagerIdSpecified = value; }
        }

        private int mCFOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CFOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFOrderId
        {
        get { return mCFOrderId; }
        set { mCFOrderId = value; }
        }

        private bool mCFOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CFOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFOrderIdSpecified
        {
        get { return mCFOrderIdSpecified; }
        set { mCFOrderIdSpecified = value; }
        }

        private int mStoreId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"StoreIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StoreIdSpecified
        {
        get { return mStoreIdSpecified; }
        set { mStoreIdSpecified = value; }
        }

        private double mStartDateStartRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"StartDateStartRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double StartDateStartRange
        {
        get { return mStartDateStartRange; }
        set { mStartDateStartRange = value; }
        }

        private bool mStartDateStartRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"StartDateStartRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StartDateStartRangeSpecified
        {
        get { return mStartDateStartRangeSpecified; }
        set { mStartDateStartRangeSpecified = value; }
        }

        private double mStartDateEndRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"StartDateEndRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double StartDateEndRange
        {
        get { return mStartDateEndRange; }
        set { mStartDateEndRange = value; }
        }

        private bool mStartDateEndRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"StartDateEndRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool StartDateEndRangeSpecified
        {
        get { return mStartDateEndRangeSpecified; }
        set { mStartDateEndRangeSpecified = value; }
        }

        private double mEndDateStartRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"EndDateStartRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EndDateStartRange
        {
        get { return mEndDateStartRange; }
        set { mEndDateStartRange = value; }
        }

        private bool mEndDateStartRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"EndDateStartRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EndDateStartRangeSpecified
        {
        get { return mEndDateStartRangeSpecified; }
        set { mEndDateStartRangeSpecified = value; }
        }

        private double mEndDateEndRange
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"EndDateEndRange", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EndDateEndRange
        {
        get { return mEndDateEndRange; }
        set { mEndDateEndRange = value; }
        }

        private bool mEndDateEndRangeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"EndDateEndRangeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EndDateEndRangeSpecified
        {
        get { return mEndDateEndRangeSpecified; }
        set { mEndDateEndRangeSpecified = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private bool mRxNumSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private string mRxDoseBarcode
            = "";
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"RxDoseBarcode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RxDoseBarcode
        {
        get { return mRxDoseBarcode; }
        set { mRxDoseBarcode = value; }
        }

        private bool mRxDoseBarcodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(24, IsRequired = false, Name=@"RxDoseBarcodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxDoseBarcodeSpecified
        {
        get { return mRxDoseBarcodeSpecified; }
        set { mRxDoseBarcodeSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        