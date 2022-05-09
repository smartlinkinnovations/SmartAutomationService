
        // Generated from: DrgMixTime.proto
            namespace Kroll.Pharmacy.Api.Data
            {
        
        [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"DrgMixTime")]
        public partial class DrgMixTime : global::ProtoBuf.IExtensible
        {
        public DrgMixTime() {}
        

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

        private int mDrgMixTimeId
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"DrgMixTimeId", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int DrgMixTimeId
        {
        get { return mDrgMixTimeId; }
        set { mDrgMixTimeId = value; }
        }

        private int mNumberOfComponents
            = 
                default(int)
            ;
        [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"NumberOfComponents", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(int)
            )]
        
        public int NumberOfComponents
        {
        get { return mNumberOfComponents; }
        set { mNumberOfComponents = value; }
        }

        private double mChrgQtyThres1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"ChrgQtyThres1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres1
        {
        get { return mChrgQtyThres1; }
        set { mChrgQtyThres1 = value; }
        }

        private bool mChrgQtyThres1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ChrgQtyThres1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres1Specified
        {
        get { return mChrgQtyThres1Specified; }
        set { mChrgQtyThres1Specified = value; }
        }

        private double mChrgQty1
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"ChrgQty1", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty1
        {
        get { return mChrgQty1; }
        set { mChrgQty1 = value; }
        }

        private bool mChrgQty1Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(7, IsRequired = false, Name=@"ChrgQty1Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty1Specified
        {
        get { return mChrgQty1Specified; }
        set { mChrgQty1Specified = value; }
        }

        private double mChrgQtyThres2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(8, IsRequired = false, Name=@"ChrgQtyThres2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres2
        {
        get { return mChrgQtyThres2; }
        set { mChrgQtyThres2 = value; }
        }

        private bool mChrgQtyThres2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(9, IsRequired = false, Name=@"ChrgQtyThres2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres2Specified
        {
        get { return mChrgQtyThres2Specified; }
        set { mChrgQtyThres2Specified = value; }
        }

        private double mChrgQty2
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(10, IsRequired = false, Name=@"ChrgQty2", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty2
        {
        get { return mChrgQty2; }
        set { mChrgQty2 = value; }
        }

        private bool mChrgQty2Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(11, IsRequired = false, Name=@"ChrgQty2Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty2Specified
        {
        get { return mChrgQty2Specified; }
        set { mChrgQty2Specified = value; }
        }

        private double mChrgQtyThres3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(12, IsRequired = false, Name=@"ChrgQtyThres3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres3
        {
        get { return mChrgQtyThres3; }
        set { mChrgQtyThres3 = value; }
        }

        private bool mChrgQtyThres3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(13, IsRequired = false, Name=@"ChrgQtyThres3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres3Specified
        {
        get { return mChrgQtyThres3Specified; }
        set { mChrgQtyThres3Specified = value; }
        }

        private double mChrgQty3
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(14, IsRequired = false, Name=@"ChrgQty3", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty3
        {
        get { return mChrgQty3; }
        set { mChrgQty3 = value; }
        }

        private bool mChrgQty3Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(15, IsRequired = false, Name=@"ChrgQty3Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty3Specified
        {
        get { return mChrgQty3Specified; }
        set { mChrgQty3Specified = value; }
        }

        private double mChrgQtyThres4
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(16, IsRequired = false, Name=@"ChrgQtyThres4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres4
        {
        get { return mChrgQtyThres4; }
        set { mChrgQtyThres4 = value; }
        }

        private bool mChrgQtyThres4Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(17, IsRequired = false, Name=@"ChrgQtyThres4Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres4Specified
        {
        get { return mChrgQtyThres4Specified; }
        set { mChrgQtyThres4Specified = value; }
        }

        private double mChrgQty4
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(18, IsRequired = false, Name=@"ChrgQty4", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty4
        {
        get { return mChrgQty4; }
        set { mChrgQty4 = value; }
        }

        private bool mChrgQty4Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(19, IsRequired = false, Name=@"ChrgQty4Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty4Specified
        {
        get { return mChrgQty4Specified; }
        set { mChrgQty4Specified = value; }
        }

        private double mChrgQtyThres5
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(20, IsRequired = false, Name=@"ChrgQtyThres5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQtyThres5
        {
        get { return mChrgQtyThres5; }
        set { mChrgQtyThres5 = value; }
        }

        private bool mChrgQtyThres5Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(21, IsRequired = false, Name=@"ChrgQtyThres5Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQtyThres5Specified
        {
        get { return mChrgQtyThres5Specified; }
        set { mChrgQtyThres5Specified = value; }
        }

        private double mChrgQty5
            = 
                default(double)
            ;
        [global::ProtoBuf.ProtoMember(22, IsRequired = false, Name=@"ChrgQty5", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
            [global::System.ComponentModel.DefaultValue(
                default(double)
            )]
        
        public double ChrgQty5
        {
        get { return mChrgQty5; }
        set { mChrgQty5 = value; }
        }

        private bool mChrgQty5Specified
            = 
                default(bool)
            ;
        [global::ProtoBuf.ProtoMember(23, IsRequired = false, Name=@"ChrgQty5Specified", DataFormat = global::ProtoBuf.DataFormat.Default)]
            [global::System.ComponentModel.DefaultValue(
                default(bool)
            )]
        
        public bool ChrgQty5Specified
        {
        get { return mChrgQty5Specified; }
        set { mChrgQty5Specified = value; }
        }
        private global::ProtoBuf.IExtension extensionObject;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
        }
    
            }
        