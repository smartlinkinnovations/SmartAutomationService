
        // Generated from: CycleCountPack.proto
        // Note: requires additional types generated from: CycleCountState_Enum.proto
        // Note: requires additional types generated from: CycleCountPackDetail.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CycleCountPack")]
        public partial class CycleCountPack : global::ProtoBuf.IExtensible
        {
        public CycleCountPack() {}
        

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

        private int mCycleCountId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"CycleCountId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CycleCountId
        {
        get { return mCycleCountId; }
        set { mCycleCountId = value; }
        }

        private int mDrgPackId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DrgPackId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackId
        {
        get { return mDrgPackId; }
        set { mDrgPackId = value; }
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

        private Kroll.Pharmacy.Api.Data.CycleCountState mState
            = Kroll.Pharmacy.Api.Data.CycleCountState.CycleCountState_Unknown;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"State", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CycleCountState.CycleCountState_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.CycleCountState State
        {
        get { return mState; }
        set { mState = value; }
        }

        private double mInitialOnHandQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"InitialOnHandQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InitialOnHandQty
        {
        get { return mInitialOnHandQty; }
        set { mInitialOnHandQty = value; }
        }

        private double mInitialAcqCost
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"InitialAcqCost", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InitialAcqCost
        {
        get { return mInitialAcqCost; }
        set { mInitialAcqCost = value; }
        }

        private double mTotalCountQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"TotalCountQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double TotalCountQty
        {
        get { return mTotalCountQty; }
        set { mTotalCountQty = value; }
        }

        private double mAppliedOnHandQty
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"AppliedOnHandQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double AppliedOnHandQty
        {
        get { return mAppliedOnHandQty; }
        set { mAppliedOnHandQty = value; }
        }

        private bool mAppliedOnHandQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"AppliedOnHandQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AppliedOnHandQtySpecified
        {
        get { return mAppliedOnHandQtySpecified; }
        set { mAppliedOnHandQtySpecified = value; }
        }

        private double mDateReconciled
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateReconciled", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateReconciled
        {
        get { return mDateReconciled; }
        set { mDateReconciled = value; }
        }

        private bool mDateReconciledSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DateReconciledSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateReconciledSpecified
        {
        get { return mDateReconciledSpecified; }
        set { mDateReconciledSpecified = value; }
        }

        private int mCreationOrder
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"CreationOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CreationOrder
        {
        get { return mCreationOrder; }
        set { mCreationOrder = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CycleCountPackDetail> mCycleCountPackDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CycleCountPackDetail>();
        [global::ProtoBuf.ProtoMember(18, Name=@"CycleCountPackDetails", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.CycleCountPackDetail> CycleCountPackDetails
        {
        get { return mCycleCountPackDetails; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        