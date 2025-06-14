namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_ProcedurePurposeValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_ProcedurePurpose";

    public static readonly string[] AllowedCodes = new[]
    {
        "Diagnostic",
        "Therapeutic",
        "Preventive",
        "Rehabilitation",
        "Other"
    };
}