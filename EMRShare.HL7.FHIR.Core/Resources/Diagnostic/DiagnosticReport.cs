using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Diagnostic;

public class DiagnosticReport : DomainResourceBase
{
    public override string ResourceType => "DiagnosticReport";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public List<CodeableConcept>? Category { get; set; }
    public CodeableConcept? Code { get; set; }
    public Reference? Subject { get; set; }
    public Reference? Encounter { get; set; }
    public DateTime? EffectiveDateTime { get; set; }
    public Period? EffectivePeriod { get; set; }
    public DateTime? Issued { get; set; }
    public List<Reference>? Performer { get; set; }
    public List<Reference>? Result { get; set; }
    public string? Conclusion { get; set; }
    public List<CodeableConcept>? ConclusionCode { get; set; }
    public List<Attachment>? PresentedForm { get; set; }
}