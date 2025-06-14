using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Medication;
public class MedicationDispensePerformer
{
    public CodeableConcept? Function { get; set; }
    public Reference? Actor { get; set; }
}
