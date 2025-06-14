using HL7.FHIR.DLL.Constants;
using HL7.FHIR.DLL.Utils;

namespace HL7.FHIR.DLL.DTO;

public class HeaderDto
{
    public string? ResourceId { get; set; }
    public string? LastUpdateDate { get; set; }
    public string? Active { get; set; }
    public int? LongtermFlag { get; set; }
    public string? HosptalId { get; set; }
    public string? HosptalDepartmentCode { get; set; }
    public string? HosptalDepartmentName { get; set; }
    public string? HosptalDepartmentDisplay { get; set; }

    public string? PatientIdentifier01 { get; set; }
    public string? PatientIdentifier02 { get; set; }
    public string? PatientNameIde { get; set; }
    public string? PatientNameSyl { get; set; }
    public string? PatientNameAbc { get; set; }

    public string? TelecomPhoneHome { get; set; }
    public string? TelecomPhoneWork { get; set; }
    public string? TelecomPhoneMobile { get; set; }
    public string? TelecomEmail01 { get; set; }
    public string? TelecomEmail02 { get; set; }
    public string? TelecomOther01 { get; set; }
    public string? TelecomOther02 { get; set; }
    public string? TelecomOther03 { get; set; }

    public string? Gender { get; set; }
    public string? BirthDate { get; set; }
    public string? AddressHomeName { get; set; }
    public string? AddressHomePostalCode { get; set; }
    public string? AddressWorkName { get; set; }
    public string? AddressWorkPostalCode { get; set; }

    public string? ManagingOrganizationCode { get; set; }
    public string? ManagingOrganizationName { get; set; }

}
