
        // Generated from: PatRelMast.proto
        // Note: requires additional types generated from: PatRelationshipType_Enum.proto
        // Note: requires additional types generated from: CeRxRelationshipType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatRelMast")]
        public partial class PatRelMast : global::ProtoBuf.IExtensible
        {
        public PatRelMast() {}
        

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

        private Kroll.Pharmacy.Api.Data.PatRelationshipType mRelationshipType
            = Kroll.Pharmacy.Api.Data.PatRelationshipType.PatRelationshipType_Unknown;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"RelationshipType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatRelationshipType.PatRelationshipType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatRelationshipType RelationshipType
        {
        get { return mRelationshipType; }
        set { mRelationshipType = value; }
        }

        private string mLanguage
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Language", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Language
        {
        get { return mLanguage; }
        set { mLanguage = value; }
        }

        private string mNeuterDescription
            = "";
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"NeuterDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string NeuterDescription
        {
        get { return mNeuterDescription; }
        set { mNeuterDescription = value; }
        }

        private string mMaleDescription
            = "";
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"MaleDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string MaleDescription
        {
        get { return mMaleDescription; }
        set { mMaleDescription = value; }
        }

        private string mFemaleDescription
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"FemaleDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string FemaleDescription
        {
        get { return mFemaleDescription; }
        set { mFemaleDescription = value; }
        }

        private Kroll.Pharmacy.Api.Data.CeRxRelationshipType mCeRxRelationshipType
            = Kroll.Pharmacy.Api.Data.CeRxRelationshipType.CeRxRelationshipType_Unknown;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"CeRxRelationshipType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.CeRxRelationshipType.CeRxRelationshipType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.CeRxRelationshipType CeRxRelationshipType
        {
        get { return mCeRxRelationshipType; }
        set { mCeRxRelationshipType = value; }
        }

        private Kroll.Pharmacy.Api.Data.PatRelationshipType mOppositeRelationshipType
            = Kroll.Pharmacy.Api.Data.PatRelationshipType.PatRelationshipType_Unknown;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"OppositeRelationshipType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PatRelationshipType.PatRelationshipType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PatRelationshipType OppositeRelationshipType
        {
        get { return mOppositeRelationshipType; }
        set { mOppositeRelationshipType = value; }
        }

        private int mSortOrder
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"SortOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SortOrder
        {
        get { return mSortOrder; }
        set { mSortOrder = value; }
        }

        private bool mIsAnimal
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"IsAnimal", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool IsAnimal
        {
        get { return mIsAnimal; }
        set { mIsAnimal = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DateChangedSpecified
        {
        get { return mDateChangedSpecified; }
        set { mDateChangedSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        