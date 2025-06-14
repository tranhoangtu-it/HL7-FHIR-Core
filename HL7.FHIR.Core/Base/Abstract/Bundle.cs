using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Base.Abstract;

public class Bundle : ResourceBase
{
    public override string ResourceType => "Bundle";

    public Identifier? Identifier { get; set; }
    public string? Type { get; set; } // document | message | transaction | ...

    public DateTime? Timestamp { get; set; }

    public List<BundleEntry> Entry { get; set; } = new();
}
