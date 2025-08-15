using System.Linq;
using System.Threading.Tasks;
using LocalMindApi.Models.Users;
using LocalMindApi.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LocalMindApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class UserController: ControllerBase
    {
        private readonly IUserService userService;

        public UserController(IUserService userService)
        {
            this.userService = userService;
        }

        [HttpPost]
        public async ValueTask<ActionResult<User>> postUserAsync([FromBody]User user)
        {
            User newUser =
                await this.userService.AddUserAsync(user);
            return StatusCode(201, newUser);
        }

        [HttpGet]
        [Authorize(Roles = "Admin")]
        public ActionResult<IQueryable<User>> RetrieveAllUsers()
        {
            IQueryable<User> users = 
                this.userService.RetrieveAllUsers();
            return Ok(users);
        }
    }
}