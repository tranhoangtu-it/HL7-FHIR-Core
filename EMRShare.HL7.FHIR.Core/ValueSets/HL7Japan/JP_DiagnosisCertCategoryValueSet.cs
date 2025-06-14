namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_DiagnosisCertCategoryValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DiagnosisCertCategory";

    public static readonly string[] AllowedCodes = new[]
    {
        "WorkInjury",
        "SchoolAbsence",
        "InsuranceClaim",
        "LegalDocument",
        "Other"
    };
}