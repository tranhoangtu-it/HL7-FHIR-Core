// HL7.FHIR.DLL/DTO/ReferralInputDto.cs
using System;
using System.Collections.Generic;
using HL7.FHIR.DLL.DTO.Components;

namespace HL7.FHIR.DLL.DTO;

public class ReferralInputDto
{
    // --- Header構成情報 ---
    public required HeaderDto Header { get; set; }

    // --- 01_診療情報提供書 ---
    public ReferralDto Referral { get; set; } = new();

    // --- 07_処方 ---
    public List<MedicationRequestDto> Medications { get; set; } = new();
}