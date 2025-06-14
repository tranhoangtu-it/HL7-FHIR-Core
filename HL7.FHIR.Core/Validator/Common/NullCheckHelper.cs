namespace HL7.FHIR.Core.Validator.Common;

public static class NullCheckHelper
{
    public static bool IsNullOrEmpty(string? input) =>
        string.IsNullOrWhiteSpace(input);

    public static bool IsNullOrEmpty<T>(IEnumerable<T>? list) =>
        list == null || !list.Any();

    public static bool IsValidString(string? input, int minLength = 1) =>
        !string.IsNullOrWhiteSpace(input) && input.Length >= minLength;
}