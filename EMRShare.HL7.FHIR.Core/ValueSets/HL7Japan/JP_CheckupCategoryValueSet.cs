namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_CheckupCategoryValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_CheckupCategory";

    public static readonly string[] AllowedCodes = new[]
    {
        "General",
        "CancerScreening",
        "LifestyleRelatedDiseases",
        "MentalHealth",
        "InfectiousDisease",
        "Other"
    };
}