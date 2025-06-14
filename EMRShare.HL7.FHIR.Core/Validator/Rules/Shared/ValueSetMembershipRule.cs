using System.Collections.Generic;

namespace HL7.FHIR.Core.Validator.Rules.Shared;

public static class ValueSetMembershipRule
{
    public static bool IsInValueSet(string? code, IEnumerable<string> allowedCodes)
    {
        return !string.IsNullOrWhiteSpace(code) && allowedCodes.Contains(code);
    }
}