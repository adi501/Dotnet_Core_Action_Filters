using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Exception_Filter_and_Try_Catch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        // GET: api/<TestController>
        [HttpGet]
        [ServiceFilter(typeof(CustomExceptionFilter))]
        public IEnumerable<string> Get()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;

            }
            catch (Exception ex)
            {
            }
            return new string[] { "value1", "value2" };

        }
    }
}
