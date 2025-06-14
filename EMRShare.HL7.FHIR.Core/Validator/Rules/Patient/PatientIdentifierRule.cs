namespace HL7.FHIR.Core.Validator.Rules.Patient;

public static class PatientIdentifierRule
{
    public static bool HasIdentifier(string? system, string? value)
    {
        return !string.IsNullOrWhiteSpace(system) && !string.IsNullOrWhiteSpace(value);
    }
}