using System.Threading.Tasks;
using LocalMindApi.Models;
using LocalMindApi.Models.UserTokens;

namespace LocalMindApi.Services.Account;

public interface IAccountService
{
    ValueTask<UserToken>LoginAsync(UserCredential userCredential);
} 