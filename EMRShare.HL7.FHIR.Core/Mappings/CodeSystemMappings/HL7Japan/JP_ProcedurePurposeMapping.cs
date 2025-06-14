using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_ProcedurePurposeMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_ProcedurePurpose";
    private static readonly Dictionary<JP_ProcedurePurpose, (string code, string display)> Map = new()
    {
        { JP_ProcedurePurpose.Diagnostic, ("Diagnostic", "診断") },
        { JP_ProcedurePurpose.Therapeutic, ("Therapeutic", "治療") },
        { JP_ProcedurePurpose.Preventive, ("Preventive", "予防") },
        { JP_ProcedurePurpose.Rehabilitation, ("Rehabilitation", "リハビリ") },
        { JP_ProcedurePurpose.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_ProcedurePurpose type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_ProcedurePurpose type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_ProcedurePurpose? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_ProcedurePurpose type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}