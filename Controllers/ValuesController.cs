using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace trainingManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        [Route("GetTest")]
        public IActionResult GetTest()
        {
            string str = "Этот текст получен с сервера";
            return StatusCode(StatusCodes.Status200OK, str);
        }

    }
}
