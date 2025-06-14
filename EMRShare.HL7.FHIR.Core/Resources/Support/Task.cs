using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Support;

public class Task : DomainResourceBase
{
    public override string ResourceType => "Task";

    public List<Identifier>? Identifier { get; set; }
    public List<Reference>? BasedOn { get; set; }
    public Identifier? GroupIdentifier { get; set; }
    public List<Reference>? PartOf { get; set; }

    public string? Status { get; set; }
    public CodeableConcept? StatusReason { get; set; }
    public CodeableConcept? BusinessStatus { get; set; }

    public CodeableConcept? Intent { get; set; }
    public CodeableConcept? Priority { get; set; }
    public CodeableConcept? Code { get; set; }

    public string? Description { get; set; }

    public Reference? Focus { get; set; }
    public Reference? For { get; set; }
    public Reference? Encounter { get; set; }

    public Period? ExecutionPeriod { get; set; }

    public DateTime? AuthoredOn { get; set; }
    public DateTime? LastModified { get; set; }

    public Reference? Requester { get; set; }
    public Reference? Owner { get; set; }
    public List<CodeableConcept>? PerformerType { get; set; }

    public CodeableConcept? ReasonCode { get; set; }
    public Reference? ReasonReference { get; set; }

    public List<Annotation>? Note { get; set; }
    public List<Reference>? RelevantHistory { get; set; }

    public TaskRestriction? Restriction { get; set; }
    public List<TaskInput>? Input { get; set; }
    public List<TaskOutput>? Output { get; set; }
}

public class TaskRestriction
{
    public int? Repetitions { get; set; }
    public Period? Period { get; set; }
    public List<Reference>? Recipient { get; set; }
}

public class TaskInput
{
    public CodeableConcept? Type { get; set; }
    public string? ValueString { get; set; } // polymorphic
    public Reference? ValueReference { get; set; }
    public Coding? ValueCoding { get; set; }
    public DateTime? ValueDateTime { get; set; }
}

public class TaskOutput
{
    public CodeableConcept? Type { get; set; }
    public string? ValueString { get; set; }
    public Reference? ValueReference { get; set; }
    public Coding? ValueCoding { get; set; }
    public DateTime? ValueDateTime { get; set; }
}