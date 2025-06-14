using System.Collections.Generic;

namespace HL7.FHIR.Core.Base.DataTypes;

public class HumanName
{
    public string? Use { get; set; }
    public string? Text { get; set; }
    public string? Family { get; set; }
    public List<string>? Given { get; set; }
    public List<string>? Prefix { get; set; }
    public List<string>? Suffix { get; set; }
}