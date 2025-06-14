using System;

namespace HL7.FHIR.Core.Validator.Rules.Document;

public static class DocumentRequiredFieldsRule
{
    public static bool HasValidCategory(string? system, string? code)
    {
        return !string.IsNullOrWhiteSpace(system) &&
               !string.IsNullOrWhiteSpace(code);
    }

    public static bool HasValidType(string? system, string? code)
    {
        return !string.IsNullOrWhiteSpace(system) &&
               !string.IsNullOrWhiteSpace(code);
    }

    public static bool HasValidSubject(string? subjectReference)
    {
        return !string.IsNullOrWhiteSpace(subjectReference);
    }

    public static bool HasValidCustodian(string? custodianReference)
    {
        return !string.IsNullOrWhiteSpace(custodianReference);
    }

    public static bool HasValidContext(string? contextReference)
    {
        return !string.IsNullOrWhiteSpace(contextReference);
    }
}