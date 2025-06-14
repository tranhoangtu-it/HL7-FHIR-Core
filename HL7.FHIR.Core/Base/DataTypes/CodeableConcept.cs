namespace HL7.FHIR.Core.Base.DataTypes;

public class CodeableConcept
{
    public List<Coding>? Coding { get; set; }
    public string? Text { get; set; }
}