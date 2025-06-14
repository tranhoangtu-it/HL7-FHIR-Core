using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Infrastructure;

public class CapabilityStatement : DomainResourceBase
{
    public override string ResourceType => "CapabilityStatement";

    public string? Url { get; set; }
    public string? Version { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public string? Experimental { get; set; }
    public string? Publisher { get; set; }
    public string? Description { get; set; }
    public string? Kind { get; set; }
    public List<CapabilityRest>? Rest { get; set; }
}