using HL7.FHIR.Core.Base.Abstract;

namespace HL7.FHIR.DLL.Factories;

public class BundleEntryFactory
{
    public BundleEntry Create(ResourceBase resource)
    {
        return new BundleEntry
        {
            FullUrl = $"urn:uuid:{resource.Id}",
            Resource = resource
        };
    }
}