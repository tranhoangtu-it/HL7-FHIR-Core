using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.CodeSystemMappings.HL7Japan;
public static class JP_BodySiteMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_BodySite";
    private static readonly Dictionary<JP_BodySite, (string code, string display)> Map = new()
        {
            { JP_BodySite.Head, ("Head", "頭部") },
            { JP_BodySite.Chest, ("Chest", "胸部") },
            { JP_BodySite.Abdomen, ("Abdomen", "腹部") },
            { JP_BodySite.LeftArm, ("LeftArm", "左腕") },
            { JP_BodySite.RightArm, ("RightArm", "右腕") },
            { JP_BodySite.LeftLeg, ("LeftLeg", "左脚") },
            { JP_BodySite.RightLeg, ("RightLeg", "右脚") },
        };
    public static string? GetCode(JP_BodySite type) => Map.TryGetValue(type, out var result) ? result.code : null;
    public static string? GetDisplay(JP_BodySite type) => Map.TryGetValue(type, out var result) ? result.display : null;
    public static JP_BodySite? FromCode(string code) => Map.FirstOrDefault(kvp => kvp.Value.code == code).Key;
    public static (string code, string display, string system)? ToCodable(JP_BodySite type) => Map.TryGetValue(type, out var value) ? (value.code, value.display, System) : null;
}