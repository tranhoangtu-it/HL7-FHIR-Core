using HL7.FHIR.Core.CodeSystems.HL7Japan;

namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_ClinicalDepartmentValueSet
{
    public const string System = "http://jami.jp/SS-MIX2/CodeSystem/ClinicalDepartment";

    public static bool IsValid(string code)
    {
        return Enum.TryParse<JP_ClinicalDepartment>(code, out _);
    }

    public static JP_ClinicalDepartment? Parse(string code)
    {
        return Enum.TryParse<JP_ClinicalDepartment>(code, out var result) ? result : null;
    }

    public static IEnumerable<string> GetAllCodes()
    {
        return Enum.GetNames(typeof(JP_ClinicalDepartment));
    }
}