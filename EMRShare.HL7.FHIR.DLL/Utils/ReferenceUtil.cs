using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.DLL.Utils;

public static class ReferenceUtil
{
    public static Reference Create(string referenceValue)
    {
        return new Reference
        {
            ReferenceValue = referenceValue
        };
    }

    public static Reference CreateUuid(string id)
    {
        return new Reference
        {
            ReferenceValue = $"urn:uuid:{id}"
        };
    }

    public static Reference CreateWithDisplay(string referenceValue, string display)
    {
        return new Reference
        {
            ReferenceValue = referenceValue,
            Display = display
        };
    }
}
