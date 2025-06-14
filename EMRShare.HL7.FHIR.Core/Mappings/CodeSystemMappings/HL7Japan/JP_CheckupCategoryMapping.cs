using HL7.FHIR.Core.CodeSystems.HL7Japan;

namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;

public static class JP_CheckupCategoryMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_CheckupCategory";
    private static readonly Dictionary<JP_CheckupCategory, (string code, string display)> Map = new()
    {
        { JP_CheckupCategory.General, ("General", "一般健診") },
        { JP_CheckupCategory.CancerScreening, ("CancerScreening", "がん検診") },
        { JP_CheckupCategory.LifestyleRelatedDiseases, ("LifestyleRelatedDiseases", "生活習慣病検診") },
        { JP_CheckupCategory.MentalHealth, ("MentalHealth", "メンタルヘルス") },
        { JP_CheckupCategory.InfectiousDisease, ("InfectiousDisease", "感染症") },
        { JP_CheckupCategory.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_CheckupCategory type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_CheckupCategory type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_CheckupCategory? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_CheckupCategory type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}