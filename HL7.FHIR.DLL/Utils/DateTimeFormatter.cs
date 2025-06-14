using System;

namespace HL7.FHIR.DLL.Utils;

public static class DateTimeFormatter
{
    public static string ToIsoString(DateTime dt) => dt.ToString("yyyy-MM-ddTHH:mm:ss.fffZ");
}
public static class DateParser
{
    public static DateTime? TryParse(string? input)
        => DateTime.TryParse(input, out var dt) ? dt : null;
}