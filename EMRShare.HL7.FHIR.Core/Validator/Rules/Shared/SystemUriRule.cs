public static class SystemUriRule
{
    public static bool IsValidSystem(string? system)
    {
        return !string.IsNullOrWhiteSpace(system) &&
               (system.StartsWith("http://") || system.StartsWith("https://") || system.StartsWith("urn:"));
    }
}