using System;
using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Resources.Support;

public class ResearchSubject : DomainResourceBase
{
    public override string ResourceType => "ResearchSubject";

    public Identifier? Identifier { get; set; }
    public string? Status { get; set; } // candidate | enrolled | active | suspended | withdrawn | completed

    public Period? Period { get; set; }

    public Reference? Study { get; set; }       // Reference to ResearchStudy
    public Reference? Individual { get; set; }  // Reference to Patient

    public string? AssignedArm { get; set; }
    public string? ActualArm { get; set; }

    public Reference? Consent { get; set; }     // Reference to Consent
}