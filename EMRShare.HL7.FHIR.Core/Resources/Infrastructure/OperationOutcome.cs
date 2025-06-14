using HL7.FHIR.Core.Base.Abstract;

namespace HL7.FHIR.Core.Resources.Infrastructure;

public class OperationOutcome : ResourceBase
{
    public override string ResourceType => "OperationOutcome";
    public List<IssueComponent>? Issue { get; set; }
}