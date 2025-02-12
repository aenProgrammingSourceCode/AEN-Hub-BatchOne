using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplicationKarim.Feature.Messaging;
using WebApplicationKarim.Feature.ServiceImplementation;

namespace WebApplicationKarim.Feature.Applications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly ICompanyService _companyService;
        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpPost("add")]
        public async Task<IActionResult> AddAsync([FromQuery] AddCompanyRequest request)
        {
            await _companyService.Add(request);
            return Ok("Success");
        }
    }
}
