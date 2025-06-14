using System;

namespace HL7.FHIR.Core.Validator.Common;

public static class CodeValidationHelper
{
    public static bool IsInEnum<T>(string code) where T : struct, Enum
    {
        return Enum.TryParse<T>(code, out _);
    }

    public static T? ParseEnum<T>(string code) where T : struct, Enum
    {
        return Enum.TryParse<T>(code, out var result) ? result : null;
    }

    public static IEnumerable<string> GetAllEnumCodes<T>() where T : Enum
    {
        return Enum.GetNames(typeof(T));
    }
}