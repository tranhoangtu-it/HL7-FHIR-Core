namespace HL7.FHIR.Core.Base.DataTypes;

public class UsageContext
{
    public Coding? Code { get; set; }

    // Polymorphic value[x] – bạn có thể mở rộng nhiều loại hơn nếu cần
    public CodeableConcept? ValueCodeableConcept { get; set; }
    public Quantity? ValueQuantity { get; set; }
    public Range? ValueRange { get; set; }
    public Reference? ValueReference { get; set; }
}