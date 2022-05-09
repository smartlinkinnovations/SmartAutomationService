
        // Generated from: SubmitERxOrderRequestData.proto
        // Note: requires additional types generated from: ERxOrder.proto
            namespace Kroll.Pharmacy.Api.ActionData
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"SubmitERxOrderRequestData")]
        public partial class SubmitERxOrderRequestData : global::ProtoBuf.IExtensible
        {
        public SubmitERxOrderRequestData() {}
        

        private int mStoreId
            = 
                (int)1;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"StoreId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                (int)1)]
        
        public int StoreId
        {
        get { return mStoreId; }
        set { mStoreId = value; }
        }

        private double mMessageTransmissionDateTime
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MessageTransmissionDateTime", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MessageTransmissionDateTime
        {
        get { return mMessageTransmissionDateTime; }
        set { mMessageTransmissionDateTime = value; }
        }

        private string mRawRequestData
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"RawRequestData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string RawRequestData
        {
        get { return mRawRequestData; }
        set { mRawRequestData = value; }
        }

        private string mExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalRxReference
        {
        get { return mExternalRxReference; }
        set { mExternalRxReference = value; }
        }

        private string mERxId
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ERxId", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ERxId
        {
        get { return mERxId; }
        set { mERxId = value; }
        }

        private string mExternalPatReference
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ExternalPatReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalPatReference
        {
        get { return mExternalPatReference; }
        set { mExternalPatReference = value; }
        }

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private bool mPatIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PatIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatIdSpecified
        {
        get { return mPatIdSpecified; }
        set { mPatIdSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.ERxOrder mERxOrder
            = null;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ERxOrder", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.ERxOrder ERxOrder
        {
        get { return mERxOrder; }
        set { mERxOrder = value; }
        }

        private string mPriorExternalRxReference
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"PriorExternalRxReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PriorExternalRxReference
        {
        get { return mPriorExternalRxReference; }
        set { mPriorExternalRxReference = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        