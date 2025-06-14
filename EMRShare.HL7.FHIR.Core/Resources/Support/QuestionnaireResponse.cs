using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;

public class QuestionnaireResponse : DomainResourceBase
{
    public override string ResourceType => "QuestionnaireResponse";

    public Identifier? Identifier { get; set; }
    public List<Reference>? BasedOn { get; set; }
    public List<Reference>? PartOf { get; set; }

    public Reference? Questionnaire { get; set; }
    public string? Status { get; set; } // in-progress | completed | amended | entered-in-error | stopped

    public Reference? Subject { get; set; }
    public Reference? Encounter { get; set; }

    public DateTime? Authored { get; set; }
    public Reference? Author { get; set; }
    public Reference? Source { get; set; }

    public List<QuestionnaireResponseItem>? Item { get; set; }
}

public class QuestionnaireResponseItem
{
    public string? LinkId { get; set; }
    public string? Text { get; set; }

    public List<QuestionnaireResponseAnswer>? Answer { get; set; }
    public List<QuestionnaireResponseItem>? Item { get; set; } // nested
}

public class QuestionnaireResponseAnswer
{
    public bool? ValueBoolean { get; set; }
    public decimal? ValueDecimal { get; set; }
    public int? ValueInteger { get; set; }
    public DateTime? ValueDate { get; set; }
    public string? ValueString { get; set; }
    public Coding? ValueCoding { get; set; }
    public Reference? ValueReference { get; set; }

    public List<QuestionnaireResponseItem>? Item { get; set; } // nested group item
}