
        // Generated from: RxWorkflowPack.proto
        // Note: requires additional types generated from: RxWorkflowPackDetail.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxWorkflowPack")]
        public partial class RxWorkflowPack : global::ProtoBuf.IExtensible
        {
        public RxWorkflowPack() {}
        

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

        private int mRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxWorkflowId
        {
        get { return mRxWorkflowId; }
        set { mRxWorkflowId = value; }
        }

        private int mDrgId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"DrgId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgId
        {
        get { return mDrgId; }
        set { mDrgId = value; }
        }

        private int mDrgPackId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DrgPackId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackId
        {
        get { return mDrgPackId; }
        set { mDrgPackId = value; }
        }

        private double mPackSize
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PackSize", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double PackSize
        {
        get { return mPackSize; }
        set { mPackSize = value; }
        }

        private int mDrgPackTierId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DrgPackTierId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgPackTierId
        {
        get { return mDrgPackTierId; }
        set { mDrgPackTierId = value; }
        }

        private double mQtyToPackage
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"QtyToPackage", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QtyToPackage
        {
        get { return mQtyToPackage; }
        set { mQtyToPackage = value; }
        }

        private double mQtyPackaged
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"QtyPackaged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QtyPackaged
        {
        get { return mQtyPackaged; }
        set { mQtyPackaged = value; }
        }

        private double mInventoryPreallocated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"InventoryPreallocated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InventoryPreallocated
        {
        get { return mInventoryPreallocated; }
        set { mInventoryPreallocated = value; }
        }

        private double mInventoryToUse
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"InventoryToUse", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InventoryToUse
        {
        get { return mInventoryToUse; }
        set { mInventoryToUse = value; }
        }

        private double mInventoryUsed
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"InventoryUsed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InventoryUsed
        {
        get { return mInventoryUsed; }
        set { mInventoryUsed = value; }
        }

        private int mClonedFromId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ClonedFromId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ClonedFromIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ClonedFromIdSpecified
        {
        get { return mClonedFromIdSpecified; }
        set { mClonedFromIdSpecified = value; }
        }

        private double mInventoryToPreallocate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"InventoryToPreallocate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double InventoryToPreallocate
        {
        get { return mInventoryToPreallocate; }
        set { mInventoryToPreallocate = value; }
        }

        private double mQtyOwed
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"QtyOwed", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QtyOwed
        {
        get { return mQtyOwed; }
        set { mQtyOwed = value; }
        }

        private int mRejectedByRxWorkflowDetailId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"RejectedByRxWorkflowDetailId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RejectedByRxWorkflowDetailId
        {
        get { return mRejectedByRxWorkflowDetailId; }
        set { mRejectedByRxWorkflowDetailId = value; }
        }

        private bool mRejectedByRxWorkflowDetailIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"RejectedByRxWorkflowDetailIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RejectedByRxWorkflowDetailIdSpecified
        {
        get { return mRejectedByRxWorkflowDetailIdSpecified; }
        set { mRejectedByRxWorkflowDetailIdSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowPackDetail> mDetails = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowPackDetail>();
        [global::ProtoBuf.ProtoMember(18, Name=@"Details", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.RxWorkflowPackDetail> Details
        {
        get { return mDetails; }
        }
    

        private bool mIsRejected
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"IsRejected", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsRejected
        {
        get { return mIsRejected; }
        set { mIsRejected = value; }
        }

        private bool mDisableInvAdj
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DisableInvAdj", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DisableInvAdj
        {
        get { return mDisableInvAdj; }
        set { mDisableInvAdj = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        