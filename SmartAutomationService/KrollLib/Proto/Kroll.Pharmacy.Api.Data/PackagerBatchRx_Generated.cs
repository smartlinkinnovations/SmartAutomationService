
        // Generated from: PackagerBatchRx.proto
        // Note: requires additional types generated from: PackagerBatchRxDose.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PackagerBatchRx")]
        public partial class PackagerBatchRx : global::ProtoBuf.IExtensible
        {
        public PackagerBatchRx() {}
        

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

        private int mPackagerBatchId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PackagerBatchId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PackagerBatchId
        {
        get { return mPackagerBatchId; }
        set { mPackagerBatchId = value; }
        }

        private int mCFHostId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"CFHostId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFHostId
        {
        get { return mCFHostId; }
        set { mCFHostId = value; }
        }

        private bool mCFHostIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"CFHostIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFHostIdSpecified
        {
        get { return mCFHostIdSpecified; }
        set { mCFHostIdSpecified = value; }
        }

        private int mCFPackagerId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"CFPackagerId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFPackagerId
        {
        get { return mCFPackagerId; }
        set { mCFPackagerId = value; }
        }

        private bool mCFPackagerIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"CFPackagerIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFPackagerIdSpecified
        {
        get { return mCFPackagerIdSpecified; }
        set { mCFPackagerIdSpecified = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private int mCFStatus
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CFStatus", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CFStatus
        {
        get { return mCFStatus; }
        set { mCFStatus = value; }
        }

        private bool mCFStatusSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CFStatusSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool CFStatusSpecified
        {
        get { return mCFStatusSpecified; }
        set { mCFStatusSpecified = value; }
        }

        private string mErrorMessages
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ErrorMessages", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ErrorMessages
        {
        get { return mErrorMessages; }
        set { mErrorMessages = value; }
        }

        private bool mBackOrdered
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"BackOrdered", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool BackOrdered
        {
        get { return mBackOrdered; }
        set { mBackOrdered = value; }
        }

        private string mOrderedDIN
            = "";
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"OrderedDIN", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string OrderedDIN
        {
        get { return mOrderedDIN; }
        set { mOrderedDIN = value; }
        }

        private double mQuotedPrice
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"QuotedPrice", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double QuotedPrice
        {
        get { return mQuotedPrice; }
        set { mQuotedPrice = value; }
        }

        private bool mQuotedPriceSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"QuotedPriceSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool QuotedPriceSpecified
        {
        get { return mQuotedPriceSpecified; }
        set { mQuotedPriceSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatchRxDose> mPackagerBatchRxDoses = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatchRxDose>();
        [global::ProtoBuf.ProtoMember(15, Name=@"PackagerBatchRxDoses", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.PackagerBatchRxDose> PackagerBatchRxDoses
        {
        get { return mPackagerBatchRxDoses; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        