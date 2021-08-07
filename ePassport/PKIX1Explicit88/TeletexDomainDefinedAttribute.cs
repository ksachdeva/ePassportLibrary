
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
    [ASN1Sequence(Name = "TeletexDomainDefinedAttribute", IsSet = false)]
    public class TeletexDomainDefinedAttribute : IASN1PreparedElement 
    {
        
        private string type_;
        
		[ASN1String(Name = "", StringType = UniversalTags.TeletexString, IsUCS = false)]
		[ASN1ValueRangeConstraint(Min = 1, Max = 8)]
		[ASN1Element(Name = "type", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public string Type
        {
            get { return type_; }
            set { type_ = value;  }
        }
  
        private string value_;
        
		[ASN1String(Name = "", StringType = UniversalTags.TeletexString, IsUCS = false)]
		[ASN1ValueRangeConstraint(Min = 1, Max = 128)]
		[ASN1Element(Name = "value", IsOptional = false, HasTag = false, HasDefaultValue = false)]
        public string Value
        {
            get { return value_; }
            set { value_ = value;  }
        }
  

        public void initWithDefaults() 
        {
            
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(TeletexDomainDefinedAttribute));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}