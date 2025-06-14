using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;
using HL7.FHIR.Core.Enums;

namespace HL7.FHIR.Core.Resources.Clinical;

public class Observation : DomainResourceBase
{
    public override string ResourceType => "Observation";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public List<CodeableConcept>? Category { get; set; }
    public CodeableConcept? Code { get; set; }
    public Reference? Subject { get; set; }
    public DateTime? EffectiveDateTime { get; set; }
    public CodeableConcept? ValueCodeableConcept { get; set; }
    public Quantity? ValueQuantity { get; set; }
    public string? ValueString { get; set; }
    public List<Annotation>? Note { get; set; }
}