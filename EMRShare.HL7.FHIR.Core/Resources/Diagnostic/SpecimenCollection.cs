using HL7.FHIR.Core.Base.DataTypes;

public class SpecimenCollection
{
    public Reference? Collector { get; set; }
    public DateTime? CollectedDateTime { get; set; }
    public Period? CollectedPeriod { get; set; }
    public Quantity? Quantity { get; set; }
    public CodeableConcept? Method { get; set; }
    public CodeableConcept? BodySite { get; set; }
}