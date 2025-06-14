using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;

public class AuditEvent : DomainResourceBase
{
    public override string ResourceType => "AuditEvent";

    public Coding? Type { get; set; }
    public List<Coding>? Subtype { get; set; }
    public string? Action { get; set; } // C | R | U | D | E

    public Period? Period { get; set; }
    public DateTime? Recorded { get; set; }
    public string? Outcome { get; set; } // 0 | 4 | 8 | 12
    public string? OutcomeDesc { get; set; }

    public List<AuditEventAgent>? Agent { get; set; }
    public AuditEventSource? Source { get; set; }
    public List<AuditEventEntity>? Entity { get; set; }
}
