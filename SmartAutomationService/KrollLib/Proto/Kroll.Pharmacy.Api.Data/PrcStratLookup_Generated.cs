
        // Generated from: PrcStratLookup.proto
        // Note: requires additional types generated from: FormularyMixType_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PrcStratLookup")]
        public partial class PrcStratLookup : global::ProtoBuf.IExtensible
        {
        public PrcStratLookup() {}
        

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

        private int mPrcStratId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PrcStratId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PrcStratId
        {
        get { return mPrcStratId; }
        set { mPrcStratId = value; }
        }

        private int mSubPlanId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SubPlanId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SubPlanId
        {
        get { return mSubPlanId; }
        set { mSubPlanId = value; }
        }

        private bool mSubPlanIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"SubPlanIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubPlanIdSpecified
        {
        get { return mSubPlanIdSpecified; }
        set { mSubPlanIdSpecified = value; }
        }

        private int mDrgPrcGrpId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DrgPrcGrpId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPrcGrpId
        {
        get { return mDrgPrcGrpId; }
        set { mDrgPrcGrpId = value; }
        }

        private bool mDrgPrcGrpIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DrgPrcGrpIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DrgPrcGrpIdSpecified
        {
        get { return mDrgPrcGrpIdSpecified; }
        set { mDrgPrcGrpIdSpecified = value; }
        }

        private int mPatPrcGrpId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PatPrcGrpId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatPrcGrpId
        {
        get { return mPatPrcGrpId; }
        set { mPatPrcGrpId = value; }
        }

        private bool mPatPrcGrpIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PatPrcGrpIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatPrcGrpIdSpecified
        {
        get { return mPatPrcGrpIdSpecified; }
        set { mPatPrcGrpIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.FormularyMixType mFormularyMixType
            = Kroll.Pharmacy.Api.Data.FormularyMixType.FormularyMixType_Regular;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"FormularyMixType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.FormularyMixType.FormularyMixType_Regular)]
        
        public Kroll.Pharmacy.Api.Data.FormularyMixType FormularyMixType
        {
        get { return mFormularyMixType; }
        set { mFormularyMixType = value; }
        }

        private int mBrandGenericType
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"BrandGenericType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int BrandGenericType
        {
        get { return mBrandGenericType; }
        set { mBrandGenericType = value; }
        }

        private bool mIsDrgPrcGrpException
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"IsDrgPrcGrpException", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDrgPrcGrpException
        {
        get { return mIsDrgPrcGrpException; }
        set { mIsDrgPrcGrpException = value; }
        }

        private bool mIsPatPrcGrpException
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"IsPatPrcGrpException", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsPatPrcGrpException
        {
        get { return mIsPatPrcGrpException; }
        set { mIsPatPrcGrpException = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private bool mHasBrandGenericType
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"HasBrandGenericType", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool HasBrandGenericType
        {
        get { return mHasBrandGenericType; }
        set { mHasBrandGenericType = value; }
        }

        private bool mBrandGenericTypeUseForBrandSingleSource
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"BrandGenericTypeUseForBrandSingleSource", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BrandGenericTypeUseForBrandSingleSource
        {
        get { return mBrandGenericTypeUseForBrandSingleSource; }
        set { mBrandGenericTypeUseForBrandSingleSource = value; }
        }

        private bool mBrandGenericTypeUseForBrandMultiSourceGeneric
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"BrandGenericTypeUseForBrandMultiSourceGeneric", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BrandGenericTypeUseForBrandMultiSourceGeneric
        {
        get { return mBrandGenericTypeUseForBrandMultiSourceGeneric; }
        set { mBrandGenericTypeUseForBrandMultiSourceGeneric = value; }
        }

        private bool mBrandGenericTypeUseForBrandMultiSourceBrand
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"BrandGenericTypeUseForBrandMultiSourceBrand", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BrandGenericTypeUseForBrandMultiSourceBrand
        {
        get { return mBrandGenericTypeUseForBrandMultiSourceBrand; }
        set { mBrandGenericTypeUseForBrandMultiSourceBrand = value; }
        }

        private bool mBrandGenericTypeUseForGenericMultiSource
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"BrandGenericTypeUseForGenericMultiSource", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BrandGenericTypeUseForGenericMultiSource
        {
        get { return mBrandGenericTypeUseForGenericMultiSource; }
        set { mBrandGenericTypeUseForGenericMultiSource = value; }
        }

        private bool mBrandGenericTypeUseForGenericSingleSource
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"BrandGenericTypeUseForGenericSingleSource", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BrandGenericTypeUseForGenericSingleSource
        {
        get { return mBrandGenericTypeUseForGenericSingleSource; }
        set { mBrandGenericTypeUseForGenericSingleSource = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        