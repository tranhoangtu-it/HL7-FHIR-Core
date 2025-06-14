using HL7.FHIR.Core.CodeSystems.HL7Japan;
namespace HL7.FHIR.Core.Mappings.ValueSetMappings.HL7Japan;

public static class JP_DischargeInstructionCategoryValueSetMapping
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DischargeInstructionCategory";
    public static bool IsValid(string code)
    {
        return Enum.TryParse<JP_DischargeInstructionCategory>(code, out _);
    }
    public static JP_DischargeInstructionCategory? Parse(string code)
    {
        return Enum.TryParse<JP_DischargeInstructionCategory>(code, out var result) ? result : null;
    }
    public static IEnumerable<string> GetAllCodes()
    {
        return Enum.GetNames(typeof(JP_DischargeInstructionCategory));
    }
}