
        // Generated from: PatLimitedUse.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatLimitedUse")]
        public partial class PatLimitedUse : global::ProtoBuf.IExtensible
        {
        public PatLimitedUse() {}
        

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

        private int mPatId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PatId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PatId
        {
        get { return mPatId; }
        set { mPatId = value; }
        }

        private string mDin
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Din", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Din
        {
        get { return mDin; }
        set { mDin = value; }
        }

        private double mExpiryDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ExpiryDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ExpiryDate
        {
        get { return mExpiryDate; }
        set { mExpiryDate = value; }
        }

        private bool mExpiryDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ExpiryDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ExpiryDateSpecified
        {
        get { return mExpiryDateSpecified; }
        set { mExpiryDateSpecified = value; }
        }

        private double mEffectiveDate
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"EffectiveDate", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double EffectiveDate
        {
        get { return mEffectiveDate; }
        set { mEffectiveDate = value; }
        }

        private bool mEffectiveDateSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"EffectiveDateSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EffectiveDateSpecified
        {
        get { return mEffectiveDateSpecified; }
        set { mEffectiveDateSpecified = value; }
        }

        private string mComment
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Comment", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comment
        {
        get { return mComment; }
        set { mComment = value; }
        }

        private string mCommentPlaintext
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CommentPlaintext", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CommentPlaintext
        {
        get { return mCommentPlaintext; }
        set { mCommentPlaintext = value; }
        }

        private string mReasonCode
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ReasonCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ReasonCode
        {
        get { return mReasonCode; }
        set { mReasonCode = value; }
        }

        private int mMaxQty
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"MaxQty", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MaxQty
        {
        get { return mMaxQty; }
        set { mMaxQty = value; }
        }

        private bool mMaxQtySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"MaxQtySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaxQtySpecified
        {
        get { return mMaxQtySpecified; }
        set { mMaxQtySpecified = value; }
        }

        private bool mIsSection8
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"IsSection8", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsSection8
        {
        get { return mIsSection8; }
        set { mIsSection8 = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        