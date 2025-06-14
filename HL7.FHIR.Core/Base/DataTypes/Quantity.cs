namespace HL7.FHIR.Core.Base.DataTypes;

public class Quantity
{
    public decimal? Value { get; set; }
    public string? Unit { get; set; }
    public string? System { get; set; }
    public string? Code { get; set; }
}