namespace HL7.FHIR.Core.Interfaces;

public interface IDomainResource : IResource
{
    string? Text { get; set; } // Could point to Narrative or summary
}