using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Clinical;

public class Immunization : DomainResourceBase
{
    public override string ResourceType => "Immunization";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? VaccineCode { get; set; }
    public Reference? Patient { get; set; }
    public DateTime? OccurrenceDateTime { get; set; }
    public Reference? Location { get; set; }
    public List<Annotation>? Note { get; set; }
}