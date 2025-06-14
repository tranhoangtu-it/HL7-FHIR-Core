using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HL7.FHIR.DLL.DTO.Components;

namespace HL7.FHIR.DLL.DTO
{
    public class DischargeSummaryInputDto
    {
        // --- Header構成情報 ---
        public required HeaderDto Header { get; set; }
        // --- 02_入院情報 ---
        public required DischargeDto Discharge { get; set; }
        // --- 07_処方 ---
        public List<MedicationRequestDto> Medications { get; set; } = new();
    }
}