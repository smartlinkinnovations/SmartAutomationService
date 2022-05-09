
        // Generated from: PickupBinLink.proto
        // Note: requires additional types generated from: PickupBinLinkType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PickupBinLink")]
        public partial class PickupBinLink : global::ProtoBuf.IExtensible
        {
        public PickupBinLink() {}
        

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

        private int mPickupBinId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PickupBinId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PickupBinId
        {
        get { return mPickupBinId; }
        set { mPickupBinId = value; }
        }

        private Kroll.Pharmacy.Api.Data.PickupBinLinkType mLinkType
            = Kroll.Pharmacy.Api.Data.PickupBinLinkType.PickupBinLinkType_Unknown;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"LinkType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PickupBinLinkType.PickupBinLinkType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PickupBinLinkType LinkType
        {
        get { return mLinkType; }
        set { mLinkType = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"RxNumSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxNumSpecified
        {
        get { return mRxNumSpecified; }
        set { mRxNumSpecified = value; }
        }

        private string mPlacedByUserInit
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PlacedByUserInit", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PlacedByUserInit
        {
        get { return mPlacedByUserInit; }
        set { mPlacedByUserInit = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }

        private int mRxWorkflowId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RxWorkflowId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxWorkflowId
        {
        get { return mRxWorkflowId; }
        set { mRxWorkflowId = value; }
        }

        private bool mRxWorkflowIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"RxWorkflowIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool RxWorkflowIdSpecified
        {
        get { return mRxWorkflowIdSpecified; }
        set { mRxWorkflowIdSpecified = value; }
        }

        private int mPickupBinItemId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"PickupBinItemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PickupBinItemId
        {
        get { return mPickupBinItemId; }
        set { mPickupBinItemId = value; }
        }

        private bool mPickupBinItemIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"PickupBinItemIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PickupBinItemIdSpecified
        {
        get { return mPickupBinItemIdSpecified; }
        set { mPickupBinItemIdSpecified = value; }
        }

        private int mPlacedByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"PlacedByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PlacedByUserId
        {
        get { return mPlacedByUserId; }
        set { mPlacedByUserId = value; }
        }

        private bool mPlacedByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"PlacedByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PlacedByUserIdSpecified
        {
        get { return mPlacedByUserIdSpecified; }
        set { mPlacedByUserIdSpecified = value; }
        }

        private int mVialNumber
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"VialNumber", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int VialNumber
        {
        get { return mVialNumber; }
        set { mVialNumber = value; }
        }

        private bool mVialNumberSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"VialNumberSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool VialNumberSpecified
        {
        get { return mVialNumberSpecified; }
        set { mVialNumberSpecified = value; }
        }

        private double mDatePlacedInBin
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DatePlacedInBin", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DatePlacedInBin
        {
        get { return mDatePlacedInBin; }
        set { mDatePlacedInBin = value; }
        }

        private bool mDatePlacedInBinSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DatePlacedInBinSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DatePlacedInBinSpecified
        {
        get { return mDatePlacedInBinSpecified; }
        set { mDatePlacedInBinSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        