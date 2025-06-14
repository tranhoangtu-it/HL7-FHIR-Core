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
            return null;
        }
    }
}
