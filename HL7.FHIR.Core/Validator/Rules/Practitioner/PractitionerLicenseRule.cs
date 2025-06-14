public static class PractitionerLicenseRule
{
    public static bool IsLicenseValid(string? licenseNumber)
    {
        return !string.IsNullOrWhiteSpace(licenseNumber) && licenseNumber.Length >= 6;
    }
}