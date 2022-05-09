
        // Generated from: OCMMessageType.proto
        // Note: requires additional types generated from: OCMMessageTypes_Enum.proto
        // Note: requires additional types generated from: OCMMessageSubType.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"OCMMessageType")]
        public partial class OCMMessageType : global::ProtoBuf.IExtensible
        {
        public OCMMessageType() {}
        

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

        private Kroll.Pharmacy.Api.Data.OCMMessageTypes mMessageType
            = Kroll.Pharmacy.Api.Data.OCMMessageTypes.OCMMessageTypes_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MessageType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.OCMMessageTypes.OCMMessageTypes_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.OCMMessageTypes MessageType
        {
        get { return mMessageType; }
        set { mMessageType = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private int mPriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"Priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Priority
        {
        get { return mPriority; }
        set { mPriority = value; }
        }

        private bool mAvailableForPat
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AvailableForPat", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AvailableForPat
        {
        get { return mAvailableForPat; }
        set { mAvailableForPat = value; }
        }

        private bool mAvailableForDoc
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"AvailableForDoc", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool AvailableForDoc
        {
        get { return mAvailableForDoc; }
        set { mAvailableForDoc = value; }
        }

        private int mEscalation1Hours
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"Escalation1Hours", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Escalation1Hours
        {
        get { return mEscalation1Hours; }
        set { mEscalation1Hours = value; }
        }

        private bool mEscalation1HoursSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Escalation1HoursSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Escalation1HoursSpecified
        {
        get { return mEscalation1HoursSpecified; }
        set { mEscalation1HoursSpecified = value; }
        }

        private int mEscalation2Hours
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"Escalation2Hours", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Escalation2Hours
        {
        get { return mEscalation2Hours; }
        set { mEscalation2Hours = value; }
        }

        private bool mEscalation2HoursSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"Escalation2HoursSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Escalation2HoursSpecified
        {
        get { return mEscalation2HoursSpecified; }
        set { mEscalation2HoursSpecified = value; }
        }

        private int mEscalation3Hours
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Escalation3Hours", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Escalation3Hours
        {
        get { return mEscalation3Hours; }
        set { mEscalation3Hours = value; }
        }

        private bool mEscalation3HoursSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Escalation3HoursSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Escalation3HoursSpecified
        {
        get { return mEscalation3HoursSpecified; }
        set { mEscalation3HoursSpecified = value; }
        }

        private int mEscalation4Hours
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"Escalation4Hours", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Escalation4Hours
        {
        get { return mEscalation4Hours; }
        set { mEscalation4Hours = value; }
        }

        private bool mEscalation4HoursSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"Escalation4HoursSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Escalation4HoursSpecified
        {
        get { return mEscalation4HoursSpecified; }
        set { mEscalation4HoursSpecified = value; }
        }

        private int mEscalation5Hours
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"Escalation5Hours", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Escalation5Hours
        {
        get { return mEscalation5Hours; }
        set { mEscalation5Hours = value; }
        }

        private bool mEscalation5HoursSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"Escalation5HoursSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Escalation5HoursSpecified
        {
        get { return mEscalation5HoursSpecified; }
        set { mEscalation5HoursSpecified = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.OCMMessageSubType> mOCMMessageSubType = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.OCMMessageSubType>();
        [global::ProtoBuf.ProtoMember(17, Name=@"OCMMessageSubType", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.OCMMessageSubType> OCMMessageSubType
        {
        get { return mOCMMessageSubType; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        