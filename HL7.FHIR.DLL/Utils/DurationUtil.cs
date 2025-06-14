using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.DLL.Utils;

public static class DurationUtil
{
    public static Duration? Create(int? value, string? unit, string? code)
    {
        if (value == null) return null;

        return new Duration
        {
            Value = value,
            Unit = unit,
            Code = code,
            System = "http://unitsofmeasure.org"
        };
    }
}