using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;
public class AuditEventEntity
{
    public Identifier? What { get; set; }
    public string? Role { get; set; }
    public string? Lifecycle { get; set; }
    public List<Coding>? SecurityLabel { get; set; }
    public string? Name { get; set; }
    public string? Description { get; set; }
}