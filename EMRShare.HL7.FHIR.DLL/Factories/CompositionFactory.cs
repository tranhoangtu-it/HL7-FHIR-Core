using HL7.FHIR.Core.Resources.Customs.JP;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Constants;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.DLL.Utils;
using HL7.FHIR.Core.Resources.Core;

namespace HL7.FHIR.DLL.Factories;

public static class CompositionFactory
{
    public static JP_Composition_eReferral Create(ReferralInputDto dto, string patientId)
    {
        var sectionList = new List<CompositionSection>();
        
        if (!string.IsNullOrWhiteSpace(dto.Referral.Problem))
        {
            sectionList.Add(new CompositionSection
            {
                Title = "主訴",
                Text = new Narrative
                {
                    Status = "generated",
                    Div = $"<div>{dto.Referral.Problem}</div>"
                }
            });
        }

        if (!string.IsNullOrWhiteSpace(dto.Referral.PresentIllness))
        {
            sectionList.Add(new CompositionSection
            {
                Title = "現病歴",
                Text = new Narrative
                {
                    Status = "generated",
                    Div = $"<div>{dto.Referral.PresentIllness}</div>"
                }
            });
        }

        if (!string.IsNullOrWhiteSpace(dto.Referral.AllergyIntolerance))
        {
            sectionList.Add(new CompositionSection
            {
                Title = "アレルギー",
                Text = new Narrative
                {
                    Status = "generated",
                    Div = $"<div>{dto.Referral.AllergyIntolerance}</div>"
                }
            });
        }

        return new JP_Composition_eReferral
        {
            Date = DateTime.TryParse(dto.Referral.DocumentDate, out var date) ? date : null,
            Title = JPDocumentCodes.ReferralNoteDisplay,
            Subject = ReferenceUtil.CreateUuid(patientId),
            Author = new() { ReferenceUtil.Create("urn:uuid:author") },
            Custodian = ReferenceUtil.Create("urn:uuid:organization"),
            Section = sectionList
        };
    }
}