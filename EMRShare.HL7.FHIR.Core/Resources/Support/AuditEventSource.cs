using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;
public class AuditEventSource
{
    public string? Site { get; set; }
    public Identifier? Observer { get; set; }
    public List<Coding>? Type { get; set; }
}