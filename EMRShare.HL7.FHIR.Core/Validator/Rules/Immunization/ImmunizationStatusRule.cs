public static class ImmunizationStatusRule
{
    public static bool IsStatusCompleted(string? status)
    {
        return status == "completed";
    }
}