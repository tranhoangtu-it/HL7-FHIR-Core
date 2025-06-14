// 📁 HL7.FHIR.DLL/Service/ReferralConvertService.cs
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Logger;
using HL7.FHIR.DLL.Mapping.Referral;
using System.Text.Json;

namespace HL7.FHIR.DLL.Service;

public class ReferralConvertService
{
    private readonly ReferralMapper _mapper = new();
    private readonly IFhirLogger _logger;

    public ReferralConvertService(IFhirLogger? logger = null)
    {
        _logger = logger ?? new FileFhirLogger();
    }

    public string ConvertToJson(ReferralInputDto dto)
    {
        try
        {
            _logger.Info("[ReferralConvertService] Start converting eReferral input to FHIR Bundle");

            var bundle = _mapper.MapToBundle(dto);
            _logger.Info("[ReferralConvertService] Mapping complete");
            
            // Ensure Composition is first
            var compositionEntry = bundle.Entry.FirstOrDefault(e => e.Resource?.ResourceType == "Composition");
            if (compositionEntry != null)
            {
                bundle.Entry.Remove(compositionEntry);
                bundle.Entry.Insert(0, compositionEntry);
                _logger.Debug("[ReferralConvertService] Composition entry moved to top of bundle");
            }

            var json = JsonSerializer.Serialize(bundle, new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            });

            _logger.Info("[ReferralConvertService] Serialization complete");
            return json;
        }
        catch (Exception ex)
        {
            _logger.Error("[ReferralConvertService] Exception occurred", ex);
            throw;
        }
    }
}