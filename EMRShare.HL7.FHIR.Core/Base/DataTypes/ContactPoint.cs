namespace HL7.FHIR.Core.Base.DataTypes;

public class ContactPoint
{
    public string? System { get; set; }
    public string? Value { get; set; }
    public string? Use { get; set; }
    public int? Rank { get; set; }
    public Period? Period { get; set; }
}