using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Medication;

public class MedicationStatement : DomainResourceBase
{
    public override string ResourceType => "MedicationStatement";

    public List<Identifier>? Identifier { get; set; }
    public List<Reference>? PartOf { get; set; }

    public string? Status { get; set; }
    public CodeableConcept? Category { get; set; }

    public CodeableConcept? MedicationCodeableConcept { get; set; }
    public Reference? MedicationReference { get; set; }

    public Reference? Subject { get; set; }
    public Reference? Encounter { get; set; }

    public DateTime? EffectiveDateTime { get; set; }
    public Period? EffectivePeriod { get; set; }
    public Timing? EffectiveTiming { get; set; }

    public DateTime? DateAsserted { get; set; }

    public Reference? InformationSource { get; set; }
    public List<Reference>? DerivedFrom { get; set; }
    public List<CodeableConcept>? Reason { get; set; }

    public List<Annotation>? Note { get; set; }
    public List<Reference>? RelatedClinicalInformation { get; set; }

    public string? RenderedDosageInstruction { get; set; }

    public List<Dosage>? Dosage { get; set; }
    public MedicationStatementAdherence? Adherence { get; set; }
}

public class MedicationStatementAdherence
{
    public CodeableConcept? Code { get; set; }
    public CodeableConcept? Reason { get; set; }
}