namespace HL7.FHIR.Core.Validator.Rules.Shared;

public static class RequiredCodeRule
{
    public static bool HasCode(string? code)
    {
        return !string.IsNullOrWhiteSpace(code);
    }
}