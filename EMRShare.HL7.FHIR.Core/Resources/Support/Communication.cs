using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Support;

public class Communication : DomainResourceBase
{
    public override string ResourceType => "Communication";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? StatusReason { get; set; }

    public List<CodeableConcept>? Category { get; set; }
    public List<CodeableConcept>? Medium { get; set; }

    public Reference? Subject { get; set; }
    public Reference? Topic { get; set; }
    public List<Reference>? About { get; set; }

    public Reference? Encounter { get; set; }

    public DateTime? Sent { get; set; }
    public DateTime? Received { get; set; }

    public Reference? Sender { get; set; }
    public List<Reference>? Recipient { get; set; }

    public List<CommunicationPayload>? Payload { get; set; }

    public List<CodeableConcept>? ReasonCode { get; set; }
    public List<Reference>? ReasonReference { get; set; }

    public List<Annotation>? Note { get; set; }
}

public class CommunicationPayload
{
    public string? ContentString { get; set; }
    public Attachment? ContentAttachment { get; set; }
    public Reference? ContentReference { get; set; }
}