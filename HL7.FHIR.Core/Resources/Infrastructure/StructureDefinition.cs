using HL7.FHIR.Core.Base.Abstract;

namespace HL7.FHIR.Core.Resources.Infrastructure;

public class StructureDefinition : DomainResourceBase
{
    public override string ResourceType => "StructureDefinition";

    public string? Url { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Status { get; set; }
    public string? Kind { get; set; }
    public string? Abstract { get; set; }
    public string? Type { get; set; }
}