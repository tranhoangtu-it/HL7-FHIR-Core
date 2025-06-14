public static class SystemUriHelper
{
    public const string UuidSystem = "urn:ietf:rfc:3986";
    public const string LoincSystem = "http://loinc.org";
    public const string SNOMEDSystem = "http://snomed.info/sct";

    public static bool IsValidSystem(string input)
    {
        return new[] { UuidSystem, LoincSystem, SNOMEDSystem }.Contains(input);
    }
}