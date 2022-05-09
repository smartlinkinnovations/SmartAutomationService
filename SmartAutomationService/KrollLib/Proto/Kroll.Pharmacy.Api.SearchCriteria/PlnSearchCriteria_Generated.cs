
        // Generated from: PlnSearchCriteria.proto
        // Note: requires additional types generated from: StringComparisonOperator_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.SearchCriteria
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PlnSearchCriteria")]
        public partial class PlnSearchCriteria : global::ProtoBuf.IExtensible
        {
        public PlnSearchCriteria() {}
        

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

        private string mSubPlanCode
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"SubPlanCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SubPlanCode
        {
        get { return mSubPlanCode; }
        set { mSubPlanCode = value; }
        }

        private bool mSubPlanCodeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"SubPlanCodeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SubPlanCodeSpecified
        {
        get { return mSubPlanCodeSpecified; }
        set { mSubPlanCodeSpecified = value; }
        }

        private int mAdjHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"AdjHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int AdjHostId
        {
        get { return mAdjHostId; }
        set { mAdjHostId = value; }
        }

        private bool mAdjHostIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"AdjHostIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AdjHostIdSpecified
        {
        get { return mAdjHostIdSpecified; }
        set { mAdjHostIdSpecified = value; }
        }

        private int mClinicalAdjHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ClinicalAdjHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ClinicalAdjHostId
        {
        get { return mClinicalAdjHostId; }
        set { mClinicalAdjHostId = value; }
        }

        private bool mClinicalAdjHostIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ClinicalAdjHostIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClinicalAdjHostIdSpecified
        {
        get { return mClinicalAdjHostIdSpecified; }
        set { mClinicalAdjHostIdSpecified = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator mDescriptionComparisonOperator
            = Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DescriptionComparisonOperator", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator.StringComparisonOperator_NotUsed)]
        
        public Kroll.Pharmacy.Api.SearchCriteria.StringComparisonOperator DescriptionComparisonOperator
        {
        get { return mDescriptionComparisonOperator; }
        set { mDescriptionComparisonOperator = value; }
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

        private bool mCentralMaintLinkSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"CentralMaintLinkSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CentralMaintLinkSpecified
        {
        get { return mCentralMaintLinkSpecified; }
        set { mCentralMaintLinkSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        