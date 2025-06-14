using System.Collections.Generic;

namespace HL7.FHIR.Core.Base.DataTypes;

public class Address
{
    public string? Use { get; set; }
    public string? Type { get; set; }
    public string? Text { get; set; }
    public List<string>? Line { get; set; }
    public string? City { get; set; }
    public string? District { get; set; }
    public string? State { get; set; }
    public string? PostalCode { get; set; }
    public string? Country { get; set; }
    public Period? Period { get; set; }
}