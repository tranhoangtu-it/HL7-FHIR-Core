using System;

namespace HL7.FHIR.Core.Validator.Rules.Document;

public static class DocumentDateConsistencyRule
{
    public static bool IsCreatedBeforeAuthored(DateTime? created, DateTime? authored)
    {
        if (created.HasValue && authored.HasValue)
            return created <= authored;
        return true; // Skip if null
    }

    public static bool IsDateNotFuture(DateTime? date)
    {
        return !date.HasValue || date.Value <= DateTime.UtcNow;
    }
}