using System;
using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.Core.Base.DataTypes;

public class DispenseRequest
{
    public Period? ValidityPeriod { get; set; }
    public Quantity? Quantity { get; set; }
    public Duration? ExpectedSupplyDuration { get; set; }
    public int? NumberOfRepeatsAllowed { get; set; }
}