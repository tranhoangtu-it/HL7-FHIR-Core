using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Financial;

public class Coverage : DomainResourceBase
{
    public override string ResourceType => "Coverage";

    public Identifier? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Type { get; set; }
    public Reference? PolicyHolder { get; set; }
    public Reference? Subscriber { get; set; }
    public string? SubscriberId { get; set; }
    public Reference? Beneficiary { get; set; }
    public CodeableConcept? Relationship { get; set; }
    public Period? Period { get; set; }
    public Reference? Payor { get; set; }
}