using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Logger;
using HL7.FHIR.DLL.Mapping;

namespace HL7.FHIR.DLL.Service
{
    public class CheckupConvertService
    {
        private readonly CheckupMapper _mapper = new();
    private readonly IFhirLogger _logger;

        public CheckupConvertService(IFhirLogger? logger = null)
        {
            _logger = logger ?? new FileFhirLogger();
        }

        public string ConvertToJson(CheckupInputDto dto)
        {
            // try
            // {
            //     _logger.Info("[CheckupConvertService] Start converting Checkup input to FHIR Bundle");

            //     var bundle = _mapper.MapToBundle(dto);
            //     _logger.Info("[CheckupConvertService] Mapping complete");

            //     // Ensure Composition is first
            //     var compositionEntry = bundle.Entry.FirstOrDefault(e => e.Resource?.ResourceType == "Composition");
            //     if (compositionEntry != null)
            //     {
            //         bundle.Entry.Remove(compositionEntry);
            //         bundle.Entry.Insert(0, compositionEntry);
            //         _logger.Debug("[CheckupConvertService] Composition entry moved to top of bundle");
            //     }

            //     var json = JsonSerializer.Serialize(bundle, new JsonSerializerOptions
            //     {
            //         PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //         WriteIndented = true
            //     });

            //     _logger.Info("[CheckupConvertService] Serialization complete");
            //     return json;
            // }
            // catch (Exception ex)
            // {
            //     _logger.Error("[CheckupConvertService] Exception occurred", ex);
            //     throw;
            // }
            return string.Empty; // Placeholder for actual implementation
        }
    }
}