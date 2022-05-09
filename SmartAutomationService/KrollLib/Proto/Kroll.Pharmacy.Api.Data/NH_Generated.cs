
        // Generated from: NH.proto
        // Note: requires additional types generated from: NHPackagingType_Enum.proto
        // Note: requires additional types generated from: DotMatrixLabelType_Enum.proto
        // Note: requires additional types generated from: NHMarType_Enum.proto
        // Note: requires additional types generated from: NHTmrType_Enum.proto
        // Note: requires additional types generated from: LaserLabelType_Enum.proto
        // Note: requires additional types generated from: DeliveryRouteType_Enum.proto
        // Note: requires additional types generated from: WorkOrderGrouping_Enum.Proto
        // Note: requires additional types generated from: NHComment.proto
        // Note: requires additional types generated from: NHCycle.proto
        // Note: requires additional types generated from: NHMedType.proto
        // Note: requires additional types generated from: NHWard.proto
        // Note: requires additional types generated from: NHOrders.proto
        // Note: requires additional types generated from: NHPhone.proto
        // Note: requires additional types generated from: NHSort.proto
        // Note: requires additional types generated from: NHType_Enum.proto
        // Note: requires additional types generated from: DrgAlertLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NH")]
        public partial class NH : global::ProtoBuf.IExtensible
        {
        public NH() {}
        

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

        private string mName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Name
        {
        get { return mName; }
        set { mName = value; }
        }

        private string mAddress1
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Address1", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address1
        {
        get { return mAddress1; }
        set { mAddress1 = value; }
        }

        private string mAddress2
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Address2", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Address2
        {
        get { return mAddress2; }
        set { mAddress2 = value; }
        }

        private string mCity
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"City", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string City
        {
        get { return mCity; }
        set { mCity = value; }
        }

        private string mProv
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Prov", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Prov
        {
        get { return mProv; }
        set { mProv = value; }
        }

        private string mPostal
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Postal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Postal
        {
        get { return mPostal; }
        set { mPostal = value; }
        }

        private string mCountry
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Country", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Country
        {
        get { return mCountry; }
        set { mCountry = value; }
        }

        private string mFacilityId
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"FacilityId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FacilityId
        {
        get { return mFacilityId; }
        set { mFacilityId = value; }
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

        private Kroll.Pharmacy.Api.Data.NHPackagingType mPackaging
            = Kroll.Pharmacy.Api.Data.NHPackagingType.NHPackagingType_None;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Packaging", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHPackagingType.NHPackagingType_None)]
        
        public Kroll.Pharmacy.Api.Data.NHPackagingType Packaging
        {
        get { return mPackaging; }
        set { mPackaging = value; }
        }

        private string mPassTimes
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"PassTimes", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PassTimes
        {
        get { return mPassTimes; }
        set { mPassTimes = value; }
        }

        private bool mAllowPassTimeOverride
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"AllowPassTimeOverride", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AllowPassTimeOverride
        {
        get { return mAllowPassTimeOverride; }
        set { mAllowPassTimeOverride = value; }
        }

        private string mFax
            = "";
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Fax", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Fax
        {
        get { return mFax; }
        set { mFax = value; }
        }

        private bool mPrintOneNHLabelPerPassTime
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"PrintOneNHLabelPerPassTime", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintOneNHLabelPerPassTime
        {
        get { return mPrintOneNHLabelPerPassTime; }
        set { mPrintOneNHLabelPerPassTime = value; }
        }

        private bool mPrintHardcopyForManualRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PrintHardcopyForManualRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintHardcopyForManualRx
        {
        get { return mPrintHardcopyForManualRx; }
        set { mPrintHardcopyForManualRx = value; }
        }

        private bool mPrintHardcopyForBatchRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"PrintHardcopyForBatchRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintHardcopyForBatchRx
        {
        get { return mPrintHardcopyForBatchRx; }
        set { mPrintHardcopyForBatchRx = value; }
        }

        private bool mPrintHardcopyInfoInAdjReport
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"PrintHardcopyInfoInAdjReport", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintHardcopyInfoInAdjReport
        {
        get { return mPrintHardcopyInfoInAdjReport; }
        set { mPrintHardcopyInfoInAdjReport = value; }
        }

        private Kroll.Pharmacy.Api.Data.DotMatrixLabelType mNHDotMatrixLabelType
            = Kroll.Pharmacy.Api.Data.DotMatrixLabelType.DotMatrixLabelType_None;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"NHDotMatrixLabelType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DotMatrixLabelType.DotMatrixLabelType_None)]
        
        public Kroll.Pharmacy.Api.Data.DotMatrixLabelType NHDotMatrixLabelType
        {
        get { return mNHDotMatrixLabelType; }
        set { mNHDotMatrixLabelType = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHMarType mMarType
            = Kroll.Pharmacy.Api.Data.NHMarType.NHMarType_None;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"MarType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHMarType.NHMarType_None)]
        
        public Kroll.Pharmacy.Api.Data.NHMarType MarType
        {
        get { return mMarType; }
        set { mMarType = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHTmrType mTmrType
            = Kroll.Pharmacy.Api.Data.NHTmrType.NHTmrType_None;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"TmrType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHTmrType.NHTmrType_None)]
        
        public Kroll.Pharmacy.Api.Data.NHTmrType TmrType
        {
        get { return mTmrType; }
        set { mTmrType = value; }
        }

        private bool mPrintVialLabelForManualRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(30, IsRequired = false, Name=@"PrintVialLabelForManualRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintVialLabelForManualRx
        {
        get { return mPrintVialLabelForManualRx; }
        set { mPrintVialLabelForManualRx = value; }
        }

        private bool mPrintVialLabelForBatchRx
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(31, IsRequired = false, Name=@"PrintVialLabelForBatchRx", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintVialLabelForBatchRx
        {
        get { return mPrintVialLabelForBatchRx; }
        set { mPrintVialLabelForBatchRx = value; }
        }

        private string mPassTimeSets
            = "";
        [global::ProtoBuf.ProtoMember(41, IsRequired = false, Name=@"PassTimeSets", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PassTimeSets
        {
        get { return mPassTimeSets; }
        set { mPassTimeSets = value; }
        }

        private bool mForCashRxsOnlyChargeFeeForFirstRxOfTheMonth
            = 
                default(bool)
            ;
        [global::System.Obsolete, global::ProtoBuf.ProtoMember(43, IsRequired = false, Name=@"ForCashRxsOnlyChargeFeeForFirstRxOfTheMonth", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ForCashRxsOnlyChargeFeeForFirstRxOfTheMonth
        {
        get { return mForCashRxsOnlyChargeFeeForFirstRxOfTheMonth; }
        set { mForCashRxsOnlyChargeFeeForFirstRxOfTheMonth = value; }
        }

        private Kroll.Pharmacy.Api.Data.LaserLabelType mNHLaserLabelType
            = Kroll.Pharmacy.Api.Data.LaserLabelType.LaserLabelType_KrollLabel;
        [global::ProtoBuf.ProtoMember(46, IsRequired = false, Name=@"NHLaserLabelType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.LaserLabelType.LaserLabelType_KrollLabel)]
        
        public Kroll.Pharmacy.Api.Data.LaserLabelType NHLaserLabelType
        {
        get { return mNHLaserLabelType; }
        set { mNHLaserLabelType = value; }
        }

        private string mShortFormCode
            = "";
        [global::ProtoBuf.ProtoMember(56, IsRequired = false, Name=@"ShortFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShortFormCode
        {
        get { return mShortFormCode; }
        set { mShortFormCode = value; }
        }

        private string mDirectorOfCare
            = "";
        [global::ProtoBuf.ProtoMember(57, IsRequired = false, Name=@"DirectorOfCare", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DirectorOfCare
        {
        get { return mDirectorOfCare; }
        set { mDirectorOfCare = value; }
        }

        private bool mPrintPasstimesOnNHLabel
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(62, IsRequired = false, Name=@"PrintPasstimesOnNHLabel", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrintPasstimesOnNHLabel
        {
        get { return mPrintPasstimesOnNHLabel; }
        set { mPrintPasstimesOnNHLabel = value; }
        }

        private bool mUseDefaultWorkOrderCreation
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(63, IsRequired = false, Name=@"UseDefaultWorkOrderCreation", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseDefaultWorkOrderCreation
        {
        get { return mUseDefaultWorkOrderCreation; }
        set { mUseDefaultWorkOrderCreation = value; }
        }

        private bool mCreateWorkOrdersForNHBatches
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(64, IsRequired = false, Name=@"CreateWorkOrdersForNHBatches", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CreateWorkOrdersForNHBatches
        {
        get { return mCreateWorkOrdersForNHBatches; }
        set { mCreateWorkOrdersForNHBatches = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkOrderGrouping mWorkOrderGrouping
            = Kroll.Pharmacy.Api.Data.WorkOrderGrouping.WorkOrderGrouping_NursingHome;
        [global::ProtoBuf.ProtoMember(65, IsRequired = false, Name=@"WorkOrderGrouping", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkOrderGrouping.WorkOrderGrouping_NursingHome)]
        
        public Kroll.Pharmacy.Api.Data.WorkOrderGrouping WorkOrderGrouping
        {
        get { return mWorkOrderGrouping; }
        set { mWorkOrderGrouping = value; }
        }

        private Kroll.Pharmacy.Api.Data.NHType mNHType
            = Kroll.Pharmacy.Api.Data.NHType.NHType_Unknown;
        [global::ProtoBuf.ProtoMember(67, IsRequired = false, Name=@"NHType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.NHType.NHType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.NHType NHType
        {
        get { return mNHType; }
        set { mNHType = value; }
        }

        private string mCorporateId
            = "";
        [global::ProtoBuf.ProtoMember(69, IsRequired = false, Name=@"CorporateId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CorporateId
        {
        get { return mCorporateId; }
        set { mCorporateId = value; }
        }

        private bool mUseGlobalBatchCopayFlags
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(70, IsRequired = false, Name=@"UseGlobalBatchCopayFlags", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseGlobalBatchCopayFlags
        {
        get { return mUseGlobalBatchCopayFlags; }
        set { mUseGlobalBatchCopayFlags = value; }
        }

        private int mPackagerId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(71, IsRequired = false, Name=@"PackagerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(72, IsRequired = false, Name=@"PackagerIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackagerIdSpecified
        {
        get { return mPackagerIdSpecified; }
        set { mPackagerIdSpecified = value; }
        }

        private int mUnitDosePatPrcGrpId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(73, IsRequired = false, Name=@"UnitDosePatPrcGrpId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UnitDosePatPrcGrpId
        {
        get { return mUnitDosePatPrcGrpId; }
        set { mUnitDosePatPrcGrpId = value; }
        }

        private bool mUnitDosePatPrcGrpIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(74, IsRequired = false, Name=@"UnitDosePatPrcGrpIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UnitDosePatPrcGrpIdSpecified
        {
        get { return mUnitDosePatPrcGrpIdSpecified; }
        set { mUnitDosePatPrcGrpIdSpecified = value; }
        }

        private int mEMarReportingServiceHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(84, IsRequired = false, Name=@"EMarReportingServiceHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int EMarReportingServiceHostId
        {
        get { return mEMarReportingServiceHostId; }
        set { mEMarReportingServiceHostId = value; }
        }

        private bool mEMarReportingServiceHostIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(85, IsRequired = false, Name=@"EMarReportingServiceHostIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EMarReportingServiceHostIdSpecified
        {
        get { return mEMarReportingServiceHostIdSpecified; }
        set { mEMarReportingServiceHostIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.DeliveryRouteType mDeliveryRouteType
            = Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default;
        [global::ProtoBuf.ProtoMember(86, IsRequired = false, Name=@"DeliveryRouteType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DeliveryRouteType.DeliveryRouteType_Default)]
        
        public Kroll.Pharmacy.Api.Data.DeliveryRouteType DeliveryRouteType
        {
        get { return mDeliveryRouteType; }
        set { mDeliveryRouteType = value; }
        }

        private Kroll.Pharmacy.Api.Data.WorkOrderGrouping mCycleBatchWorkOrderGrouping
            = Kroll.Pharmacy.Api.Data.WorkOrderGrouping.WorkOrderGrouping_NursingHome;
        [global::ProtoBuf.ProtoMember(87, IsRequired = false, Name=@"CycleBatchWorkOrderGrouping", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.WorkOrderGrouping.WorkOrderGrouping_NursingHome)]
        
        public Kroll.Pharmacy.Api.Data.WorkOrderGrouping CycleBatchWorkOrderGrouping
        {
        get { return mCycleBatchWorkOrderGrouping; }
        set { mCycleBatchWorkOrderGrouping = value; }
        }

        private bool mCycleBatchWorkOrderGroupingSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(88, IsRequired = false, Name=@"CycleBatchWorkOrderGroupingSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CycleBatchWorkOrderGroupingSpecified
        {
        get { return mCycleBatchWorkOrderGroupingSpecified; }
        set { mCycleBatchWorkOrderGroupingSpecified = value; }
        }

        private bool mNoKrollCare
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(89, IsRequired = false, Name=@"NoKrollCare", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool NoKrollCare
        {
        get { return mNoKrollCare; }
        set { mNoKrollCare = value; }
        }

        private int mForCashRxsOnlyChargeFeeDuration
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(90, IsRequired = false, Name=@"ForCashRxsOnlyChargeFeeDuration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ForCashRxsOnlyChargeFeeDuration
        {
        get { return mForCashRxsOnlyChargeFeeDuration; }
        set { mForCashRxsOnlyChargeFeeDuration = value; }
        }

        private int mForCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(91, IsRequired = false, Name=@"ForCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ForCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth
        {
        get { return mForCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth; }
        set { mForCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth = value; }
        }

        private int mDefaultDueDateCategoryId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(92, IsRequired = false, Name=@"DefaultDueDateCategoryId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DefaultDueDateCategoryId
        {
        get { return mDefaultDueDateCategoryId; }
        set { mDefaultDueDateCategoryId = value; }
        }

        private bool mDefaultDueDateCategoryIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(93, IsRequired = false, Name=@"DefaultDueDateCategoryIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DefaultDueDateCategoryIdSpecified
        {
        get { return mDefaultDueDateCategoryIdSpecified; }
        set { mDefaultDueDateCategoryIdSpecified = value; }
        }

        private int mForNonBatchCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(94, IsRequired = false, Name=@"ForNonBatchCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ForNonBatchCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth
        {
        get { return mForNonBatchCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth; }
        set { mForNonBatchCashRxsOnlyChargeFeeForFirstXRxsOfTheMonth = value; }
        }

        private int mForNonBatchCashRxsOnlyChargeFeeDuration
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(95, IsRequired = false, Name=@"ForNonBatchCashRxsOnlyChargeFeeDuration", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ForNonBatchCashRxsOnlyChargeFeeDuration
        {
        get { return mForNonBatchCashRxsOnlyChargeFeeDuration; }
        set { mForNonBatchCashRxsOnlyChargeFeeDuration = value; }
        }

        private bool mUseGlobalNonBatchCopayFlags
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(96, IsRequired = false, Name=@"UseGlobalNonBatchCopayFlags", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseGlobalNonBatchCopayFlags
        {
        get { return mUseGlobalNonBatchCopayFlags; }
        set { mUseGlobalNonBatchCopayFlags = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHComment> mComments = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHComment>();
        [global::ProtoBuf.ProtoMember(75, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHComment> Comments
        {
        get { return mComments; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHCycle> mCycles = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHCycle>();
        [global::ProtoBuf.ProtoMember(77, Name=@"Cycles", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHCycle> Cycles
        {
        get { return mCycles; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHWard> mWards = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHWard>();
        [global::ProtoBuf.ProtoMember(79, Name=@"Wards", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHWard> Wards
        {
        get { return mWards; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHOrders> mNHOrders = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHOrders>();
        [global::ProtoBuf.ProtoMember(80, Name=@"NHOrders", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHOrders> NHOrders
        {
        get { return mNHOrders; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHPhone> mPhones = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHPhone>();
        [global::ProtoBuf.ProtoMember(81, Name=@"Phones", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHPhone> Phones
        {
        get { return mPhones; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHSort> mNHSort = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHSort>();
        [global::ProtoBuf.ProtoMember(82, Name=@"NHSort", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHSort> NHSort
        {
        get { return mNHSort; }
        }
    
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlertLink> mDrgAlertLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlertLink>();
        [global::ProtoBuf.ProtoMember(83, Name=@"DrgAlertLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.DrgAlertLink> DrgAlertLinks
        {
        get { return mDrgAlertLinks; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        