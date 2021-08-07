
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
    [ASN1Sequence(Name = "EDIPartyName", IsSet = false)]
    public class EDIPartyName : IASN1PreparedElement 
    {
        
        private DirectoryString nameAssigner_;
        
        private bool  nameAssigner_present = false;
        
		[ASN1Element(Name = "nameAssigner", IsOptional = true, HasTag = true, Tag = 0, HasDefaultValue = false)]
        public DirectoryString NameAssigner
        {
            get { return nameAssigner_; }
            set { nameAssigner_ = value; nameAssigner_present = true;  }
        }
  
        private DirectoryString partyName_;
        
		[ASN1Element(Name = "partyName", IsOptional = false, HasTag = true, Tag = 1, HasDefaultValue = false)]
        public DirectoryString PartyName
        {
            get { return partyName_; }
            set { partyName_ = value;  }
        }
  
        public bool isNameAssignerPresent()
        {
            return this.nameAssigner_present == true;
        }
        

        public void initWithDefaults() 
        {
            
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(EDIPartyName));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}