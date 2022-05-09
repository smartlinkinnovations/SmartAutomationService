
        // Generated from: NHWard.proto
        // Note: requires additional types generated from: NHWardCycleLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"NHWard")]
        public partial class NHWard : global::ProtoBuf.IExtensible
        {
        public NHWard() {}
        

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

        private int mNHId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"NHId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NHId
        {
        get { return mNHId; }
        set { mNHId = value; }
        }

        private string mName
            = "";
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Name", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string Name
        {
        get { return mName; }
        set { mName = value; }
        }

        private int mPrimaryCycleId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"PrimaryCycleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PrimaryCycleId
        {
        get { return mPrimaryCycleId; }
        set { mPrimaryCycleId = value; }
        }

        private bool mPrimaryCycleIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"PrimaryCycleIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool PrimaryCycleIdSpecified
        {
        get { return mPrimaryCycleIdSpecified; }
        set { mPrimaryCycleIdSpecified = value; }
        }

        private int mSecondaryCycleId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"SecondaryCycleId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int SecondaryCycleId
        {
        get { return mSecondaryCycleId; }
        set { mSecondaryCycleId = value; }
        }

        private bool mSecondaryCycleIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"SecondaryCycleIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool SecondaryCycleIdSpecified
        {
        get { return mSecondaryCycleIdSpecified; }
        set { mSecondaryCycleIdSpecified = value; }
        }

        private string mShortFormCode
            = "";
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ShortFormCode", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue("")]
        
        public string ShortFormCode
        {
        get { return mShortFormCode; }
        set { mShortFormCode = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHWardCycleLink> mWardCycleLinks = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHWardCycleLink>();
        [global::ProtoBuf.ProtoMember(9, Name=@"WardCycleLinks", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.NHWardCycleLink> WardCycleLinks
        {
        get { return mWardCycleLinks; }
        }
    
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        