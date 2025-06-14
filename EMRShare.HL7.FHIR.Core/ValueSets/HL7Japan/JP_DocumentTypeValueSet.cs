namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_DocumentTypeValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DocumentType";

    public static readonly string[] AllowedCodes = new[]
    {
        "DischargeSummary",
        "ReferralLetter",
        "CheckupResult",
        "Certificate",
        "ImagingReport",
        "Other"
    };
}