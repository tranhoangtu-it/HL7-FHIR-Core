using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;

public class Provenance : DomainResourceBase
{
    public override string ResourceType => "Provenance";

    public List<Reference>? Target { get; set; }

    public DateTime? OccurredDateTime { get; set; }
    public Period? OccurredPeriod { get; set; }

    public DateTime? Recorded { get; set; }

    public List<string>? Policy { get; set; }
    public Reference? Location { get; set; }
    public List<CodeableConcept>? Reason { get; set; }
    public CodeableConcept? Activity { get; set; }

    public List<ProvenanceAgent>? Agent { get; set; }
    public List<ProvenanceEntity>? Entity { get; set; }

    public List<Signature>? Signature { get; set; }
}

public class ProvenanceAgent
{
    public CodeableConcept? Type { get; set; }
    public CodeableConcept? Role { get; set; }
    public Reference? Who { get; set; }
    public Reference? OnBehalfOf { get; set; }
}

public class ProvenanceEntity
{
    public string? Role { get; set; } // derivation | revision | quotation | source | removal
    public Reference? What { get; set; }
    public ProvenanceAgent? Agent { get; set; }
}