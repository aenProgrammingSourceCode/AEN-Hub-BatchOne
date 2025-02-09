using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationKarim.Controllers
{
    [Route("[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        public string Getstring()
        {
            return ("Bismillah");
        }
    }
}
