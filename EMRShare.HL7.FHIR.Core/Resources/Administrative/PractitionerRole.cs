using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Administrative;

public class PractitionerRole : DomainResourceBase
{
    public override string ResourceType => "PractitionerRole";

    public List<Identifier>? Identifier { get; set; }
    public bool? Active { get; set; }
    public Period? Period { get; set; }
    public Reference? Practitioner { get; set; }
    public Reference? Organization { get; set; }
    public List<CodeableConcept>? Code { get; set; }
    public List<CodeableConcept>? Specialty { get; set; }
    public List<Reference>? Location { get; set; }
    public List<Reference>? HealthcareService { get; set; }
    public List<ContactPoint>? Telecom { get; set; }
    public List<AvailableTime>? AvailableTime { get; set; }
    public List<CodeableConcept>? NotAvailable { get; set; }
    public string? AvailabilityExceptions { get; set; }
}