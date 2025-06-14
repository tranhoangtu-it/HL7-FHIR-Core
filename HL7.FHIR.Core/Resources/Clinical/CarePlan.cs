using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Clinical;

public class CarePlan : DomainResourceBase
{
    public override string ResourceType => "CarePlan";

    public List<Identifier>? Identifier { get; set; }
    public List<CodeableConcept>? Category { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Intent { get; set; }
    public Reference? Subject { get; set; }
    public List<Reference>? Contributor { get; set; }
    public Period? Period { get; set; }
    public List<Annotation>? Note { get; set; }
}