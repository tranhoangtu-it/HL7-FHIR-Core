namespace HL7.FHIR.Core.Validator.Rules.Patient;

public static class PatientKanaRequiredRule
{
    public static bool HasKanaName(string? familyKana, string? givenKana)
    {
        return !string.IsNullOrWhiteSpace(familyKana) || !string.IsNullOrWhiteSpace(givenKana);
    }
}