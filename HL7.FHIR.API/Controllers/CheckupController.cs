using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HL7.FHIR.DLL.DTO;
using Microsoft.AspNetCore.Mvc;

namespace HL7.FHIR.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CheckupController : ControllerBase
    {
        // GET: api/checkup
        [HttpPost]
        public IActionResult GetCheckup([FromBody] CheckupInputDto input)
        {
            return null; // This method currently does not perform any operations and returns null.
        }
    }
}