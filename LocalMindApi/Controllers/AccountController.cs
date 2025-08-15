using System.Threading.Tasks;
using LocalMindApi.Models;
using LocalMindApi.Models.UserTokens;
using LocalMindApi.Services.Account;
using Microsoft.AspNetCore.Mvc;

namespace LocalMindApi.Controllers
{
    [ApiController]
    
    public class AccountController:ControllerBase
    {
        private readonly  IAccountService accountService;

        public AccountController(IAccountService accountService)
        {
            this.accountService = accountService;
        }

        [HttpPost("api/login")]
        public async ValueTask<ActionResult<UserToken>> LoginAsync([FromBody] UserCredential userCredential)
        {
            UserToken userToken =
                await this.accountService.LoginAsync(userCredential);
            
            return Ok(userToken); 
        }
    }
}