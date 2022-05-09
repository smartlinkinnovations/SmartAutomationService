
        // Generated from: PriorityWarningLabel.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PriorityWarningLabel")]
        public partial class PriorityWarningLabel : global::ProtoBuf.IExtensible
        {
        public PriorityWarningLabel() {}
        

        private int mPriority
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"Priority", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Priority
        {
        get { return mPriority; }
        set { mPriority = value; }
        }

        private int mLabelWarningCode
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"LabelWarningCode", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LabelWarningCode
        {
        get { return mLabelWarningCode; }
        set { mLabelWarningCode = value; }
        }

        private string mWarningText
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"WarningText", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string WarningText
        {
        get { return mWarningText; }
        set { mWarningText = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        