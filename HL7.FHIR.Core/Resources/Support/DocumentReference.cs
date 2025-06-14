using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;

public class DocumentReference : DomainResourceBase
{
    public override string ResourceType => "DocumentReference";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; } // current | superseded | entered-in-error
    public string? DocStatus { get; set; } // preliminary | final | amended | entered-in-error

    public CodeableConcept? Type { get; set; }
    public List<CodeableConcept>? Category { get; set; }

    public Reference? Subject { get; set; }
    public DateTime? Date { get; set; }

    public List<Reference>? Author { get; set; }
    public Reference? Authenticator { get; set; }
    public Reference? Custodian { get; set; }

    public List<DocumentReferenceRelatesTo>? RelatesTo { get; set; }
    public string? Description { get; set; }

    public List<CodeableConcept>? SecurityLabel { get; set; }
    public List<DocumentReferenceContent>? Content { get; set; }

    public DocumentReferenceContext? Context { get; set; }
}

public class DocumentReferenceRelatesTo
{
    public string? Code { get; set; } // replaces | transforms | signs | appends
    public Reference? Target { get; set; }
}

public class DocumentReferenceContent
{
    public Attachment? Attachment { get; set; }
    public CodeableConcept? Format { get; set; }
}

public class DocumentReferenceContext
{
    public List<Reference>? Encounter { get; set; }
    public List<CodeableConcept>? Event { get; set; }
    public Period? Period { get; set; }
    public CodeableConcept? FacilityType { get; set; }
    public CodeableConcept? PracticeSetting { get; set; }
    public Reference? SourcePatientInfo { get; set; }
}