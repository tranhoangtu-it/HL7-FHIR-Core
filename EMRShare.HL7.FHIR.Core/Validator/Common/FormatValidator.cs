using System.Text.RegularExpressions;

namespace HL7.FHIR.Core.Validator.Common;

public static class FormatValidator
{
    private static readonly Regex UuidRegex = new(@"^urn:uuid:[0-9a-fA-F\\-]{36}$");
    private static readonly Regex DateRegex = new(@"^\\d{4}-\\d{2}-\\d{2}$");
    private static readonly Regex IdentifierRegex = new(@"^[A-Za-z0-9\\-\\.]{1,64}$");

    public static bool IsUuid(string value) => UuidRegex.IsMatch(value);
    public static bool IsDate(string value) => DateRegex.IsMatch(value);
    public static bool IsValidIdentifier(string value) => IdentifierRegex.IsMatch(value);
}