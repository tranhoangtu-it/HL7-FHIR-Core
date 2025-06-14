namespace HL7.FHIR.Core.ValueSets.HL7Japan;

public static class JP_DischargeInstructionCategoryValueSet
{
    public const string System = "http://jpfhir.jp/fhir/core/CodeSystem/JP_DischargeInstructionCategory";

    public static readonly string[] AllowedCodes = new[]
    {
        "Medication",
        "Diet",
        "Activity",
        "FollowUp",
        "Other"
    };
}