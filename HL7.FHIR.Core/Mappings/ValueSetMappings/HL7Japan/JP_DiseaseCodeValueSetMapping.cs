using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.ValueSetMappings.HL7Japan;

public static class JP_DiseaseCodeValueSetMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DiseaseCode";
    public static bool IsValid(string code)
    {
        return Enum.TryParse<JP_DiseaseCode>(code, out _);
    }
    public static JP_DiseaseCode? Parse(string code)
    {
        return Enum.TryParse<JP_DiseaseCode>(code, out var result) ? result : null;
    }
    public static IEnumerable<string> GetAllCodes()
    {
        return Enum.GetNames(typeof(JP_DiseaseCode));
    }
}