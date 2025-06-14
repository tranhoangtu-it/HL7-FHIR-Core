using System.Collections.Generic;
using HL7.FHIR.Core.Base.DataTypes;
using HL7.FHIR.Core.Base.MetaData;
using HL7.FHIR.Core.Resources.Administrative;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.DTO.Components;
using HL7.FHIR.DLL.Utils;

namespace HL7.FHIR.DLL.Factories;

public static class PatientFactory
{
    public static Patient Create(HeaderDto dto)
    {
        return new Patient
        {
            Id = dto.PatientIdentifier01 ?? Guid.NewGuid().ToString(),
            Meta = new Meta { LastUpdated = DateTime.UtcNow },
            Language = "ja",
            Text = new Narrative
            {
                Status = "generated",
                Div = "<div xmlns=\"http://www.w3.org/1999/xhtml\">患者情報</div>"
            },
            Identifier = new List<Identifier>
            {
                new Identifier { System = "urn:oid:1.2.392.100495.20.3.81", Value = dto.PatientIdentifier01 },
                new Identifier { System = "urn:oid:1.2.392.100495.20.3.82", Value = dto.PatientIdentifier02 }
            },
            Name = new List<HumanName>
            {
                new HumanName { Text = dto.PatientNameIde },
                new HumanName { Text = dto.PatientNameSyl },
                new HumanName { Text = dto.PatientNameAbc }
            },
            Telecom = new List<ContactPoint>
            {
                new ContactPoint { System = "phone", Value = dto.TelecomPhoneHome, Use = "home" },
                new ContactPoint { System = "phone", Value = dto.TelecomPhoneWork, Use = "work" },
                new ContactPoint { System = "phone", Value = dto.TelecomPhoneMobile, Use = "mobile" },
                new ContactPoint { System = "email", Value = dto.TelecomEmail01 },
                new ContactPoint { System = "email", Value = dto.TelecomEmail02 }
            },
            Gender = dto.Gender?.ToLower() switch
            {
                "male" => "male",
                "female" => "female",
                _ => "unknown"
            },
            BirthDate = DateParser.TryParse(dto.BirthDate),
            Address = new List<Address>
            {
                new Address
                {
                    Use = "home",
                    Text = dto.AddressHomeName,
                    PostalCode = dto.AddressHomePostalCode
                },
                new Address
                {
                    Use = "work",
                    Text = dto.AddressWorkName,
                    PostalCode = dto.AddressWorkPostalCode
                }
            },
            ManagingOrganization = ReferenceUtil.Create($"Organization/{dto.ManagingOrganizationCode}")
        };
    }
}