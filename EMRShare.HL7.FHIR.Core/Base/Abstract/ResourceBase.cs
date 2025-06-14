using HL7.FHIR.Core.Base.MetaData;
using System.Collections.Generic;

namespace HL7.FHIR.Core.Base.Abstract;

public abstract class ResourceBase
{
    /// <summary>Logical id of this artifact</summary>
    public string Id { get; set; } = Guid.NewGuid().ToString();

    /// <summary>Metadata about the resource</summary>
    public Meta? Meta { get; set; }

    /// <summary>FHIR resource type name (overridden per resource)</summary>
    public abstract string ResourceType { get; }

    /// <summary>Language of resource (ISO 639-1)</summary>
    public string? Language { get; set; }
}