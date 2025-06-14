namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_DiseaseCodeValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DiseaseCode";

    public static readonly string[] AllowedCodes = new[]
    {
        "Hypertension",
        "Diabetes",
        "Asthma",
        "Gastritis",
        "COVID19"
    };
}