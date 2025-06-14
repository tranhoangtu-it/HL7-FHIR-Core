using HL7.FHIR.Core.CodeSystems.HL7Japan;

namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_DocumentCategoryValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DocumentCategory";

    public static bool IsValid(string code)
    {
        return Enum.TryParse<JP_DocumentCategory>(code, out _);
    }

    public static JP_DocumentCategory? Parse(string code)
    {
        return Enum.TryParse<JP_DocumentCategory>(code, out var result) ? result : null;
    }

    public static IEnumerable<string> GetAllCodes()
    {
        return Enum.GetNames(typeof(JP_DocumentCategory));
    }
}