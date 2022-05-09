
        // Generated from: ExternalRxLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ExternalRxLink")]
        public partial class ExternalRxLink : global::ProtoBuf.IExtensible
        {
        public ExternalRxLink() {}
        

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

        private int mExternalInterfaceId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"ExternalInterfaceId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ExternalInterfaceId
        {
        get { return mExternalInterfaceId; }
        set { mExternalInterfaceId = value; }
        }

        private int mRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"RxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int RxNum
        {
        get { return mRxNum; }
        set { mRxNum = value; }
        }

        private string mExternalReference
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ExternalReference", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ExternalReference
        {
        get { return mExternalReference; }
        set { mExternalReference = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        