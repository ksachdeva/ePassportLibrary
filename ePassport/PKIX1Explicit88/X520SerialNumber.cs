
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
    [ASN1BoxedType(Name = "X520SerialNumber")]
    public class X520SerialNumber: IASN1PreparedElement 
    {

        private String val;

        [ASN1String(Name = "X520SerialNumber", StringType = UniversalTags.PrintableString, IsUCS = false)]
        
		[ASN1ValueRangeConstraint(Min = 1, Max = 64)]
        public String Value
        {
            get { return val; }
            set { val = value; }
        }
        
        public X520SerialNumber() 
        {
        }

        public X520SerialNumber(String val) 
        {
            this.val = val;
        }

        public void initWithDefaults() 
        {
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(X520SerialNumber));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}