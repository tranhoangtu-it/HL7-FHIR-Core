using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Medication;

public class MedicationDispense : DomainResourceBase
{
    public override string ResourceType => "MedicationDispense";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }

    public List<Reference>? BasedOn { get; set; }
    public List<Reference>? PartOf { get; set; }
    public CodeableConcept? NotPerformedReason { get; set; }
    public DateTime? StatusChanged { get; set; }
    public List<CodeableConcept>? Category { get; set; }

    public CodeableConcept? MedicationCodeableConcept { get; set; }
    public Reference? MedicationReference { get; set; }

    public Reference? Subject { get; set; }
    public Reference? Encounter { get; set; }
    public Reference? SupportingInformation { get; set; }

    public List<MedicationDispensePerformer>? Performer { get; set; }

    public Reference? Location { get; set; }
    public Reference? AuthorizingPrescription { get; set; }
    public CodeableConcept? Type { get; set; }
    public Quantity? Quantity { get; set; }
    public Quantity? DaysSupply { get; set; }

    public DateTime? Recorded { get; set; }
    public DateTime? WhenPrepared { get; set; }
    public DateTime? WhenHandedOver { get; set; }

    public Reference? Destination { get; set; }
    public List<Reference>? Receiver { get; set; }

    public List<Annotation>? Note { get; set; }
    public string? RenderedDosageInstruction { get; set; }
    public List<Dosage>? DosageInstruction { get; set; }

    public MedicationDispenseSubstitution? Substitution { get; set; }

    public List<Reference>? EventHistory { get; set; }
}

