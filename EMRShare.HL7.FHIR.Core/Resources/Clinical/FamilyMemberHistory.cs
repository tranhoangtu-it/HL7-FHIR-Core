using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Clinical;

public class FamilyMemberHistory : DomainResourceBase
{
    public override string ResourceType => "FamilyMemberHistory";

    public List<Identifier>? Identifier { get; set; }
    public Reference? Patient { get; set; }
    public DateTime? Date { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Relationship { get; set; }
    public DateTime? BornDate { get; set; }
    public string? Sex { get; set; }
    public List<CodeableConcept>? Condition { get; set; }
}