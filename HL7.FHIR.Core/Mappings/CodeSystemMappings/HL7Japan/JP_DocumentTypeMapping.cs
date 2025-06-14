using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_DocumentTypeMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DocumentType";
    private static readonly Dictionary<JP_DocumentType, (string code, string display)> Map = new()
    {
        { JP_DocumentType.DischargeSummary, ("DischargeSummary", "退院サマリー") },
        { JP_DocumentType.ReferralLetter, ("ReferralLetter", "診療情報提供書") },
        { JP_DocumentType.CheckupResult, ("CheckupResult", "健診結果報告書") },
        { JP_DocumentType.Certificate, ("Certificate", "証明書") },
        { JP_DocumentType.ImagingReport, ("ImagingReport", "画像診断報告書") },
        { JP_DocumentType.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_DocumentType type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_DocumentType type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_DocumentType? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_DocumentType type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}