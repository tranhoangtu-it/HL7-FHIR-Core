using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Support;

public class CommunicationRequest : DomainResourceBase
{
    public override string ResourceType => "CommunicationRequest";

    public List<Identifier>? Identifier { get; set; }

    public string? Status { get; set; }
    public CodeableConcept? StatusReason { get; set; }
    public CodeableConcept? Intent { get; set; }
    public CodeableConcept? Priority { get; set; }

    public List<CodeableConcept>? Category { get; set; }
    public List<CodeableConcept>? Medium { get; set; }

    public Reference? Subject { get; set; }
    public List<Reference>? About { get; set; }
    public Reference? Encounter { get; set; }

    public List<CommunicationRequestPayload>? Payload { get; set; }

    public DateTime? OccurrenceDateTime { get; set; }
    public Period? OccurrencePeriod { get; set; }

    public DateTime? AuthoredOn { get; set; }
    public Reference? Requester { get; set; }
    public List<Reference>? Recipient { get; set; }
    public Reference? Sender { get; set; }

    public List<CodeableConcept>? ReasonCode { get; set; }
    public List<Annotation>? Note { get; set; }
}

public class CommunicationRequestPayload
{
    public string? ContentString { get; set; }
    public Attachment? ContentAttachment { get; set; }
    public Reference? ContentReference { get; set; }
}