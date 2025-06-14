using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Medication;

public class MedicationAdministration : DomainResourceBase
{
    public CodeableConcept? MedicationCodeableConcept { get; set; }
    public Reference? Subject { get; set; }
    public string? EffectiveDateTime { get; set; }

    public override string ResourceType => "MedicationAdministration";
}