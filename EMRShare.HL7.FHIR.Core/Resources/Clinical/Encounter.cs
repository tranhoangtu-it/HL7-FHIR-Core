using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Clinical;

public class Encounter : DomainResourceBase
{
    public override string ResourceType => "Encounter";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public List<CodeableConcept>? Type { get; set; }
    public CodeableConcept? Class { get; set; }
    public Reference? Subject { get; set; }
    public Period? Period { get; set; }
    public Reference? ServiceProvider { get; set; }
}