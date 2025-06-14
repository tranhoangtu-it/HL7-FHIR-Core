using HL7.FHIR.Core.Resources.Support;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.DLL.DTO.Components;
using HL7.FHIR.DLL.Utils;

namespace HL7.FHIR.DLL.Factories;

public static class ResearchSubjectFactory
{
    public static ResearchSubject Create(ResearchInfoDto dto, string patientId)
    {
        return new ResearchSubject
        {
            Status = "candidate",
            Individual = ReferenceUtil.CreateUuid(patientId),
            Study = ReferenceUtil.Create("ResearchStudy/example")
        };
    }
}
