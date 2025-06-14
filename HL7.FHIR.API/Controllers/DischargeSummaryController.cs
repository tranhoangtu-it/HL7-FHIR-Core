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
            return null; // This method currently does not perform any operations and returns null.
        }

    }
}