using HL7.FHIR.Core.Base.Abstract;

public class Binary : ResourceBase
{
    public string? ContentType { get; set; }
    public byte[]? Content { get; set; }
    public override string ResourceType => "Binary";
}
