
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Medication;
public class MedicationIngredient
{
    public CodeableConcept? ItemCodeableConcept { get; set; }
    public Reference? ItemReference { get; set; }
    public bool? IsActive { get; set; }

    public Ratio? StrengthRatio { get; set; }
    public CodeableConcept? StrengthCodeableConcept { get; set; }
    public Quantity? StrengthQuantity { get; set; }
}