using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.DataTypes;

public class ClaimItem
{
    public int? Sequence { get; set; }
    public CodeableConcept? ProductOrService { get; set; }
    public Quantity? Quantity { get; set; }
    public Money? UnitPrice { get; set; }
    public Reference? Encounter { get; set; }
}