using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;

public class AuditEventAgent
{
    public bool? Requestor { get; set; }
    public Reference? Who { get; set; }
    public Reference? OnBehalfOf { get; set; }
    public List<CodeableConcept>? Role { get; set; }
    public CodeableConcept? Type { get; set; }
}