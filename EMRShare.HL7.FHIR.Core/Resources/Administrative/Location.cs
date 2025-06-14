using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Administrative;

public class Location : DomainResourceBase
{
    public override string ResourceType => "Location";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; } // active | suspended | inactive
    public string? OperationalStatus { get; set; } // internal concept
    public string? Name { get; set; }
    public List<string>? Alias { get; set; }
    public string? Description { get; set; }
    public CodeableConcept? Mode { get; set; } // instance | kind
    public CodeableConcept? Type { get; set; }
    public ContactPoint? Telecom { get; set; }
    public Address? Address { get; set; }
    public Reference? ManagingOrganization { get; set; }
    public Position? Position { get; set; }
    public string? PhysicalType { get; set; }
    public Period? Availability { get; set; }
}
