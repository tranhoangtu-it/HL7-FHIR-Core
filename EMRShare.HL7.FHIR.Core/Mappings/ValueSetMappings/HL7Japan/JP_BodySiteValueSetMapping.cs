using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.ValueSetMappings.HL7Japan;
public static class JP_BodySiteValueSetMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_BodySite";
    public static bool IsValid(string code)
    {
        return Enum.TryParse<JP_BodySite>(code, out _);
    }
    public static JP_BodySite? Parse(string code)
    {
        return Enum.TryParse<JP_BodySite>(code, out var result) ? result : null;
    }
    public static IEnumerable<string> GetAllCodes()
    {
        return Enum.GetNames(typeof(JP_BodySite));
    }
}