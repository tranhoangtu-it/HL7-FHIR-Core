using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Administrative;

public class Patient : DomainResourceBase
{
    public override string ResourceType => "Patient";

    public List<Identifier>? Identifier { get; set; }
    public bool? Active { get; set; }
    public List<HumanName>? Name { get; set; }
    public List<ContactPoint>? Telecom { get; set; }
    public string? Gender { get; set; }
    public DateTime? BirthDate { get; set; }
    public bool? DeceasedBoolean { get; set; }
    public DateTime? DeceasedDateTime { get; set; }
    public List<Address>? Address { get; set; }
    public List<Reference>? Contact { get; set; }
    public Reference? ManagingOrganization { get; set; }
    public List<CodeableConcept>? Communication { get; set; }
}