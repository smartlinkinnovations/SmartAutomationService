
        // Generated from: MarkupItem.proto
        // Note: requires additional types generated from: MarkupBasedOn_Enum.proto
        // Note: requires additional types generated from: MarkupAddTo_Enum.proto
        // Note: requires additional types generated from: PriceLevel_Enum.proto
        // Note: requires additional types generated from: MarkupItemLines.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MarkupItem")]
        public partial class MarkupItem : global::ProtoBuf.IExtensible
        {
        public MarkupItem() {}
        

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

        private int mPrcStratId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"PrcStratId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int PrcStratId
        {
        get { return mPrcStratId; }
        set { mPrcStratId = value; }
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

        private Kroll.Pharmacy.Api.Data.MarkupBasedOn mBasedOn
            = Kroll.Pharmacy.Api.Data.MarkupBasedOn.MarkupBasedOn_BaseCost;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"BasedOn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MarkupBasedOn.MarkupBasedOn_BaseCost)]
        
        public Kroll.Pharmacy.Api.Data.MarkupBasedOn BasedOn
        {
        get { return mBasedOn; }
        set { mBasedOn = value; }
        }

        private Kroll.Pharmacy.Api.Data.MarkupAddTo mAddTo
            = Kroll.Pharmacy.Api.Data.MarkupAddTo.MarkupAddTo_Markup;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AddTo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MarkupAddTo.MarkupAddTo_Markup)]
        
        public Kroll.Pharmacy.Api.Data.MarkupAddTo AddTo
        {
        get { return mAddTo; }
        set { mAddTo = value; }
        }

        private Kroll.Pharmacy.Api.Data.PriceLevel mDifCostBase
            = Kroll.Pharmacy.Api.Data.PriceLevel.PriceLevel_Unknown;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"DifCostBase", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PriceLevel.PriceLevel_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PriceLevel DifCostBase
        {
        get { return mDifCostBase; }
        set { mDifCostBase = value; }
        }

        private Kroll.Pharmacy.Api.Data.PriceLevel mDifCostMarkup
            = Kroll.Pharmacy.Api.Data.PriceLevel.PriceLevel_Unknown;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"DifCostMarkup", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.PriceLevel.PriceLevel_Unknown)]
        
        public Kroll.Pharmacy.Api.Data.PriceLevel DifCostMarkup
        {
        get { return mDifCostMarkup; }
        set { mDifCostMarkup = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }
        private readonly global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MarkupItemLines> mMarkupItemLines = new global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MarkupItemLines>();
        [global::ProtoBuf.ProtoMember(11, Name=@"MarkupItemLines", DataFormat = global::ProtoBuf.DataFormat.Default)]
        public global::System.Collections.Generic.List<Kroll.Pharmacy.Api.Data.MarkupItemLines> MarkupItemLines
        {
        get { return mMarkupItemLines; }
        }
    

        private int mSequence
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"Sequence", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Sequence
        {
        get { return mSequence; }
        set { mSequence = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        