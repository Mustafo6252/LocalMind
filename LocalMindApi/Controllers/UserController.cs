using System.Linq;
using System.Threading.Tasks;
using LocalMindApi.Data;
using LocalMindApi.Models.Users;
using LocalMindApi.Services.Users;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

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
            return StatusCode(201, await this.userService.AddUserAsync(user));
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