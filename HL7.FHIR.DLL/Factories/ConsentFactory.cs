using HL7.FHIR.Core.Resources.Support;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.DLL.DTO.Components;
using HL7.FHIR.DLL.Utils;

namespace HL7.FHIR.DLL.Factories;

public static class ConsentFactory
{
    public static Consent Create(ConsentInfoDto dto, string patientId)
    {
        return new Consent
        {
            Patient = ReferenceUtil.CreateUuid(patientId),
            Scope = new CodeableConcept
            {
                Text = "Patient consent for sharing"
            },
            DateTime = DateTime.Now
        };
    }
}
