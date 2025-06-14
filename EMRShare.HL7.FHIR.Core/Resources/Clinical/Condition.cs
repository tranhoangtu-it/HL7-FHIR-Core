using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Clinical;

public class Condition : DomainResourceBase
{
    public override string ResourceType => "Condition";

    public List<Identifier>? Identifier { get; set; }
    public string? ClinicalStatus { get; set; }
    public string? VerificationStatus { get; set; }
    public CodeableConcept? Category { get; set; }
    public CodeableConcept? Code { get; set; }
    public Reference? Subject { get; set; }
    public Reference? Encounter { get; set; }
    public DateTime? OnsetDateTime { get; set; }
    public DateTime? AbatementDateTime { get; set; }
    public DateTime? RecordedDate { get; set; }
    public Reference? Recorder { get; set; }
}