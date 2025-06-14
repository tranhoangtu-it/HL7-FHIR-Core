using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HL7.FHIR.DLL.DTO;
using HL7.FHIR.DLL.Logger;
using HL7.FHIR.DLL.Service;
using Microsoft.AspNetCore.Mvc;

namespace HL7.FHIR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DischargeSummaryController : ControllerBase
    {
        private readonly DischargeSummaryConvertService _convertService;

        public DischargeSummaryController()
        {
            _convertService = new DischargeSummaryConvertService(new FileFhirLogger());
        }
        // POST: api/discharge-summary
        [HttpPost]
        public IActionResult ConvertToFhirJson([FromBody] DischargeSummaryInputDto dto)
        {
            // Implementation for retrieving discharge summary
            string folder = @"C:\Users\tuth\Desktop\WORK\EMRShare\NEW\2.source\HL7.FHIR.API\bin\Release\net9.0\Sample\output"; // ???ng d?n th? m?c ch?a file json
            string fileName = "output_discharge_bundle"; // t?n file, v? d? test.json

            try
            {
                string jsonContent = JsonFileReader.ReadJsonContent(folder, fileName);
                return Content(jsonContent, "application/json");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Conversion failed: {ex.Message}");
            }
        }

    }
}