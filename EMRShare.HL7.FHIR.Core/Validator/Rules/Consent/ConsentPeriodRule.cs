using System;

namespace HL7.FHIR.Core.Validator.Rules.Consent;

public static class ConsentPeriodRule
{
    public static bool IsValidConsentPeriod(DateTime? start, DateTime? end)
    {
        return start.HasValue && end.HasValue && start <= end && end.Value <= DateTime.UtcNow;
    }
}