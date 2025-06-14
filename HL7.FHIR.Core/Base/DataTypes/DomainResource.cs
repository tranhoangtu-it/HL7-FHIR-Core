using HL7.FHIR.Core.Base.Abstract;

public abstract class DomainResource : ResourceBase
{
    public Narrative? Text { get; set; }
}
