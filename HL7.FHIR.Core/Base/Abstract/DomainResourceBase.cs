using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Base.Abstract;

public abstract class DomainResourceBase : ResourceBase
{
    /// <summary>Text summary of the resource for human interpretation</summary>
    public Narrative? Text { get; set; }

    /// <summary>Contained resources (inline)</summary>
    public List<ResourceBase>? Contained { get; set; }

    /// <summary>Extensions that cannot be ignored</summary>
    public List<Extension>? Extension { get; set; }

    /// <summary>Modifier extensions</summary>
    public List<Extension>? ModifierExtension { get; set; }
}