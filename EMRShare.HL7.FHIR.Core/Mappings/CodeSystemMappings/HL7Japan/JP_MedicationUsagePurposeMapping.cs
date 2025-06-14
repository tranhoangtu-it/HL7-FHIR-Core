using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_MedicationUsagePurposeMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_MedicationUsagePurpose";
    private static readonly Dictionary<JP_MedicationUsagePurpose, (string code, string display)> Map = new()
    {
        { JP_MedicationUsagePurpose.Acute, ("Acute", "急性") },
        { JP_MedicationUsagePurpose.Chronic, ("Chronic", "慢性") },
        { JP_MedicationUsagePurpose.Prophylaxis, ("Prophylaxis", "予防") },
        { JP_MedicationUsagePurpose.SymptomRelief, ("SymptomRelief", "症状緩和") },
        { JP_MedicationUsagePurpose.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_MedicationUsagePurpose type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_MedicationUsagePurpose type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_MedicationUsagePurpose? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_MedicationUsagePurpose type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}