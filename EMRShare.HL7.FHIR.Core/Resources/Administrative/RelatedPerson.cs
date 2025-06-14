using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FFHIR.Core.Resources.Administrative;

public class RelatedPerson : DomainResourceBase
{
    public override string ResourceType => "RelatedPerson";

    public List<Identifier>? Identifier { get; set; }
    public bool? Active { get; set; }
    public Reference? Patient { get; set; }
    public List<HumanName>? Name { get; set; }
    public List<ContactPoint>? Telecom { get; set; }
    public string? Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public List<Address>? Address { get; set; }
    public List<CodeableConcept>? Relationship { get; set; }
}