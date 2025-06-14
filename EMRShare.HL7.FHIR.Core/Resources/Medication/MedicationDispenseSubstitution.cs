using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Medication;


public class MedicationDispenseSubstitution
{
    public bool? WasSubstituted { get; set; }
    public CodeableConcept? Type { get; set; }
    public CodeableConcept? Reason { get; set; }
    public Reference? ResponsibleParty { get; set; }
}