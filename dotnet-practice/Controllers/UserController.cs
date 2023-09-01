using Microsoft.AspNetCore.Mvc;

namespace dotnet_practice.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        public Task GetUsers()
        {
            return Task.CompletedTask;
        }
    }
}
