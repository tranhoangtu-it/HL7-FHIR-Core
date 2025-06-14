namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_MedicationUsagePurposeValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_MedicationUsagePurpose";

    public static readonly string[] AllowedCodes = new[]
    {
        "Acute",
        "Chronic",
        "Prophylaxis",
        "SymptomRelief",
        "Other"
    };
}