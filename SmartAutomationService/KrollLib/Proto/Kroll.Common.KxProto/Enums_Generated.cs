
        // Generated from: Enums.proto
            namespace Kroll.Common.KxProto.Messages
            {
        
        public enum ContentEncryptionType
        {
        ContentEncryptionType_None = 0
            ,
        ContentEncryptionType_AES_256_CBC = 1
            ,
        ContentEncryptionType_AES_128_CBC = 2
        }
    
        public enum ContentChecksumType
        {
        ContentChecksumType_None = 0
            ,
        ContentChecksumType_HMAC_SHA1 = 1
            ,
        ContentChecksumType_HMAC_SHA256 = 2
            ,
        ContentChecksumType_HMAC_SHA384 = 3
            ,
        ContentChecksumType_HMAC_SHA512 = 4
        }
    
        public enum MessageWrapperSignatureType
        {
        MessageWrapperSignatureType_None = 0
            ,
        MessageWrapperSignatureType_SHA256_RSA_1024 = 1
        }
    
        public enum AsymmetricEncryptionType
        {
        AsymmetricEncryptionType_RSA_1024 = 0
        }
    
            }
        