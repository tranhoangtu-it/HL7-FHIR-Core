using HL7.FHIR.Core.Base.Abstract;
using HL7.FHIR.Core.CodeSystems.HL7Japan;
using HL7.FHIR.Core.Resources.Customs.JP;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Factories;

namespace HL7.FHIR.DLL.Mapping.DischargeSummary;

public class DischargeSummaryMapper
{
    private readonly CompositionSectionFactory _sectionFactory = new();
    private readonly BundleEntryFactory _entryFactory = new();

    public JP_Bundle_eReferral MapToBundle(ReferralInputDto dto)
    {
        var patientId = dto.Header.PatientIdentifier01?.Split(':').FirstOrDefault() ?? Guid.NewGuid().ToString();
        var bundle = new JP_Bundle_eReferral
        {
            Identifier = IdentifierFactory.Create(dto.Header.ResourceId),
            Timestamp = DateTime.Now
        };

        // Patient
        var patient = PatientFactory.Create(dto.Header);
        bundle.Entry.Add(_entryFactory.Create(patient));

        // Organizations
        var managingOrg = OrganizationFactory.CreateManagingOrg(dto.Header);
        var fromOrg = OrganizationFactory.CreateFromFacility(dto.Referral);
        var toOrg = OrganizationFactory.CreateToFacility(dto.Referral);
        bundle.Entry.AddRange(new[] {
            _entryFactory.Create(managingOrg),
            _entryFactory.Create(fromOrg),
            _entryFactory.Create(toOrg)
        });
        
        // Practitioners
        var author = PractitionerFactory.CreateAuthor(dto.Referral.AuthorDisplay);
        var fromDoctor = PractitionerFactory.CreateFromDoctor(dto.Referral);
        var toDoctor = PractitionerFactory.CreateToDoctor(dto.Referral);
        bundle.Entry.AddRange(new[] {
            _entryFactory.Create(author),
            _entryFactory.Create(fromDoctor),
            _entryFactory.Create(toDoctor)
        });
        // PractitionerRoles
        var authorRole = PractitionerRoleFactory.Create(author.Id, managingOrg.Id, JP_PractitionerRoleCode.Author);
        var fromDoctorRole = PractitionerRoleFactory.Create(fromDoctor.Id, fromOrg.Id, JP_PractitionerRoleCode.ReferringPhysician);
        var toDoctorRole = PractitionerRoleFactory.Create(toDoctor.Id, toOrg.Id, JP_PractitionerRoleCode.ReceivingPhysician);
        bundle.Entry.AddRange(new[] {
            _entryFactory.Create(authorRole),
            _entryFactory.Create(fromDoctorRole),
            _entryFactory.Create(toDoctorRole)
        });
        // Composition
        var composition = CompositionFactory.Create(dto, patient.Id);
        bundle.Entry.Add(_entryFactory.Create(composition));
        // MedicationRequests
        if (dto.Medications?.Any() == true)
        {
            foreach (var medDto in dto.Medications)
            {
                var medRequest = MedicationRequestFactory.Create(medDto, patient.Id);
                bundle.Entry.Add(new BundleEntry
                {
                    FullUrl = $"urn:uuid:{medRequest.Id}",
                    Resource = medRequest
                });
            }
        }
        // // Consent
        // var consent = ConsentFactory.Create(dto.Consent, patient.Id);
        // bundle.Entry.Add(_entryFactory.Create(consent));

        // // ResearchSubject
        // var research = ResearchSubjectFactory.Create(dto.Research, patient.Id);
        // bundle.Entry.Add(_entryFactory.Create(research));

        // // Advance Directive as Observation
        // var advanceDirective = AdvanceDirectiveFactory.Create(dto.AdvanceDirective, patient.Id);
        // bundle.Entry.Add(_entryFactory.Create(advanceDirective));

        return bundle;
    }
}