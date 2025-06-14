using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Mapping;
using HL7.FHIR.DLL.Logger;
using HL7.FHIR.DLL.Mapping.DischargeSummary;

namespace HL7.FHIR.DLL.Service
{
    public class DischargeSummaryConvertService
    {
        private readonly DischargeSummaryMapper _mapper = new();
        private readonly IFhirLogger _logger;

        public DischargeSummaryConvertService(IFhirLogger? logger = null)
        {
            _logger = logger ?? new FileFhirLogger();
        }

        public string ConvertToJson(DischargeSummaryInputDto dto)
        {
            // try
            // {
            //     _logger.Info("[DischargeSummaryConvertService] Start converting DischargeSummary input to FHIR Bundle");

            //     var bundle = _mapper.MapToBundle(dto);
            //     _logger.Info("[DischargeSummaryConvertService] Mapping complete");

            //     // Ensure Composition is first
            //     var compositionEntry = bundle.Entry.FirstOrDefault(e => e.Resource?.ResourceType == "Composition");
            //     if (compositionEntry != null)
            //     {
            //         bundle.Entry.Remove(compositionEntry);
            //         bundle.Entry.Insert(0, compositionEntry);
            //         _logger.Debug("[DischargeSummaryConvertService] Composition entry moved to top of bundle");
            //     }

            //     var json = JsonSerializer.Serialize(bundle, new JsonSerializerOptions
            //     {
            //         PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //         WriteIndented = true
            //     });

            //     _logger.Info("[DischargeSummaryConvertService] Serialization complete");
            //     return json;
            // }
            // catch (Exception ex)
            // {
            //     _logger.Error("[DischargeSummaryConvertService] Exception occurred", ex);
            //     throw;
            // }
            return string.Empty; // Placeholder for actual implementation
        }
    }
}