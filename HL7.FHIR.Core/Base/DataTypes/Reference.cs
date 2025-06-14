namespace HL7.FHIR.Core.Base.DataTypes;

public class Reference
{
    public string? ReferenceValue { get; set; }
    public string? Type { get; set; }
    public Identifier? Identifier { get; set; }
    public string? Display { get; set; }
}