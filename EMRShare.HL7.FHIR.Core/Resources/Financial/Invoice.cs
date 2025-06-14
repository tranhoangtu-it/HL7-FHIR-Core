using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.DataTypes;

namespace HL7.FHIR.Core.Resources.Financial;

public class Invoice : DomainResourceBase
{
    public override string ResourceType => "Invoice";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Type { get; set; }
    public Reference? Subject { get; set; }
    public Reference? Issuer { get; set; }
    public DateTime? Date { get; set; }
    public Money? TotalGross { get; set; }
    public Money? TotalNet { get; set; }
}