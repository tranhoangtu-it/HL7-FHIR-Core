using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Base.MetaData;

public class Meta
{
    /// <summary>Version specific identifier</summary>
    public string? VersionId { get; set; }

    /// <summary>Last updated timestamp (instant)</summary>
    public DateTime? LastUpdated { get; set; }

    /// <summary>Source URI where the resource originates</summary>
    public string? Source { get; set; }

    /// <summary>List of profiles this resource claims to conform to</summary>
    public List<string>? Profile { get; set; }

    /// <summary>Security labels (e.g. sensitivity classifications)</summary>
    public List<Coding>? Security { get; set; }

    /// <summary>Tags (e.g. workflow routing, flags)</summary>
    public List<Coding>? Tag { get; set; }
}