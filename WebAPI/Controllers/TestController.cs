using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        //call this api
        [HttpGet("getdata")]
        public string GetList()
        {
            return "Working!";
        }
    }
}
