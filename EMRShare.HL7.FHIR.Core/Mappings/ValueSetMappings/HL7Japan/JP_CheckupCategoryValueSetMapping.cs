using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.ValueSetMappings.HL7Japan;
public static class JP_CheckupCategoryValueSetMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_CheckupCategory";
    public static bool IsValid(string code)
    {
        return Enum.TryParse<JP_CheckupCategory>(code, out _);
    }
    public static JP_CheckupCategory? Parse(string code)
    {
        return Enum.TryParse<JP_CheckupCategory>(code, out var result) ? result : null;
    }
    public static IEnumerable<string> GetAllCodes()
    {
        return Enum.GetNames(typeof(JP_CheckupCategory));
    }
}