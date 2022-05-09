
        // Generated from: MessageWrapper.proto
        // Note: requires additional types generated from: Enums.proto
        // Note: requires additional types generated from: KeyValuePair.proto
            namespace Kroll.Common.KxProto.Messages
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MessageWrapper")]
        public partial class MessageWrapper : global::ProtoBuf.IExtensible
        {
        public MessageWrapper() {}
        
        private string mMessageId;
        [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"MessageId", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public string MessageId
        {
        get { return mMessageId; }
        set { mMessageId = value; }
        }

        private double mMessageDateTimeUTC
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MessageDateTimeUTC", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MessageDateTimeUTC
        {
        get { return mMessageDateTimeUTC; }
        set { mMessageDateTimeUTC = value; }
        }

        private string mMessageName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"MessageName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MessageName
        {
        get { return mMessageName; }
        set { mMessageName = value; }
        }

        private string mMessageVersion
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"MessageVersion", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MessageVersion
        {
        get { return mMessageVersion; }
        set { mMessageVersion = value; }
        }

        private string mMessageOriginator
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MessageOriginator", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MessageOriginator
        {
        get { return mMessageOriginator; }
        set { mMessageOriginator = value; }
        }

        private Kroll.Common.KxProto.Messages.ContentEncryptionType mMessageContentEncryptionType
            = Kroll.Common.KxProto.Messages.ContentEncryptionType.ContentEncryptionType_None;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MessageContentEncryptionType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Common.KxProto.Messages.ContentEncryptionType.ContentEncryptionType_None)]
        
        public Kroll.Common.KxProto.Messages.ContentEncryptionType MessageContentEncryptionType
        {
        get { return mMessageContentEncryptionType; }
        set { mMessageContentEncryptionType = value; }
        }

        private byte[] mMessageContent
            = null;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"MessageContent", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] MessageContent
        {
        get { return mMessageContent; }
        set { mMessageContent = value; }
        }

        private Kroll.Common.KxProto.Messages.ContentChecksumType mMessageTransportChecksumType
            = Kroll.Common.KxProto.Messages.ContentChecksumType.ContentChecksumType_None;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"MessageTransportChecksumType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Common.KxProto.Messages.ContentChecksumType.ContentChecksumType_None)]
        
        public Kroll.Common.KxProto.Messages.ContentChecksumType MessageTransportChecksumType
        {
        get { return mMessageTransportChecksumType; }
        set { mMessageTransportChecksumType = value; }
        }

        private byte[] mMessageTransportChecksum
            = null;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"MessageTransportChecksum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] MessageTransportChecksum
        {
        get { return mMessageTransportChecksum; }
        set { mMessageTransportChecksum = value; }
        }

        private Kroll.Common.KxProto.Messages.ContentChecksumType mMessageContentChecksumType
            = Kroll.Common.KxProto.Messages.ContentChecksumType.ContentChecksumType_None;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"MessageContentChecksumType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Common.KxProto.Messages.ContentChecksumType.ContentChecksumType_None)]
        
        public Kroll.Common.KxProto.Messages.ContentChecksumType MessageContentChecksumType
        {
        get { return mMessageContentChecksumType; }
        set { mMessageContentChecksumType = value; }
        }

        private byte[] mMessageContentChecksum
            = null;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"MessageContentChecksum", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public byte[] MessageContentChecksum
        {
        get { return mMessageContentChecksum; }
        set { mMessageContentChecksum = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Common.KxProto.Messages.KeyValuePair> mMessageRoute = new global::System.Collections.Generic.List<Kroll.Common.KxProto.Messages.KeyValuePair>();
        [global::ProtoBuf.ProtoMember(12, Name=@"MessageRoute", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Common.KxProto.Messages.KeyValuePair> MessageRoute
        {
        get { return mMessageRoute; }
        }
    

        private string mUserAuthenticationToken
            = "";
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"UserAuthenticationToken", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UserAuthenticationToken
        {
        get { return mUserAuthenticationToken; }
        set { mUserAuthenticationToken = value; }
        }

        private bool mIsResponse
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"IsResponse", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsResponse
        {
        get { return mIsResponse; }
        set { mIsResponse = value; }
        }

        private int mSerializationVersion
            = 
                (int)1;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"SerializationVersion", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                (int)1)]
        
        public int SerializationVersion
        {
        get { return mSerializationVersion; }
        set { mSerializationVersion = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        