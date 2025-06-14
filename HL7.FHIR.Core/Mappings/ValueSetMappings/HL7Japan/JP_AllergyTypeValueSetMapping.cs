using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.ValueSetMappings.HL7Japan;
public static class JP_AllergyTypeValueSetMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_AllergyType";
    public static bool IsValid(string code)
    {
        return Enum.TryParse<JP_AllergyType>(code, out _);
    }
    public static JP_AllergyType? Parse(string code)
    {
        return Enum.TryParse<JP_AllergyType>(code, out var result) ? result : null;
    }
    public static IEnumerable<string> GetAllCodes()
    {
        return Enum.GetNames(typeof(JP_AllergyType));
    }
}