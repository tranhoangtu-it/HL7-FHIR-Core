using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Administrative;

public class Practitioner : DomainResourceBase
{
    public override string ResourceType => "Practitioner";

    public List<Identifier>? Identifier { get; set; }
    public bool? Active { get; set; }
    public List<HumanName>? Name { get; set; }
    public List<ContactPoint>? Telecom { get; set; }
    public List<Address>? Address { get; set; }
    public string? Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public List<Attachment>? Photo { get; set; }
    public List<PractitionerQualification>? Qualification { get; set; }
    public List<CodeableConcept>? Communication { get; set; }
}