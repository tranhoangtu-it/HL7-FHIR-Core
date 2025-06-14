namespace HL7.FHIR.Core.Validator.Rules.Document;

public static class DocumentProfileBindingRule
{
    public static bool IsValidProfile(string? profileUrl)
    {
        return !string.IsNullOrWhiteSpace(profileUrl) &&
               (profileUrl.StartsWith("http://jpfhir.jp/fhir/core/StructureDefinition/") ||
                profileUrl.StartsWith("https://jpfhir.jp/fhir/core/StructureDefinition/"));
    }
}