using Microsoft.AspNetCore.Mvc;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Service;
using HL7.FHIR.DLL.Logger;

namespace HL7.FHIR.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ReferralController : ControllerBase
{
    private readonly ReferralConvertService _convertService;

    public ReferralController()
    {
        _convertService = new ReferralConvertService(new FileFhirLogger());
    }

    [HttpPost("convert")]
    public IActionResult ConvertToFhirJson([FromBody] ReferralInputDto input)
    {

        try
        {
            var json = _convertService.ConvertToJson(input);
            return Content(json, "application/json");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Conversion failed: {ex.Message}");
        }
    }
}