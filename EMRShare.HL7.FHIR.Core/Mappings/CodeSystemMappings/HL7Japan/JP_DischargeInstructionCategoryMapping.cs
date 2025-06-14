using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_DischargeInstructionCategoryMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DischargeInstructionCategory";
    private static readonly Dictionary<JP_DischargeInstructionCategory, (string code, string display)> Map = new()
    {
        { JP_DischargeInstructionCategory.Medication, ("Medication", "服薬指導") },
        { JP_DischargeInstructionCategory.Diet, ("Diet", "食事指導") },
        { JP_DischargeInstructionCategory.Activity, ("Activity", "活動指導") },
        { JP_DischargeInstructionCategory.FollowUp, ("FollowUp", "フォローアップ") },
        { JP_DischargeInstructionCategory.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_DischargeInstructionCategory type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_DischargeInstructionCategory type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_DischargeInstructionCategory? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_DischargeInstructionCategory type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}