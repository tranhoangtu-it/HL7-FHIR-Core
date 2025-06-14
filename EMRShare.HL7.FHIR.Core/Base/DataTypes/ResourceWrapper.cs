using HL7.FHIR.Core.Interfaces;

public class ResourceWrapper
{
    public string? ResourceType { get; set; }
    public IResource? Resource { get; set; }
}
