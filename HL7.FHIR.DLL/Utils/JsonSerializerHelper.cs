using System.Text.Json;
using System.Text.Json.Serialization;

namespace HL7.FHIR.DLL.Utils;

public static class JsonSerializerHelper
{
    private static readonly JsonSerializerOptions _options = new()
    {
        WriteIndented = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase
    };

    public static string ToJson<T>(T obj) => JsonSerializer.Serialize(obj, _options);
}
