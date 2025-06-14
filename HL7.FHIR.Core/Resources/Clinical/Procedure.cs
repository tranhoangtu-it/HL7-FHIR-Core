using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Clinical;

public class Procedure : DomainResourceBase
{
    public override string ResourceType => "Procedure";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Code { get; set; }
    public Reference? Subject { get; set; }
    public DateTime? PerformedDateTime { get; set; }
    public Period? PerformedPeriod { get; set; }
    public Reference? Encounter { get; set; }
    public List<Annotation>? Note { get; set; }
}