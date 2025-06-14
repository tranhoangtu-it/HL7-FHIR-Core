using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Core;

public class Composition : DomainResourceBase
{
    public override string ResourceType => "Composition";

    public string? Status { get; set; } // final, preliminary
    public CodeableConcept? Type { get; set; }

    public Reference? Subject { get; set; }
    public DateTime? Date { get; set; }

    public List<Reference>? Author { get; set; }
    public string? Title { get; set; }

    public Reference? Custodian { get; set; }
    public List<CompositionSection>? Section { get; set; }
}

public class CompositionSection
{
    public string? Title { get; set; }

    public CodeableConcept? Code { get; set; } // e.g. LOINC code
    public Narrative? Text { get; set; }

    public List<Reference>? Entry { get; set; } // e.g. Observation, Medication
}