
//
// This file was generated by the BinaryNotes compiler (created by Abdulla Abdurakhmanov, modified by Sylvain Prevost).
// See http://bnotes.sourceforge.net 
// Any modifications to this file will be lost upon recompilation of the source ASN.1. 
//

using System;
using System.Numerics;

using org.bn.attributes;
using org.bn.attributes.constraints;
using org.bn.coders;
using org.bn.types;
using org.bn;

namespace ePassport {


    [ASN1PreparedElement]
    [ASN1Sequence(Name = "KeyAgreeRecipientInfo", IsSet = false)]
    public class KeyAgreeRecipientInfo : IASN1PreparedElement 
    {
        
        private CMSVersion version_;
        
		[ASN1Element(Name = "version", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public CMSVersion Version
        {
            get { return version_; }
            set { version_ = value;  }
        }
  
        private OriginatorIdentifierOrKey originator_;
        
		[ASN1Element(Name = "originator", IsOptional = false, HasTag = true, Tag = 0, IsImplicitTag = false, HasDefaultValue = false)]
        public OriginatorIdentifierOrKey Originator
        {
            get { return originator_; }
            set { originator_ = value;  }
        }
  
        private UserKeyingMaterial ukm_;
        
        private bool  ukm_present = false;
        
		[ASN1Element(Name = "ukm", IsOptional = true, HasTag = true, Tag = 1, IsImplicitTag = false, HasDefaultValue = false)]
        public UserKeyingMaterial Ukm
        {
            get { return ukm_; }
            set { ukm_ = value; ukm_present = true;  }
        }
  
        private KeyEncryptionAlgorithmIdentifier keyEncryptionAlgorithm_;
        
		[ASN1Element(Name = "keyEncryptionAlgorithm", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public KeyEncryptionAlgorithmIdentifier KeyEncryptionAlgorithm
        {
            get { return keyEncryptionAlgorithm_; }
            set { keyEncryptionAlgorithm_ = value;  }
        }
  
        private RecipientEncryptedKeys recipientEncryptedKeys_;
        
		[ASN1Element(Name = "recipientEncryptedKeys", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public RecipientEncryptedKeys RecipientEncryptedKeys
        {
            get { return recipientEncryptedKeys_; }
            set { recipientEncryptedKeys_ = value;  }
        }
  
        public bool isUkmPresent()
        {
            return this.ukm_present == true;
        }
        

        public void initWithDefaults() 
        {
            
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(KeyAgreeRecipientInfo));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}