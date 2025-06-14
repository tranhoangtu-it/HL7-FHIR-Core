using HL7.FHIR.Core.CodeSystems.HL7Japan;

namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;

public static class JP_DocumentCategoryMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DocumentCategory";
    private static readonly Dictionary<JP_DocumentCategory, (string code, string display)> Map = new()
    {
        { JP_DocumentCategory.DISCHARGE, ("DISCHARGE", "退院時要約") },
        { JP_DocumentCategory.OUTPATIENT, ("OUTPATIENT", "外来経過") },
        { JP_DocumentCategory.REFERRAL, ("REFERRAL", "診療情報提供書") },
        { JP_DocumentCategory.OTHER, ("OTHER", "その他") },
    };
    public static string? GetCode(JP_DocumentCategory type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_DocumentCategory type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_DocumentCategory? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_DocumentCategory type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}