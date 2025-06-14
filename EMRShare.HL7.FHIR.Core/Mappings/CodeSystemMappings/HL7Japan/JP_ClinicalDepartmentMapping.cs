using HL7.FHIR.Core.CodeSystems.HL7Japan;

namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;

public static class JP_ClinicalDepartmentMapping
{
    public const string System = "http://jami.jp/SS-MIX2/CodeSystem/ClinicalDepartment";
    private static readonly Dictionary<JP_ClinicalDepartment, (string code, string display)> Map = new()
    {
        { JP_ClinicalDepartment._081, ("081", "消化器科") },
        { JP_ClinicalDepartment._082, ("082", "呼吸器科") },
        { JP_ClinicalDepartment._083, ("083", "循環器科") },
        { JP_ClinicalDepartment._084, ("084", "整形外科") },
        { JP_ClinicalDepartment._085, ("085", "脳神経外科") },
        { JP_ClinicalDepartment._999, ("999", "その他") },
    };
    public static string? GetCode(JP_ClinicalDepartment type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_ClinicalDepartment type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_ClinicalDepartment? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_ClinicalDepartment type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}