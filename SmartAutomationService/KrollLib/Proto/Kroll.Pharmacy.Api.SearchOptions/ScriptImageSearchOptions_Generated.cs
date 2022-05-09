
        // Generated from: ScriptImageSearchOptions.proto
            namespace Kroll.Pharmacy.Api.SearchOptions
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"ScriptImageSearchOptions")]
        public partial class ScriptImageSearchOptions : global::ProtoBuf.IExtensible
        {
        public ScriptImageSearchOptions() {}
        

        private bool mIncludeScriptImageData
            = 
                (bool)true;
        [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"IncludeScriptImageData", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                (bool)true)]
        
        public bool IncludeScriptImageData
        {
        get { return mIncludeScriptImageData; }
        set { mIncludeScriptImageData = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        