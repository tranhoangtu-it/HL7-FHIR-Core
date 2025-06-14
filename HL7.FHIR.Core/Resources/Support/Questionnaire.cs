using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;

public class Questionnaire : DomainResourceBase
{
    public override string ResourceType => "Questionnaire";

    public string? Url { get; set; }
    public List<Identifier>? Identifier { get; set; }
    public string? Version { get; set; }
    public string? Name { get; set; }
    public string? Title { get; set; }
    public string? Status { get; set; } // draft | active | retired | unknown
    public bool? Experimental { get; set; }

    public List<string>? SubjectType { get; set; } // Patient, Practitioner, etc.

    public DateTime? Date { get; set; }
    public string? Publisher { get; set; }
    public List<ContactDetail>? Contact { get; set; }
    public string? Description { get; set; }
    public List<UsageContext>? UseContext { get; set; }
    public List<CodeableConcept>? Jurisdiction { get; set; }
    public string? Purpose { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public DateTime? LastReviewDate { get; set; }
    public Period? EffectivePeriod { get; set; }

    public List<Coding>? Code { get; set; }
    public List<QuestionnaireItem>? Item { get; set; }
}

public class QuestionnaireItem
{
    public string? LinkId { get; set; }
    public string? Text { get; set; }
    public string? Type { get; set; } // group | display | boolean | decimal | integer | date | string | choice | ...

    public List<EnableWhen>? EnableWhen { get; set; }
    public bool? Required { get; set; }
    public bool? Repeats { get; set; }

    public List<QuestionnaireItem>? Item { get; set; } // Nested items
}

public class EnableWhen
{
    public string? Question { get; set; }
    public string? Operator { get; set; } // = | != | > | < | ...
    public string? AnswerString { get; set; }
    public bool? AnswerBoolean { get; set; }
    public int? AnswerInteger { get; set; }
    public DateTime? AnswerDateTime { get; set; }
    public Coding? AnswerCoding { get; set; }
}