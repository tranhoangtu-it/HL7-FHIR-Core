using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Base.Abstract;

public abstract class ElementBase
{
    public string? Id { get; set; }
    public List<Extension>? Extension { get; set; }
}