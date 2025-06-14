using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Medication;

public class MedicationRequest : DomainResourceBase
{
    public override string ResourceType => "MedicationRequest";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Intent { get; set; }

    public CodeableConcept? MedicationCodeableConcept { get; set; }
    public Reference? MedicationReference { get; set; }

    public Reference? Subject { get; set; }
    public Reference? Encounter { get; set; }
    public DateTime? AuthoredOn { get; set; }
    public Reference? Requester { get; set; }

    public List<Dosage>? DosageInstruction { get; set; }
    public MedicationRequestDispenseRequest? DispenseRequest { get; set; }
    public MedicationRequestSubstitution? Substitution { get; set; }
    public List<Annotation>? Note { get; set; }
}

public class MedicationRequestDispenseRequest
{
    public Period? ValidityPeriod { get; set; }
    public int? NumberOfRepeatsAllowed { get; set; }
    public Quantity? Quantity { get; set; }
    public Duration? ExpectedSupplyDuration { get; set; }
    public Reference? Performer { get; set; }
}

public class MedicationRequestSubstitution
{
    public bool? AllowedBoolean { get; set; }
    public CodeableConcept? Reason { get; set; }
}