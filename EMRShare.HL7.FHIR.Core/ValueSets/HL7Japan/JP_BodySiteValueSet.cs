namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_BodySiteValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_BodySite";

    public static readonly string[] AllowedCodes = new[]
    {
        "Head",
        "Chest",
        "Abdomen",
        "LeftArm",
        "RightArm",
        "LeftLeg",
        "RightLeg"
    };
}