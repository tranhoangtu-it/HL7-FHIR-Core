public static class DateRangeValidator
{
    public static bool IsStartBeforeEnd(DateTime? start, DateTime? end)
    {
        return start.HasValue && end.HasValue && start <= end;
    }

    public static bool IsValidDate(DateTime? date)
    {
        return date.HasValue && date.Value <= DateTime.UtcNow;
    }
}