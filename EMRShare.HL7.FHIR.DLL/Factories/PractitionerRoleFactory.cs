using HL7.FHIR.Core.Resources.Administrative;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.DLL.Utils;

namespace HL7.FHIR.DLL.Factories;

public static class PractitionerRoleFactory
{
    public static PractitionerRole Create(string practitionerId, string organizationId, string roleDisplay)
    {
        return new PractitionerRole
        {
            Id = Guid.NewGuid().ToString(),
            Practitioner = ReferenceUtil.CreateUuid(practitionerId),
            Organization = ReferenceUtil.CreateUuid(organizationId),
            Code = new List<CodeableConcept>
            {
                new CodeableConcept
                {
                    Text = roleDisplay
                }
            }
        };
    }
}
