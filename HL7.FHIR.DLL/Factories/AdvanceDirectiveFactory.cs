using HL7.FHIR.Core.Resources.Clinical;
using HL7.FHIR.Core.Resources.Support;
using HL7.FHIR.DLL.DTO.Components;
using HL7.FHIR.DLL.Utils;

namespace HL7.FHIR.DLL.Factories;

public static class AdvanceDirectiveFactory
{
    public static Observation Create(AdvanceDirectiveDto dto, string patientId)
    {
        return new Observation
        {
            Subject = new Core.Base.DataTypes.Reference
            {
                ReferenceValue = $"urn:uuid:{patientId}"
            },
            Code = new Core.Base.DataTypes.CodeableConcept
            {
                Text = "Advance Directive"
            },
            ValueString = dto.DirectiveText,
            EffectiveDateTime = DateParser.TryParse(dto.ValidUntil)
        };
    }
}
