
        // Generated from: PackagerBatch.proto
        // Note: requires additional types generated from: PackagerBatchRx.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PackagerBatch")]
        public partial class PackagerBatch : global::ProtoBuf.IExtensible
        {
        public PackagerBatch() {}
        

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

        private int mBatchNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"BatchNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int BatchNum
        {
        get { return mBatchNum; }
        set { mBatchNum = value; }
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

        private string mInstructions
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Instructions", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Instructions
        {
        get { return mInstructions; }
        set { mInstructions = value; }
        }

        private int mPackagerId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PackagerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PackagerIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CFOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CFOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private bool mUseRxDoctor
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"UseRxDoctor", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UseRxDoctor
        {
        get { return mUseRxDoctor; }
        set { mUseRxDoctor = value; }
        }

        private double mStartDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"StartDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double StartDate
        {
        get { return mStartDate; }
        set { mStartDate = value; }
        }

        private double mEndDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"EndDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EndDate
        {
        get { return mEndDate; }
        set { mEndDate = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatchRx> mPackagerBatchRxs = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatchRx>();
        [global::ProtoBuf.ProtoMember(13, Name=@"PackagerBatchRxs", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatchRx> PackagerBatchRxs
        {
        get { return mPackagerBatchRxs; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        