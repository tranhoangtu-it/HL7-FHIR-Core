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
/// HL7 Japan: 健康診断結果報告書（Health Checkup Result Document）
/// </summary>
public class JPCheckupResult : DomainResourceBase
{
    public Patient? Patient { get; set; }
    public Practitioner? Author { get; set; }
    public Organization? AuthorOrganization { get; set; }
    public Encounter? Encounter { get; set; }

    public List<Observation>? Vitals { get; set; }
    public List<Observation>? LabResults { get; set; }
    public List<Observation>? PhysicalExams { get; set; }
    public List<Condition>? AbnormalFindings { get; set; }
    public List<Procedure>? Screenings { get; set; }
    public List<Immunization>? Immunizations { get; set; }

    public List<CarePlan>? Recommendations { get; set; }
    public List<DocumentReference>? Attachments { get; set; }
    public List<DocumentReference>? PdfDocuments { get; set; }

    public override string ResourceType => "CheckupResult";
}