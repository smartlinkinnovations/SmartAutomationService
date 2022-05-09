
        // Generated from: DrgPlan.proto
        // Note: requires additional types generated from: DinType_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgPlan")]
        public partial class DrgPlan : global::ProtoBuf.IExtensible
        {
        public DrgPlan() {}
        

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

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgId
        {
        get { return mDrgId; }
        set { mDrgId = value; }
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

        private string mPseudoDin
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PseudoDin", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PseudoDin
        {
        get { return mPseudoDin; }
        set { mPseudoDin = value; }
        }

        private bool mCovered
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"Covered", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Covered
        {
        get { return mCovered; }
        set { mCovered = value; }
        }

        private int mCost
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"Cost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Cost
        {
        get { return mCost; }
        set { mCost = value; }
        }

        private bool mCostSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CostSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CostSpecified
        {
        get { return mCostSpecified; }
        set { mCostSpecified = value; }
        }

        private bool mBillAsPack
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"BillAsPack", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BillAsPack
        {
        get { return mBillAsPack; }
        set { mBillAsPack = value; }
        }

        private double mBillAsPackDivider
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"BillAsPackDivider", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double BillAsPackDivider
        {
        get { return mBillAsPackDivider; }
        set { mBillAsPackDivider = value; }
        }

        private bool mBillAsPackDivideByPacksize
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"BillAsPackDivideByPacksize", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BillAsPackDivideByPacksize
        {
        get { return mBillAsPackDivideByPacksize; }
        set { mBillAsPackDivideByPacksize = value; }
        }

        private string mIntervention
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Intervention", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Intervention
        {
        get { return mIntervention; }
        set { mIntervention = value; }
        }

        private bool mIsDefault
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"IsDefault", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsDefault
        {
        get { return mIsDefault; }
        set { mIsDefault = value; }
        }

        private string mDescription
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Description", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Description
        {
        get { return mDescription; }
        set { mDescription = value; }
        }

        private double mPackSize
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"PackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PackSize
        {
        get { return mPackSize; }
        set { mPackSize = value; }
        }

        private bool mPackSizeSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"PackSizeSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PackSizeSpecified
        {
        get { return mPackSizeSpecified; }
        set { mPackSizeSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private int mCentralMaintOverrideFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"CentralMaintOverrideFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintOverrideFieldMask
        {
        get { return mCentralMaintOverrideFieldMask; }
        set { mCentralMaintOverrideFieldMask = value; }
        }

        private int mCentralMaintAllowOverrideFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"CentralMaintAllowOverrideFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintAllowOverrideFieldMask
        {
        get { return mCentralMaintAllowOverrideFieldMask; }
        set { mCentralMaintAllowOverrideFieldMask = value; }
        }

        private Kroll.Pharmacy.Api.Data.DinType mPseudoDinType
            = Kroll.Pharmacy.Api.Data.DinType.DinType_Din;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"PseudoDinType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.DinType.DinType_Din)]
        
        public Kroll.Pharmacy.Api.Data.DinType PseudoDinType
        {
        get { return mPseudoDinType; }
        set { mPseudoDinType = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        