using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Clinical;

public class ClinicalImpression : DomainResourceBase
{
    public override string ResourceType => "ClinicalImpression";

    public List<Identifier>? Identifier { get; set; }
    public string? Status { get; set; }
    public CodeableConcept? Code { get; set; }
    public Reference? Subject { get; set; }
    public Reference? Assessor { get; set; }
    public DateTime? Date { get; set; }
    public List<Annotation>? Note { get; set; }
}