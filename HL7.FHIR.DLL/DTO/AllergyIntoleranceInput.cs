namespace HL7.FHIR.DLL.DTO;

using HL7.FHIR.DLL.DTO.Components;

public class AllergyIntoleranceInputDto
{
    public required HeaderDto Header { get; set; }
    public List<AllergyIntoleranceDto> Allergies { get; set; } = new();
}