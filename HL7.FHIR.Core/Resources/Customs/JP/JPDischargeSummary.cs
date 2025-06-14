using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Resources.Administrative;
using HL7.FHIR.Core.Resources.Clinical;
using HL7.FHIR.Core.Resources.Diagnostic;
using HL7.FHIR.Core.Resources.Medication;
using HL7.FHIR.Core.Resources.Support;
using HL7.FHIR.Core.Resources.Infrastructure;

namespace HL7.FHIR.Core.Resources.Customs.JP;

/// <summary>
/// HL7 Japan: 退院時サマリー（Discharge Summary Document）
/// </summary>
public class JPDischargeSummary : DomainResourceBase
{
    public Patient? Patient { get; set; }
    public Practitioner? Author { get; set; }
    public Organization? AuthorOrganization { get; set; }
    public Organization? Custodian { get; set; }
    public Encounter? AdmissionDetails { get; set; }
    public List<Condition>? AdmissionDiagnosis { get; set; }
    public List<AllergyIntolerance>? Allergies { get; set; }
    public List<Condition>? ChiefComplaints { get; set; }
    public List<Condition>? PresentIllness { get; set; }
    public List<Condition>? PastIllness { get; set; }
    public List<MedicationStatement>? MedicationsOnAdmission { get; set; }
    public List<Observation>? SocialHistory { get; set; }
    public List<Observation>? PhysicalFindingsOnAdmission { get; set; }
    public List<FamilyMemberHistory>? FamilyHistory { get; set; }
    public List<DocumentReference>? HospitalCourse { get; set; }
    public List<Condition>? DischargeDiagnosis { get; set; }
    public List<MedicationRequest>? MedicationOnDischarge { get; set; }
    public List<CarePlan>? InstructionOnDischarge { get; set; }
    public List<Observation>? PhysicalFindingsOnDischarge { get; set; }
    public List<Procedure>? HospitalProcedures { get; set; }
    public List<DiagnosticReport>? DiagnosticResults { get; set; }
    public List<DeviceUseStatement>? MedicalDevices { get; set; }
    public List<Immunization>? Immunizations { get; set; }
    public List<Consent>? AdvanceDirectives { get; set; }
    public List<ResearchSubject>? ResearchParticipation { get; set; }
    public List<DocumentReference>? Attachments { get; set; }
    public List<DocumentReference>? PdfDocuments { get; set; }

    public override string ResourceType => "DischargeSummary";
}