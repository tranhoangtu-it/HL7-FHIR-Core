public static class OidUriFormatRule
{
    public static bool IsValidOid(string? oid)
    {
        return !string.IsNullOrWhiteSpace(oid) &&
               oid.StartsWith("urn:oid:") &&
               oid.Length > "urn:oid:".Length;
    }
}