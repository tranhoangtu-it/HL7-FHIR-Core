using System.Collections.Generic;

namespace HL7.FHIR.Core.Base.DataTypes;

public class ContactDetail
{
    public string? Name { get; set; }
    public List<ContactPoint>? Telecom { get; set; }
}