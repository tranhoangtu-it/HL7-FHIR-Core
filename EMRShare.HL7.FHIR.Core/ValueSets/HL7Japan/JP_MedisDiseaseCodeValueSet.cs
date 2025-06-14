using HL7.FHIR.Core.CodeSystems.HL7Japan;

namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_MedisDiseaseCodeValueSet
{
    public const string System = "http://medis.or.jp/CodeSystem/master-disease-exCode";

    public static bool IsValid(string code)
    {
        return Enum.TryParse<JP_MedisDiseaseCode>(code, out _);
    }

    public static JP_MedisDiseaseCode? Parse(string code)
    {
        return Enum.TryParse<JP_MedisDiseaseCode>(code, out var result) ? result : null;
    }

    public static IEnumerable<string> GetAllCodes()
    {
        return Enum.GetNames(typeof(JP_MedisDiseaseCode));
    }
}