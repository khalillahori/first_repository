using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[Controller.cs]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
//    [HttpGet("GetcarcompanyName")]
    
      // List <stuent> stuents = new List<stuent> get()
        public IActionResult abc()
        {
            return ok();
        }
    }
}
