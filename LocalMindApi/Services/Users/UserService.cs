using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LocalMindApi.Models.Users;
using LocalMindApi.Repositories;

namespace LocalMindApi.Services.Users;

public class UserService: IUserService
{
    private readonly IUserRepository userRepository;

    public UserService(IUserRepository userRepository)
    {
        this.userRepository = userRepository;
    }

    public async ValueTask<User> AddUserAsync(User user)
    {
        DateTimeOffset now = DateTimeOffset.UtcNow;
        user.CreatedDate=now;
        user.UpdatedDate=now;
        return await this.userRepository.InsertUserAsync(user);
    }

    public IQueryable<User> RetrieveAllUsers()
    {
         return this.userRepository.SelectAllUsers();
    }
    
}