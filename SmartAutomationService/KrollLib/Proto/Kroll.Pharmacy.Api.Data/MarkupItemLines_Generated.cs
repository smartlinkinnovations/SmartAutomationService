
        // Generated from: MarkupItemLines.proto
        // Note: requires additional types generated from: MarkupItemLineAction_Enum.proto
        // Note: requires additional types generated from: MarkupItemLineType_Enum.proto
        // Note: requires additional types generated from: MarkupBasedOn_Enum.proto
        // Note: requires additional types generated from: MarkupAddTo_Enum.proto
        // Note: requires additional types generated from: CentralMaintLink.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"MarkupItemLines")]
        public partial class MarkupItemLines : global::ProtoBuf.IExtensible
        {
        public MarkupItemLines() {}
        

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

        private int mMarkupItemId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"MarkupItemId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int MarkupItemId
        {
        get { return mMarkupItemId; }
        set { mMarkupItemId = value; }
        }

        private int mSeq
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"Seq", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int Seq
        {
        get { return mSeq; }
        set { mSeq = value; }
        }

        private double mGreaterThanValue
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"GreaterThanValue", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double GreaterThanValue
        {
        get { return mGreaterThanValue; }
        set { mGreaterThanValue = value; }
        }

        private Kroll.Pharmacy.Api.Data.MarkupItemLineAction mAddSubSet
            = Kroll.Pharmacy.Api.Data.MarkupItemLineAction.MarkupItemLineAction_Add;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"AddSubSet", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MarkupItemLineAction.MarkupItemLineAction_Add)]
        
        public Kroll.Pharmacy.Api.Data.MarkupItemLineAction AddSubSet
        {
        get { return mAddSubSet; }
        set { mAddSubSet = value; }
        }

        private Kroll.Pharmacy.Api.Data.MarkupItemLineType mMarkupType
            = Kroll.Pharmacy.Api.Data.MarkupItemLineType.MarkupItemLineType_Dollars;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"MarkupType", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MarkupItemLineType.MarkupItemLineType_Dollars)]
        
        public Kroll.Pharmacy.Api.Data.MarkupItemLineType MarkupType
        {
        get { return mMarkupType; }
        set { mMarkupType = value; }
        }

        private double mMarkupAmount
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"MarkupAmount", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double MarkupAmount
        {
        get { return mMarkupAmount; }
        set { mMarkupAmount = value; }
        }

        private Kroll.Pharmacy.Api.Data.CentralMaintLink mCentralMaintLink
            = null;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"CentralMaintLink", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(null)]
        
        public Kroll.Pharmacy.Api.Data.CentralMaintLink CentralMaintLink
        {
        get { return mCentralMaintLink; }
        set { mCentralMaintLink = value; }
        }

        private int mCentralMaintFieldMask
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"CentralMaintFieldMask", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int CentralMaintFieldMask
        {
        get { return mCentralMaintFieldMask; }
        set { mCentralMaintFieldMask = value; }
        }

        private Kroll.Pharmacy.Api.Data.MarkupBasedOn mBasedOn
            = Kroll.Pharmacy.Api.Data.MarkupBasedOn.MarkupBasedOn_BaseCost;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"BasedOn", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MarkupBasedOn.MarkupBasedOn_BaseCost)]
        
        public Kroll.Pharmacy.Api.Data.MarkupBasedOn BasedOn
        {
        get { return mBasedOn; }
        set { mBasedOn = value; }
        }

        private Kroll.Pharmacy.Api.Data.MarkupAddTo mAddTo
            = Kroll.Pharmacy.Api.Data.MarkupAddTo.MarkupAddTo_Markup;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"AddTo", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(Kroll.Pharmacy.Api.Data.MarkupAddTo.MarkupAddTo_Markup)]
        
        public Kroll.Pharmacy.Api.Data.MarkupAddTo AddTo
        {
        get { return mAddTo; }
        set { mAddTo = value; }
        }

        private int mLinkedPrcStratId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"LinkedPrcStratId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int LinkedPrcStratId
        {
        get { return mLinkedPrcStratId; }
        set { mLinkedPrcStratId = value; }
        }

        private bool mLinkedPrcStratIdSpecified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"LinkedPrcStratIdSpecified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool LinkedPrcStratIdSpecified
        {
        get { return mLinkedPrcStratIdSpecified; }
        set { mLinkedPrcStratIdSpecified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        