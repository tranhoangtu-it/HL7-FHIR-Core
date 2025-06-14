namespace HL7.FHIR.Core.Base.DataTypes;

public class Attachment
{
    public string? ContentType { get; set; }
    public string? Language { get; set; }
    public string? Data { get; set; } // base64Binary
    public string? Url { get; set; }
    public int? Size { get; set; }
    public string? Hash { get; set; }
    public string? Title { get; set; }
    public DateTime? Creation { get; set; }
}