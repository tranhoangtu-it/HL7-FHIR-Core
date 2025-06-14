using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Diagnostic;

public class Specimen : DomainResourceBase
{
    public override string ResourceType => "Specimen";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Type { get; set; }
    public Reference? Subject { get; set; }
    public DateTime? ReceivedTime { get; set; }
    public SpecimenCollection? Collection { get; set; }
}