﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;

/*
  Copyright (c) 2011-2013, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated on Thu, Oct 23, 2014 14:22+0200 for FHIR v0.0.82
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A homogeneous material with a definite composition
    /// </summary>
    [FhirType("Substance", IsResource=true)]
    [DataContract]
    public partial class Substance : Hl7.Fhir.Model.Resource, System.ComponentModel.INotifyPropertyChanged
    {
        [FhirType("SubstanceIngredientComponent")]
        [DataContract]
        public partial class SubstanceIngredientComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Optional amount (concentration)
            /// </summary>
            [FhirElement("quantity", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Ratio Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            private Hl7.Fhir.Model.Ratio _Quantity;
            
            /// <summary>
            /// A component of the substance
            /// </summary>
            [FhirElement("substance", InSummary=true, Order=50)]
            [References("Substance")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Substance
            {
                get { return _Substance; }
                set { _Substance = value; OnPropertyChanged("Substance"); }
            }
            private Hl7.Fhir.Model.ResourceReference _Substance;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstanceIngredientComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.Ratio)Quantity.DeepCopy();
                    if(Substance != null) dest.Substance = (Hl7.Fhir.Model.ResourceReference)Substance.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SubstanceIngredientComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstanceIngredientComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.Matches(Substance, otherT.Substance)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstanceIngredientComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                if( !DeepComparable.IsExactly(Substance, otherT.Substance)) return false;
                
                return true;
            }
            
        }
        
        
        [FhirType("SubstanceInstanceComponent")]
        [DataContract]
        public partial class SubstanceInstanceComponent : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
        {
            /// <summary>
            /// Identifier of the package/container
            /// </summary>
            [FhirElement("identifier", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            private Hl7.Fhir.Model.Identifier _Identifier;
            
            /// <summary>
            /// When no longer valid to use
            /// </summary>
            [FhirElement("expiry", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirDateTime ExpiryElement
            {
                get { return _ExpiryElement; }
                set { _ExpiryElement = value; OnPropertyChanged("ExpiryElement"); }
            }
            private Hl7.Fhir.Model.FhirDateTime _ExpiryElement;
            
            /// <summary>
            /// When no longer valid to use
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Expiry
            {
                get { return ExpiryElement != null ? ExpiryElement.Value : null; }
                set
                {
                    if(value == null)
                      ExpiryElement = null; 
                    else
                      ExpiryElement = new Hl7.Fhir.Model.FhirDateTime(value);
                    OnPropertyChanged("Expiry");
                }
            }
            
            /// <summary>
            /// Amount of substance in the package
            /// </summary>
            [FhirElement("quantity", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Quantity Quantity
            {
                get { return _Quantity; }
                set { _Quantity = value; OnPropertyChanged("Quantity"); }
            }
            private Hl7.Fhir.Model.Quantity _Quantity;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as SubstanceInstanceComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                    if(ExpiryElement != null) dest.ExpiryElement = (Hl7.Fhir.Model.FhirDateTime)ExpiryElement.DeepCopy();
                    if(Quantity != null) dest.Quantity = (Hl7.Fhir.Model.Quantity)Quantity.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new SubstanceInstanceComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as SubstanceInstanceComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(ExpiryElement, otherT.ExpiryElement)) return false;
                if( !DeepComparable.Matches(Quantity, otherT.Quantity)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as SubstanceInstanceComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(ExpiryElement, otherT.ExpiryElement)) return false;
                if( !DeepComparable.IsExactly(Quantity, otherT.Quantity)) return false;
                
                return true;
            }
            
        }
        
        
        /// <summary>
        /// What kind of substance this is
        /// </summary>
        [FhirElement("type", Order=70)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// Textual description of the substance, comments
        /// </summary>
        [FhirElement("description", Order=80)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Textual description of the substance, comments
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if(value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// If this describes a specific package/container of the substance
        /// </summary>
        [FhirElement("instance", Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.Substance.SubstanceInstanceComponent Instance
        {
            get { return _Instance; }
            set { _Instance = value; OnPropertyChanged("Instance"); }
        }
        private Hl7.Fhir.Model.Substance.SubstanceInstanceComponent _Instance;
        
        /// <summary>
        /// Composition information about the substance
        /// </summary>
        [FhirElement("ingredient", Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Substance.SubstanceIngredientComponent> Ingredient
        {
            get { return _Ingredient; }
            set { _Ingredient = value; OnPropertyChanged("Ingredient"); }
        }
        private List<Hl7.Fhir.Model.Substance.SubstanceIngredientComponent> _Ingredient;
        
        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as Substance;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(Instance != null) dest.Instance = (Hl7.Fhir.Model.Substance.SubstanceInstanceComponent)Instance.DeepCopy();
                if(Ingredient != null) dest.Ingredient = new List<Hl7.Fhir.Model.Substance.SubstanceIngredientComponent>(Ingredient.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new Substance());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as Substance;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(Instance, otherT.Instance)) return false;
            if( !DeepComparable.Matches(Ingredient, otherT.Ingredient)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as Substance;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(Instance, otherT.Instance)) return false;
            if( !DeepComparable.IsExactly(Ingredient, otherT.Ingredient)) return false;
            
            return true;
        }
        
    }
    
}
