public static class ObservationUnitRequiredRule
{
    public static bool HasUnit(string? unit)
    {
        return !string.IsNullOrWhiteSpace(unit);
    }
}