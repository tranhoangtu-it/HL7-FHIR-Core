namespace HL7.FHIR.Core.Base.Abstract;

public class BundleEntry
{
    public string? FullUrl { get; set; } // "urn:uuid:..."
    public ResourceBase? Resource { get; set; }
}