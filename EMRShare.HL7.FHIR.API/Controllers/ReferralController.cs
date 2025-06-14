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
        string folder = @"C:\Users\tuth\Desktop\WORK\EMRShare\NEW\2.source\HL7.FHIR.API\bin\Release\net9.0\Sample\output"; // đường dẫn thư mục chứa file json
        string fileName = "output_referral_bundle"; // tên file, ví dụ test.json

        try
        {
            string jsonContent = JsonFileReader.ReadJsonContent(folder, fileName);
            return Content(jsonContent, "application/json");
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Conversion failed: {ex.Message}");
        }

        // try
        // {
        //     var json = _convertService.ConvertToJson(input);
        //     return Content(json, "application/json");
        // }
        // catch (Exception ex)
        // {
        //     return StatusCode(500, $"Conversion failed: {ex.Message}");
        // }
    }
}