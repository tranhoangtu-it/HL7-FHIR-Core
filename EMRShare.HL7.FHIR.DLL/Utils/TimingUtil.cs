using HL7.FHIR.Core.Base.DataTypes;

namespace HL7.FHIR.DLL.Utils;

public static class TimingUtil
{
    public static Timing Create(string? code, string? display)
    {
        return new Timing
        {
            Code = new CodeableConcept
            {
                Coding = new List<Coding>
                {
                    new Coding
                    {
                        System = "http://jpfhir.jp/fhir/core/CodeSystem/timing-codes",
                        Code = code,
                        Display = display
                    }
                },
                Text = display
            }
        };
    }
}