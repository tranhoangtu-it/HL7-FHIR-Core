namespace HL7.FHIR.DLL.DTO.Components;

public class ReferralDto
{
    public string? RegistererDisplay { get; set; }
    public string? AuthorDisplay { get; set; }
    public string? Status { get; set; }
    public string? DocumentCode { get; set; }
    public string? DocumentDisplay { get; set; }
    public string? DocumentDate { get; set; }
    public string? DocumentFilePath { get; set; }
    public string? DocumentFileName { get; set; }
    public string? BrowsingConsent { get; set; }
    public string? PClass { get; set; }
    public string? CustodianFacilityCode { get; set; }
    public string? CustodianFacilityName { get; set; }
    public string? FromFacilityCode { get; set; }
    public string? FromFacilityName { get; set; }
    public string? FromFacilityPostalCode { get; set; }
    public string? FromFacilityAddress { get; set; }
    public string? FromFacilityTel01 { get; set; }
    public string? FromFacilityTel02 { get; set; }
    public string? FromFacilityFax { get; set; }
    public string? FromDepartmentCode { get; set; }
    public string? FromDepartmentDisplay { get; set; }
    public string? FromDoctorName { get; set; }
    public string? ToFacilityCode { get; set; }
    public string? ToFacilityName { get; set; }
    public string? ToFacilityPostalCode { get; set; }
    public string? ToFacilityAddress { get; set; }
    public string? ToFacilityTel01 { get; set; }
    public string? ToFacilityTel02 { get; set; }
    public string? ToFacilityFax { get; set; }
    public string? ToDepartmentCode { get; set; }
    public string? ToDepartmentDisplay { get; set; }
    public string? ToDoctorName { get; set; }
    public string? ReferralPurpose { get; set; }
    public string? Problem { get; set; }
    public string? PrbMedisKanriNo { get; set; }
    public string? PrbMedisKanriNoDisplay { get; set; }
    public string? PresentIllness { get; set; }
    public string? PastIllness { get; set; }
    public string? AllergyIntolerance { get; set; }
    public string? FamiliyHistory { get; set; }
    public string? AdmissionPhysical { get; set; }
    public string? InfectiousDisease { get; set; }
    public string? SocialHistory { get; set; }
    public string? Immunization { get; set; }
    public string? SurgicalProcedure { get; set; }
    public string? BloodInfusion { get; set; }
    public string? TreatmentProcedure { get; set; }
    public string? Medication { get; set; }
    public string? ExamsStudy { get; set; }
    public string? ClinicalCourse { get; set; }
    public string? ClinicalInstruction { get; set; }
    public string? MedicalDevice { get; set; }
    public string? AdvanceDirective { get; set; }
    public string? ResearchParticipation { get; set; }
    public string? Attachment { get; set; }
    public string? Remarks { get; set; }
    public string? BdType { get; set; } = "document"; // Bundle.type (fixed: "document")
    public DateTime? BdTimestamp { get; set; }        // Bundle.timestamp
    public string? BdId { get; set; }                 // Bundle.id
    public string? BdEntryUrl { get; set; }           // Bundle.entry.fullUrl (optional)
    public string? BdEntryResource { get; set; }      // Bundle.entry.resource type (optional)

    // --- Composition 関連 ---
    public string CompStatus { get; set; } = "final";     // Composition.status
    public DateTime? CompDate { get; set; }               // Composition.date
    public string? CompSubjectRef { get; set; }           // Composition.subject reference (Patient)
    public string? CompAuthorRef { get; set; }            // Composition.author reference (Practitioner)
    public string? CompEncounterRef { get; set; }         // Composition.encounter reference (Encounter)
    public string? CompProfileUrl { get; set; }           // Composition.meta.profile
    public string? CompIdentifierSystem { get; set; }     // Composition.identifier.system

}