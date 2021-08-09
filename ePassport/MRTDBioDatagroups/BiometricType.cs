
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
    [ASN1Enum ( Name = "BiometricType")]
    public class BiometricType : IASN1PreparedElement 
    {
        public enum EnumType 
        {
            
            [ASN1EnumItem ( Name = "multiple", HasTag = true , Tag = 1 )]
            multiple , 
            [ASN1EnumItem ( Name = "facialFeatures", HasTag = true , Tag = 2 )]
            facialFeatures , 
            [ASN1EnumItem ( Name = "voice", HasTag = true , Tag = 4 )]
            voice , 
            [ASN1EnumItem ( Name = "fingerPrint", HasTag = true , Tag = 8 )]
            fingerPrint , 
            [ASN1EnumItem ( Name = "iris", HasTag = true , Tag = 16 )]
            iris , 
            [ASN1EnumItem ( Name = "retina", HasTag = true , Tag = 32 )]
            retina , 
            [ASN1EnumItem ( Name = "handGeometry", HasTag = true , Tag = 64 )]
            handGeometry , 
            [ASN1EnumItem ( Name = "signatureDynamics", HasTag = true , Tag = 128 )]
            signatureDynamics , 
            [ASN1EnumItem ( Name = "keystrokDynamics", HasTag = true , Tag = 256 )]
            keystrokDynamics , 
            [ASN1EnumItem ( Name = "lipMovement", HasTag = true , Tag = 512 )]
            lipMovement , 
            [ASN1EnumItem ( Name = "thermalFaceImage", HasTag = true , Tag = 1024 )]
            thermalFaceImage , 
            [ASN1EnumItem ( Name = "thermalHandImage", HasTag = true , Tag = 2048 )]
            thermalHandImage , 
            [ASN1EnumItem ( Name = "gait", HasTag = true , Tag = 4096 )]
            gait , 
            [ASN1EnumItem ( Name = "bodyOdor", HasTag = true , Tag = 8192 )]
            bodyOdor , 
            [ASN1EnumItem ( Name = "dna", HasTag = true , Tag = 16384 )]
            dna , 
            [ASN1EnumItem ( Name = "earShape", HasTag = true , Tag = 32768 )]
            earShape , 
            [ASN1EnumItem ( Name = "fingerGeometry", HasTag = true , Tag = 65536 )]
            fingerGeometry , 
            [ASN1EnumItem ( Name = "palmGeometry", HasTag = true , Tag = 131072 )]
            palmGeometry , 
            [ASN1EnumItem ( Name = "veinPattern", HasTag = true , Tag = 262144 )]
            veinPattern
        }
        
        private EnumType val;
        
        public EnumType Value
        {
            get { return val; }
            set { val = value; }
        }

        public void initWithDefaults()
        {
        }

        private static IASN1PreparedElementData preparedData = CoderFactory.getInstance().newPreparedElementData(typeof(BiometricType));
        public IASN1PreparedElementData PreparedData 
        {
            get { return preparedData; }
        }

    }
            
}
