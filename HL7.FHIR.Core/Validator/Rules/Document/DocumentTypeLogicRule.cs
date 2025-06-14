namespace HL7.FHIR.Core.Validator.Rules.Document;

public static class DocumentTypeLogicRule
{
    public static bool IsReferralNote(string? code) =>
        code == "11506-3"; // LOINC code for Referral note

    public static bool IsDischargeSummary(string? code) =>
        code == "18842-5"; // LOINC code for Discharge Summary
}