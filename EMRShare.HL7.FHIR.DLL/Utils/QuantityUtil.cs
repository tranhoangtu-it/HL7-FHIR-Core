using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.DLL.Utils;

public static class QuantityUtil
{
    public static Quantity? Create(decimal? value, string? unit, string? code)
    {
        if (value == null) return null;

        return new Quantity
        {
            Value = value,
            Unit = unit,
            Code = code,
            System = "http://unitsofmeasure.org"
        };
    }
}