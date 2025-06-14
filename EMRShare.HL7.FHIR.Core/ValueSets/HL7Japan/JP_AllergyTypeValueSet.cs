namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_AllergyTypeValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_AllergyType";

    public static readonly string[] AllowedCodes = new[]
    {
        "Food",
        "Drug",
        "Environment",
        "Insect",
        "Other"
    };
}