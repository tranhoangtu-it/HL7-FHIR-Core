using System.Collections.Generic;
using HL7.FHIR.DLL.DTO.Components;

namespace HL7.FHIR.DLL.DTO;

public class CheckupInputDto
{
    // --- Header構成情報 ---
    public required HeaderDto Header { get; set; }

    // --- 03_健診情報 ---
    public List<CheckupDto> CheckupItems { get; set; } = new();
}