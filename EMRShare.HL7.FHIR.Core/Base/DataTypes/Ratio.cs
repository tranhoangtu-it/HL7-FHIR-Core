namespace HL7.FHIR.Core.Base.DataTypes;

public class Ratio
{
    public string? Id { get; set; }
    public List<Extension>? Extension { get; set; }
    public Quantity? Numerator { get; set; }
    public Quantity? Denominator { get; set; }
}