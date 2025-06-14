public static class ProcedureStatusRequiredRule
{
    public static bool IsStatusCompleted(string? status)
    {
        return status == "completed";
    }
}