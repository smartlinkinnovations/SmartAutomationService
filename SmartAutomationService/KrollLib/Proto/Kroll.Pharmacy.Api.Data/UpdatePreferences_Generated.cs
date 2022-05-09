
        // Generated from: UpdatePreferences.proto
        // Note: requires additional types generated from: UpdatePreferencesValueDisplayType_Enum.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"UpdatePreferences")]
        public partial class UpdatePreferences : global::ProtoBuf.IExtensible
        {
        public UpdatePreferences() {}
        

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

        private string mUpdateStrategyName
            = "";
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"UpdateStrategyName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UpdateStrategyName
        {
        get { return mUpdateStrategyName; }
        set { mUpdateStrategyName = value; }
        }

        private string mUpdateDescription
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"UpdateDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string UpdateDescription
        {
        get { return mUpdateDescription; }
        set { mUpdateDescription = value; }
        }

        private int mUpdateDescriptionResourceKey
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"UpdateDescriptionResourceKey", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int UpdateDescriptionResourceKey
        {
        get { return mUpdateDescriptionResourceKey; }
        set { mUpdateDescriptionResourceKey = value; }
        }

        private bool mUpdateDescriptionResourceKeySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"UpdateDescriptionResourceKeySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool UpdateDescriptionResourceKeySpecified
        {
        get { return mUpdateDescriptionResourceKeySpecified; }
        set { mUpdateDescriptionResourceKeySpecified = value; }
        }

        private string mPropertyName
            = "";
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"PropertyName", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PropertyName
        {
        get { return mPropertyName; }
        set { mPropertyName = value; }
        }

        private string mPropertyDescription
            = "";
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"PropertyDescription", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string PropertyDescription
        {
        get { return mPropertyDescription; }
        set { mPropertyDescription = value; }
        }

        private int mPropertyDescriptionResourceKey
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"PropertyDescriptionResourceKey", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PropertyDescriptionResourceKey
        {
        get { return mPropertyDescriptionResourceKey; }
        set { mPropertyDescriptionResourceKey = value; }
        }

        private bool mPropertyDescriptionResourceKeySpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"PropertyDescriptionResourceKeySpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PropertyDescriptionResourceKeySpecified
        {
        get { return mPropertyDescriptionResourceKeySpecified; }
        set { mPropertyDescriptionResourceKeySpecified = value; }
        }

        private Kroll.Pharmacy.Api.Data.UpdatePreferencesValueDisplayType mValueDisplayType
            = Kroll.Pharmacy.Api.Data.UpdatePreferencesValueDisplayType.UpdatePreferencesValueDisplayType_Unknown;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ValueDisplayType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.UpdatePreferencesValueDisplayType.UpdatePreferencesValueDisplayType_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.UpdatePreferencesValueDisplayType ValueDisplayType
        {
        get { return mValueDisplayType; }
        set { mValueDisplayType = value; }
        }

        private bool mActive
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"Active", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool Active
        {
        get { return mActive; }
        set { mActive = value; }
        }

        private int mDisplayWidth
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"DisplayWidth", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DisplayWidth
        {
        get { return mDisplayWidth; }
        set { mDisplayWidth = value; }
        }

        private bool mDisplayWidthSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"DisplayWidthSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool DisplayWidthSpecified
        {
        get { return mDisplayWidthSpecified; }
        set { mDisplayWidthSpecified = value; }
        }

        private int mDisplaySortOrder
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"DisplaySortOrder", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DisplaySortOrder
        {
        get { return mDisplaySortOrder; }
        set { mDisplaySortOrder = value; }
        }

        private int mMaximumValueLength
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"MaximumValueLength", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MaximumValueLength
        {
        get { return mMaximumValueLength; }
        set { mMaximumValueLength = value; }
        }

        private bool mMaximumValueLengthSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"MaximumValueLengthSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool MaximumValueLengthSpecified
        {
        get { return mMaximumValueLengthSpecified; }
        set { mMaximumValueLengthSpecified = value; }
        }

        private string mEnumValues
            = "";
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"EnumValues", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string EnumValues
        {
        get { return mEnumValues; }
        set { mEnumValues = value; }
        }

        private string mDefaultValue
            = "";
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"DefaultValue", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string DefaultValue
        {
        get { return mDefaultValue; }
        set { mDefaultValue = value; }
        }

        private string mValue
            = "";
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"Value", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Value
        {
        get { return mValue; }
        set { mValue = value; }
        }

        private double mDateCreated
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"DateCreated", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"DateCreatedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"DateChanged", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
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
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"DateChangedSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
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
        