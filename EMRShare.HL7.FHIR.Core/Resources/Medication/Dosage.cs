using System.Collections.Generic;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Base.DataTypes;

public class Dosage
{
    public int? Sequence { get; set; }
    public string? Text { get; set; }
    public List<CodeableConcept>? AdditionalInstruction { get; set; }
    public string? PatientInstruction { get; set; }

    public Timing? Timing { get; set; }

    public bool? AsNeededBoolean { get; set; }
    public List<CodeableConcept>? AsNeededFor { get; set; }

    public CodeableConcept? Site { get; set; }
    public CodeableConcept? Route { get; set; }
    public CodeableConcept? Method { get; set; }

    public List<DoseAndRate>? DoseAndRate { get; set; }

    public List<Ratio>? MaxDosePerPeriod { get; set; }
    public Quantity? MaxDosePerAdministration { get; set; }
    public Quantity? MaxDosePerLifetime { get; set; }
}

public class DoseAndRate
{
    public CodeableConcept? Type { get; set; }

    public Range? DoseRange { get; set; }
    public Quantity? DoseQuantity { get; set; }

    public Ratio? RateRatio { get; set; }
    public Range? RateRange { get; set; }
    public Quantity? RateQuantity { get; set; }
}