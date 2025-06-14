using HL7.FHIR.Core.Base.Abstract;

namespace HL7.FHIR.Core.Resources.Infrastructure;

public class SearchParameter : DomainResourceBase
{
    public override string ResourceType => "SearchParameter";

    public string? Url { get; set; }
    public string? Name { get; set; }
    public string? Status { get; set; }
    public string? Code { get; set; }
    public string? Base { get; set; }
    public string? Type { get; set; }
    public string? Description { get; set; }
}