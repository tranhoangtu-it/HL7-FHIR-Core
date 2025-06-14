using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.DLL.Utils;

public static class CodeableConceptUtil
{
    public static CodeableConcept Create(string system, string? code, string? display, string? text = null)
    {
        return new CodeableConcept
        {
            Coding = new List<Coding>
            {
                new Coding
                {
                    System = system,
                    Code = code,
                    Display = display
                }
            },
            Text = text ?? display
        };
    }
}