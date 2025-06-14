using HL7.FHIR.Core.Base.DataTypes;

public class OrganizationContact
{
    public CodeableConcept? Purpose { get; set; }
    public HumanName? Name { get; set; }
    public List<ContactPoint>? Telecom { get; set; }
    public Address? Address { get; set; }
}