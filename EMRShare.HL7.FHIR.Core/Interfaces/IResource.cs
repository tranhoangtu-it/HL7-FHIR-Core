namespace HL7.FHIR.Core.Interfaces;

public interface IResource
{
    string Id { get; set; }
    string ResourceType { get; }
}
