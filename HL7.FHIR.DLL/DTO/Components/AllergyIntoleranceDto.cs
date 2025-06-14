namespace HL7.FHIR.DLL.DTO.Components;

public class AllergyIntoleranceDto
{
    public string? ClinicalStatus { get; set; }                      // active | inactive | resolved
    public string? VerificationStatus { get; set; }                  // unconfirmed | confirmed | refuted | entered-in-error
    public string? CategoryCode { get; set; }                        // food | medication | environment | biologic
    public string? CriticalityCode { get; set; }                     // low | high | unable-to-assess

    public string? AllergyCode { get; set; }                         // J9FA32280000
    public string? AllergyCodeDisplay { get; set; }                  // クルミ
    public string? AllergyCodeText { get; set; }                     // 自由入力電子カルテ

    public string? ReactionSubstanceCode { get; set; }
    public string? ReactionSubstanceDisplay { get; set; }
    public string? ReactionSubstanceText { get; set; }

    public string? ReactionDescription { get; set; }
    public string? ReactionOnsetString { get; set; }

    public string? ReactionSeverityCode { get; set; }                // mild | moderate | severe
    public string? ReactionSeverityDisplay { get; set; }
    public string? ReactionSeverityText { get; set; }
}