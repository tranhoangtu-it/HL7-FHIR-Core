using HL7.FHIR.Core.Resources.Administrative;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Utils;
using HL7.FHIR.DLL.DTO.Components;
using HL7.FHIR.Core.Base.MetaData;

namespace HL7.FHIR.DLL.Factories;

public static class OrganizationFactory
{
    public static Organization Create(string orgId, string name)
    {
        return new Organization
        {
            Id = Guid.NewGuid().ToString().ToLower(),
            Meta = new Meta { LastUpdated = DateTime.UtcNow },
            Language = "ja",
            Text = new Narrative
            {
                Status = "generated",
                Div = $"<div xmlns=\"http://www.w3.org/1999/xhtml\">{name}</div>"
            },
            Identifier = new List<Identifier>
            {
                IdentifierFactory.CreateOrganizationIdentifier(orgId)
            },
            Name = name
        };
    }
    public static Organization CreateManagingOrg(HeaderDto dto)
    {
        return new Organization
        {
            Id = dto.ManagingOrganizationCode ?? Guid.NewGuid().ToString(),
            
            Name = dto.ManagingOrganizationName,
            Identifier = new List<Identifier>
            {
                new Identifier
                {
                    System = "urn:oid:1.2.392.100495.20.3.41",
                    Value = dto.ManagingOrganizationCode
                }
            }
        };
    }

    public static Organization CreateFromFacility(ReferralDto dto)
    {
        return new Organization
        {
            Id = dto.FromFacilityCode ?? Guid.NewGuid().ToString(),
            Name = dto.FromFacilityName,
            Address = new List<Address>
            {
                new Address
                {
                    Text = dto.FromFacilityAddress,
                    PostalCode = dto.FromFacilityPostalCode
                }
            },
            Telecom = new List<ContactPoint>
            {
                new ContactPoint { System = "phone", Value = dto.FromFacilityTel01 },
                new ContactPoint { System = "phone", Value = dto.FromFacilityTel02 },
                new ContactPoint { System = "fax", Value = dto.FromFacilityFax }
            },
            Identifier = new List<Identifier>
            {
                new Identifier
                {
                    System = "urn:oid:1.2.392.100495.20.3.41",
                    Value = dto.FromFacilityCode
                }
            }
        };
    }

    public static Organization CreateToFacility(ReferralDto dto)
    {
        return new Organization
        {
            Id = dto.ToFacilityCode ?? Guid.NewGuid().ToString(),
            Name = dto.ToFacilityName,
            Address = new List<Address>
            {
                new Address
                {
                    Text = dto.ToFacilityAddress,
                    PostalCode = dto.ToFacilityPostalCode
                }
            },
            Telecom = new List<ContactPoint>
            {
                new ContactPoint { System = "phone", Value = dto.ToFacilityTel01 },
                new ContactPoint { System = "phone", Value = dto.ToFacilityTel02 },
                new ContactPoint { System = "fax", Value = dto.ToFacilityFax }
            },
            Identifier = new List<Identifier>
            {
                new Identifier
                {
                    System = "urn:oid:1.2.392.100495.20.3.41",
                    Value = dto.ToFacilityCode
                }
            }
        };
    }
}