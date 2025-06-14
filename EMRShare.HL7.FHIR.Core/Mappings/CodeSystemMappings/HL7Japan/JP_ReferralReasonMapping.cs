using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_ReferralReasonMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_ReferralReason";
    private static readonly Dictionary<JP_ReferralReason, (string code, string display)> Map = new()
    {
        { JP_ReferralReason.SpecializedTreatment, ("SpecializedTreatment", "専門的治療") },
        { JP_ReferralReason.FurtherExamination, ("FurtherExamination", "精密検査") },
        { JP_ReferralReason.Transfer, ("Transfer", "転院") },
        { JP_ReferralReason.PatientRequest, ("PatientRequest", "患者希望") },
        { JP_ReferralReason.Other, ("Other", "その他") },
    };
    public static string? GetCode(JP_ReferralReason type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_ReferralReason type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_ReferralReason? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_ReferralReason type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}