using Microsoft.AspNetCore.Mvc;

namespace dotnet_practice.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        [HttpGet]
        [Route("search")]
        public IActionResult GetUsers()
        {
            User user = new()
            {
                Name = "Andrés",
                Phone = "1500050",
                Email = "test@test.com",
                EmailConfirmed = "test@test.com",
                Password = "12345",
                PasswordConfirmed = "12345",
                Role = RoleClass.Client
            };
            return Ok(user);
        }
    }
}
