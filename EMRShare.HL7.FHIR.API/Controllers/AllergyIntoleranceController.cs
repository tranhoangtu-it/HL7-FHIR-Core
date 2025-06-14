using HL7.FHIR.Core.Resources.Clinical;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HL7.FHIR.DLL.DTO;

namespace HL7.FHIR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AllergyIntoleranceController : ControllerBase
    {
        // This controller will handle AllergyIntolerance related requests
        // Currently, it is empty and can be filled with methods to handle specific endpoints

        // Example method to get all allergy intolerances
        [HttpPost]
        public IActionResult GetAllergyIntolerances(AllergyIntoleranceInputDto dto)
        {
            // Logic to retrieve allergy intolerances would go here
            string folder = @"C:\Users\tuth\Desktop\WORK\EMRShare\NEW\2.source\HL7.FHIR.API\bin\Release\net9.0\Sample\output"; // ???ng d?n th? m?c ch?a file json
            string fileName = "sample_output_allergy"; // t?n file, v? d? test.json

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
