using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Administrative;

public class Organization : DomainResourceBase
{
    public override string ResourceType => "Organization";

    public List<Identifier>? Identifier { get; set; }
    public bool? Active { get; set; }
    public string? Name { get; set; }
    public List<string>? Alias { get; set; }
    public List<ContactPoint>? Telecom { get; set; }
    public List<Address>? Address { get; set; }
    public List<OrganizationContact>? Contact { get; set; }
    public Reference? PartOf { get; set; }
    public List<CodeableConcept>? Type { get; set; }
}