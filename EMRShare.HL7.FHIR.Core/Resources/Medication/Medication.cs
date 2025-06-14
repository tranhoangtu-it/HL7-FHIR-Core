using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Medication;

public class Medication : DomainResourceBase
{
    public override string ResourceType => "Medication";

    public List<Identifier>? Identifier { get; set; }
    public CodeableConcept? Code { get; set; }
    public string? Status { get; set; }
    public Reference? MarketingAuthorizationHolder { get; set; }
    public CodeableConcept? DoseForm { get; set; }
    public Quantity? TotalVolume { get; set; }
    public List<MedicationIngredient>? Ingredient { get; set; }
    public MedicationBatch? Batch { get; set; }
    public Reference? Definition { get; set; }
}
