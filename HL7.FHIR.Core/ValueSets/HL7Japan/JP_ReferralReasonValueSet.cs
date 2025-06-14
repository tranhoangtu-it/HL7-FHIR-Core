namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_ReferralReasonValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_ReferralReason";

    public static readonly string[] AllowedCodes = new[]
    {
        "SpecializedTreatment",
        "FurtherExamination",
        "Transfer",
        "PatientRequest",
        "Other"
    };
}