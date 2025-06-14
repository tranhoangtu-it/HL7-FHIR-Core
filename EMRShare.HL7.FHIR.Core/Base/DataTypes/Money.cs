using System;
using System.ComponentModel.DataAnnotations;
using HL7.FHIR.Core.Base; // giả định bạn có Element, Extension, v.v.

namespace HL7.FHIR.Core.DataTypes
{
    /// <summary>
    /// An amount of economic utility in some recognized currency
    /// </summary>
    public class Money : Element
    {
        /// <summary>
        /// Numerical value (with implicit precision)
        /// Cardinality: 0..1
        /// </summary>
        public decimal? Value { get; set; }

        /// <summary>
        /// ISO 4217 Currency Code
        /// Cardinality: 0..1
        /// </summary>
        public string? Currency { get; set; }
    }
}