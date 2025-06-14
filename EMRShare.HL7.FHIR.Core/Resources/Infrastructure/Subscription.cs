using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Infrastructure;

public class Subscription : DomainResourceBase
{
    public override string ResourceType => "Subscription";

    public string? Status { get; set; }
    public string? Criteria { get; set; }
    public string? Reason { get; set; }
    public string? Endpoint { get; set; }
    public string? Payload { get; set; }
    public string? Header { get; set; }
}