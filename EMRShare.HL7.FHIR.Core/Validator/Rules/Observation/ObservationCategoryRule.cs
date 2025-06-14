public static class ObservationCategoryRule
{
    public static bool IsValidCategorySystem(string? system)
    {
        return system == "http://terminology.hl7.org/CodeSystem/observation-category";
    }
}