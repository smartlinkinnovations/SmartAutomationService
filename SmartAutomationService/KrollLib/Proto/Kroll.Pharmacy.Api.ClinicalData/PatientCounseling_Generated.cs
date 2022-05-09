
        // Generated from: PatientCounseling.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"PatientCounseling")]
        public partial class PatientCounseling : global::ProtoBuf.IExtensible
        {
        public PatientCounseling() {}
        
        private readonly global::System.Collections.Generic.List<string> mProfessionalMessages = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(1, Name=@"ProfessionalMessages", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> ProfessionalMessages
        {
        get { return mProfessionalMessages; }
        }
    
        private readonly global::System.Collections.Generic.List<string> mPatientMessages = new global::System.Collections.Generic.List<string>();
        [global::ProtoBuf.ProtoMember(2, Name=@"PatientMessages", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<string> PatientMessages
        {
        get { return mPatientMessages; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        