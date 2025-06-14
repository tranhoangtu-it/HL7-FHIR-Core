namespace HL7.FHIR.Core.Validator.Rules.Shared;

public static class CanonicalUrlRule
{
    public static bool IsValidCanonical(string? url)
    {
        return !string.IsNullOrWhiteSpace(url) &&
               (url.StartsWith("http://") || url.StartsWith("https://"));
    }
}