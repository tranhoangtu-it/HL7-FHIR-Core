using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Diagnostic;

public class ImagingStudy : DomainResourceBase
{
    public override string ResourceType => "ImagingStudy";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public List<Coding>? Modality { get; set; }
    public Reference? Subject { get; set; }
    public DateTime? Started { get; set; }
    public string? Description { get; set; }
    public int? NumberOfSeries { get; set; }
    public int? NumberOfInstances { get; set; }
}