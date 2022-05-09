
        // Generated from: InterventionDetails.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"InterventionDetails")]
        public partial class InterventionDetails : global::ProtoBuf.IExtensible
        {
        public InterventionDetails() {}
        

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

        private int mInterventionId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"InterventionId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int InterventionId
        {
        get { return mInterventionId; }
        set { mInterventionId = value; }
        }

        private string mEnteredBy
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"EnteredBy", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EnteredBy
        {
        get { return mEnteredBy; }
        set { mEnteredBy = value; }
        }

        private double mDateEntered
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"DateEntered", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double DateEntered
        {
        get { return mDateEntered; }
        set { mDateEntered = value; }
        }

        private bool mDateEnteredSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"DateEnteredSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateEnteredSpecified
        {
        get { return mDateEnteredSpecified; }
        set { mDateEnteredSpecified = value; }
        }

        private int mTimeSpent
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"TimeSpent", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int TimeSpent
        {
        get { return mTimeSpent; }
        set { mTimeSpent = value; }
        }

        private bool mTimeSpentSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"TimeSpentSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool TimeSpentSpecified
        {
        get { return mTimeSpentSpecified; }
        set { mTimeSpentSpecified = value; }
        }

        private string mComments
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"Comments", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Comments
        {
        get { return mComments; }
        set { mComments = value; }
        }

        private string mCeRxRoot
            = "";
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CeRxRoot", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CeRxRoot
        {
        get { return mCeRxRoot; }
        set { mCeRxRoot = value; }
        }

        private string mCeRxExtension
            = "";
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CeRxExtension", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string CeRxExtension
        {
        get { return mCeRxExtension; }
        set { mCeRxExtension = value; }
        }

        private int mEnteredByUserId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"EnteredByUserId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int EnteredByUserId
        {
        get { return mEnteredByUserId; }
        set { mEnteredByUserId = value; }
        }

        private bool mEnteredByUserIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"EnteredByUserIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool EnteredByUserIdSpecified
        {
        get { return mEnteredByUserIdSpecified; }
        set { mEnteredByUserIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        