using HL7.FHIR.Core.Resources.Administrative;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.DTO.Components;

namespace HL7.FHIR.DLL.Factories;

public static class PractitionerFactory
{
    public static Practitioner CreateAuthor(string? displayName)
    {
        return new Practitioner
        {
            Id = Guid.NewGuid().ToString(),
            Name = new List<HumanName>
            {
                new HumanName { Text = displayName }
            }
        };
    }

    public static Practitioner CreateFromDoctor(ReferralDto dto)
    {
        return new Practitioner
        {
            Id = Guid.NewGuid().ToString(),
            Name = new List<HumanName>
            {
                new HumanName { Text = dto.FromDoctorName }
            }
        };
    }

    public static Practitioner CreateToDoctor(ReferralDto dto)
    {
        return new Practitioner
        {
            Id = Guid.NewGuid().ToString(),
            Name = new List<HumanName>
            {
                new HumanName { Text = dto.ToDoctorName }
            }
        };
    }
}
