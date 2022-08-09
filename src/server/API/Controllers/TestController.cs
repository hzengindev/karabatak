using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        private readonly ILogger<TestController> _logger;

        private Dictionary<int, string> names = new Dictionary<int, string>()
        {
            {1, "name 1" },
            {2, "name 2" },
        };

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }


        [HttpGet("names")]
        public IActionResult Names()
        {
            return Ok(names);
        }

        [HttpGet("names/{id}")]
        public IActionResult Names([FromRoute] int id)
        {

            if (!names.Any(z => z.Key == id))
                return NotFound();

            var name = names.FirstOrDefault(z => z.Key == id);
            return Ok(name);
        }
    }
}
