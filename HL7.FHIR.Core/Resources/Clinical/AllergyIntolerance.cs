using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Clinical;

public class AllergyIntolerance : DomainResourceBase
{
    public override string ResourceType => "AllergyIntolerance";

    public List<Identifier>? Identifier { get; set; }
    public string? ClinicalStatus { get; set; }
    public string? VerificationStatus { get; set; }
    public List<CodeableConcept>? Category { get; set; }
    public string? Criticality { get; set; }
    public CodeableConcept? Code { get; set; }
    public Reference? Patient { get; set; }
    public DateTime? OnsetDateTime { get; set; }
    public DateTime? RecordedDate { get; set; }
    public Reference? Recorder { get; set; }
    public Reference? Asserter { get; set; }
    public List<Annotation>? Note { get; set; }
}