using System;
using System.Collections.Generic;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.Core.Resources.Clinical;

public class DeviceUseStatement : DomainResourceBase
{
    public override string ResourceType => "DeviceUseStatement";

    public List<Identifier>? Identifier { get; set; }
    public Reference? Subject { get; set; }
    public Reference? Device { get; set; }
    public DateTime? RecordedOn { get; set; }
    public Period? Timing { get; set; }
    public CodeableConcept? BodySite { get; set; }
    public List<Annotation>? Note { get; set; }
}