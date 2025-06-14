using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_DiagnosisCertCategoryMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DiagnosisCertCategory";
    private static readonly Dictionary<JP_DiagnosisCertCategory, (string code, string display)> Map = new()
    {
        { JP_DiagnosisCertCategory.WorkInjury, ("WorkInjury", "労災") },
        { JP_DiagnosisCertCategory.SchoolAbsence, ("SchoolAbsence", "学校欠席") },
        { JP_DiagnosisCertCategory.InsuranceClaim, ("InsuranceClaim", "保険請求") },
        { JP_DiagnosisCertCategory.LegalDocument, ("LegalDocument", "法的文書") },
        { JP_DiagnosisCertCategory.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_DiagnosisCertCategory type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_DiagnosisCertCategory type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_DiagnosisCertCategory? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_DiagnosisCertCategory type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}