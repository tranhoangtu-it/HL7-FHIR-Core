using System.Collections.Generic;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Administrative;

public class PractitionerQualification
{
    public List<Identifier>? Identifier { get; set; }
    public CodeableConcept? Code { get; set; }
    public Period? Period { get; set; }
    public Reference? Issuer { get; set; }
}