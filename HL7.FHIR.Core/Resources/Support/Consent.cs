using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;

public class Consent : DomainResourceBase
{
    public override string ResourceType => "Consent";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; } // draft | active | inactive | entered-in-error

    public CodeableConcept? Scope { get; set; }
    public List<CodeableConcept>? Category { get; set; }

    public Reference? Patient { get; set; }
    public DateTime? DateTime { get; set; }

    public List<Reference>? Performer { get; set; }
    public List<Reference>? Organization { get; set; }

    public ConsentSource? Source { get; set; }

    public List<ConsentPolicy>? Policy { get; set; }
    public CodeableConcept? PolicyRule { get; set; }

    public ConsentProvision? Provision { get; set; }
}

public class ConsentSource
{
    public string? SourceString { get; set; }
    public Reference? SourceReference { get; set; }
    public Attachment? SourceAttachment { get; set; }
}

public class ConsentPolicy
{
    public string? Authority { get; set; }
    public string? Uri { get; set; }
}

public class ConsentProvision
{
    public string? Type { get; set; } // permit | deny
    public Period? Period { get; set; }

    public List<CodeableConcept>? Action { get; set; }
    public List<CodeableConcept>? SecurityLabel { get; set; }
    public List<CodeableConcept>? Purpose { get; set; }

    public List<Reference>? Actor { get; set; }
    public List<CodeableConcept>? Class { get; set; }

    public List<Reference>? Data { get; set; }
    public List<ConsentProvision>? Provision { get; set; }
}