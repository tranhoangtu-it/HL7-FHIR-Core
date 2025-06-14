using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_DiseaseCodeMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DiseaseCode";
    private static readonly Dictionary<JP_DiseaseCode, (string code, string display)> Map = new()
        {
            { JP_DiseaseCode.Hypertension, ("Hypertension", "高血圧") },
            { JP_DiseaseCode.Diabetes, ("Diabetes", "糖尿病") },
            { JP_DiseaseCode.Asthma, ("Asthma", "喘息") },
            { JP_DiseaseCode.Gastritis, ("Gastritis", "胃炎") },
            { JP_DiseaseCode.COVID19, ("COVID19", "新型コロナウイルス感染症") },
        };
    public static string? GetCode(JP_DiseaseCode type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_DiseaseCode type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_DiseaseCode? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_DiseaseCode type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}