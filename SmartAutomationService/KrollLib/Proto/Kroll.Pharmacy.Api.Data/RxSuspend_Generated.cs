
        // Generated from: RxSuspend.proto
        // Note: requires additional types generated from: RxSuspendReasonType_Enum.proto
        // Note: requires additional types generated from: RxResumeReasonType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"RxSuspend")]
        public partial class RxSuspend : global::ProtoBuf.IExtensible
        {
        public RxSuspend() {}
        

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

        private int mOrigRxNum
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"OrigRxNum", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int OrigRxNum
        {
        get { return mOrigRxNum; }
        set { mOrigRxNum = value; }
        }

        private double mSuspendDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"SuspendDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double SuspendDate
        {
        get { return mSuspendDate; }
        set { mSuspendDate = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxSuspendReasonType mSuspendReasonType
            = Kroll.Pharmacy.Api.Data.RxSuspendReasonType.RxSuspendReasonType_Custom;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"SuspendReasonType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxSuspendReasonType.RxSuspendReasonType_Custom)]
        
        public Kroll.Pharmacy.Api.Data.RxSuspendReasonType SuspendReasonType
        {
        get { return mSuspendReasonType; }
        set { mSuspendReasonType = value; }
        }

        private string mSuspendReason
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"SuspendReason", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SuspendReason
        {
        get { return mSuspendReason; }
        set { mSuspendReason = value; }
        }

        private string mSuspendComment
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"SuspendComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string SuspendComment
        {
        get { return mSuspendComment; }
        set { mSuspendComment = value; }
        }

        private double mResumeDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ResumeDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ResumeDate
        {
        get { return mResumeDate; }
        set { mResumeDate = value; }
        }

        private bool mResumeDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ResumeDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResumeDateSpecified
        {
        get { return mResumeDateSpecified; }
        set { mResumeDateSpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.RxResumeReasonType mResumeReasonType
            = Kroll.Pharmacy.Api.Data.RxResumeReasonType.RxResumeReasonType_Custom;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ResumeReasonType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.RxResumeReasonType.RxResumeReasonType_Custom)]
        
        public Kroll.Pharmacy.Api.Data.RxResumeReasonType ResumeReasonType
        {
        get { return mResumeReasonType; }
        set { mResumeReasonType = value; }
        }

        private string mResumeReason
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ResumeReason", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResumeReason
        {
        get { return mResumeReason; }
        set { mResumeReason = value; }
        }

        private string mResumeComment
            = "";
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ResumeComment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ResumeComment
        {
        get { return mResumeComment; }
        set { mResumeComment = value; }
        }

        private int mPatLoaId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"PatLoaId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatLoaId
        {
        get { return mPatLoaId; }
        set { mPatLoaId = value; }
        }

        private bool mPatLoaIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"PatLoaIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PatLoaIdSpecified
        {
        get { return mPatLoaIdSpecified; }
        set { mPatLoaIdSpecified = value; }
        }

        private int mSuspendedByERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"SuspendedByERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SuspendedByERxOrderId
        {
        get { return mSuspendedByERxOrderId; }
        set { mSuspendedByERxOrderId = value; }
        }

        private bool mSuspendedByERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"SuspendedByERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SuspendedByERxOrderIdSpecified
        {
        get { return mSuspendedByERxOrderIdSpecified; }
        set { mSuspendedByERxOrderIdSpecified = value; }
        }

        private int mResumedByERxOrderId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ResumedByERxOrderId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int ResumedByERxOrderId
        {
        get { return mResumedByERxOrderId; }
        set { mResumedByERxOrderId = value; }
        }

        private bool mResumedByERxOrderIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ResumedByERxOrderIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ResumedByERxOrderIdSpecified
        {
        get { return mResumedByERxOrderIdSpecified; }
        set { mResumedByERxOrderIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        