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
/// HL7 Japan: 診療情報提供書（eReferral Document）
/// </summary>
public class JPReferralDocument : DomainResourceBase
{
    public Patient? Patient { get; set; }
    public Practitioner? Author { get; set; }
    public Organization? AuthorOrganization { get; set; }
    public Organization? RecipientOrganization { get; set; }
    public Practitioner? RecipientPractitioner { get; set; }
    public Encounter? Encounter { get; set; }
    public List<Condition>? ProblemList { get; set; }
    public List<Condition>? ReasonForReferral { get; set; }
    public List<AllergyIntolerance>? Allergies { get; set; }
    public List<MedicationStatement>? Medications { get; set; }
    public List<Procedure>? Procedures { get; set; }
    public List<Observation>? Observations { get; set; }
    public List<DiagnosticReport>? DiagnosticReports { get; set; }
    public List<DocumentReference>? Attachments { get; set; }
    public List<DocumentReference>? PdfDocuments { get; set; }

    public override string ResourceType => "ReferralDocument";
}