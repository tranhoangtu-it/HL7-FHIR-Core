using System;

namespace HL7.FHIR.Core.Validator.Rules.Patient;

public static class PatientBirthDateRule
{
    public static bool IsValidBirthDate(DateTime? birthDate)
    {
        return birthDate.HasValue && birthDate.Value <= DateTime.UtcNow;
    }
}