using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_AllergyTypeMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_AllergyType";
    private static readonly Dictionary<JP_AllergyType, (string code, string display)> Map = new()
    {
        { JP_AllergyType.Food, ("Food", "食物アレルギー") },
        { JP_AllergyType.Drug, ("Drug", "薬剤アレルギー") },
        { JP_AllergyType.Environment, ("Environment", "環境要因") },
        { JP_AllergyType.Insect, ("Insect", "昆虫アレルギー") },
        { JP_AllergyType.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_AllergyType type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_AllergyType type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_AllergyType? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_AllergyType type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}