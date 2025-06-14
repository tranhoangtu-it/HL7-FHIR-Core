public static class BundleProfileValidationRule
{
    public static bool HasValidProfile(string? profile)
    {
        return !string.IsNullOrWhiteSpace(profile) &&
               profile.Contains("StructureDefinition/") &&
               (profile.StartsWith("http://") || profile.StartsWith("https://"));
    }
}