using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTidentityApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "User")]

    public class UserController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hey there I am an User!!!";
        }
    }
}
