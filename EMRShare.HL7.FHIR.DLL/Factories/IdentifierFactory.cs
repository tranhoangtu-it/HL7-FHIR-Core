using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.DLL.Factories;

public static class IdentifierFactory
{
    public static Identifier CreateBundleIdentifier(string facilityId, int year, string uniquePart)
    {
        return new Identifier
        {
            System = "http://jpfhir.jp/fhir/clins/bundle-identifier",
            Use = "official",
            Value = $"{facilityId}^{year}^{uniquePart}"
        };
    }

    public static Identifier CreateOrganizationIdentifier(string orgCode)
    {
        return new Identifier
        {
            System = "http://jpfhir.jp/fhir/core/IdSystem/organization",
            Use = "official",
            Value = orgCode
        };
    }

    public static Identifier CreatePatientIdentifier(string value)
    {
        return new Identifier
        {
            System = "http://jpfhir.jp/fhir/core/IdSystem/individual",
            Use = "official",
            Value = value
        };
    }
    public static Identifier Create(string? id) => new()
    {
        System = "http://jpfhir.jp/fhir/clins/bundle-identifier",
        Value = $"urn:uuid:{id ?? Guid.NewGuid().ToString()}"
    };
}