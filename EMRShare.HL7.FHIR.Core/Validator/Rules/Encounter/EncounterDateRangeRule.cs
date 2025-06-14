using System;

namespace HL7.FHIR.Core.Validator.Rules.Encounter;

public static class EncounterDateRangeRule
{
    public static bool IsValidPeriod(DateTime? start, DateTime? end)
    {
        return start.HasValue && end.HasValue && start <= end;
    }
}