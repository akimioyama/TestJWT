using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TestJWT.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ValuesController : Controller
    {
        [Authorize]
        [HttpGet("/getlogin")]
        public IActionResult GetLogin()
        {
            return Ok($"Login: {User.Identity.Name}");
        }
        [Authorize(Roles = "admin")]
        [HttpGet("/getrole")]
        public IActionResult GetRole()
        {
            return Ok("Admin!!!");
        }
    }
}
