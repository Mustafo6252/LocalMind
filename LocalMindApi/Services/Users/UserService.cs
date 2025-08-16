using System;
using System.Linq;
using System.Threading.Tasks;
using LocalMindApi.Models.Users;
using LocalMindApi.Repositories;
using LocalMindApi.Repositories.UserAdditionalDetails;

namespace LocalMindApi.Services.Users;

public class UserService: IUserService
{
    private readonly IUserRepository userRepository;
    private readonly IUserAdditionalRepository userAdditionalRepository; 

    public UserService(
        IUserRepository userRepository, 
        IUserAdditionalRepository userAdditionalRepository)
    {
        this.userRepository = userRepository;
        this.userAdditionalRepository = userAdditionalRepository; 
    }

    public async ValueTask<User> AddUserAsync(User user)
    {
        DateTimeOffset now = DateTimeOffset.UtcNow;
        user.CreatedDate=now;
        user.UpdatedDate=now;
        
        if (user.UserAdditionalDetails != null)
        {
            await this.userAdditionalRepository
                .InsertUserAdditionalDetailsAsync(user.UserAdditionalDetails);
        }
        await this.userRepository.InsertUserAsync(user);
        return user;
    }

    public IQueryable<User> RetrieveAllUsers()
    {
         return this.userRepository.SelectAllUsers();
    }
    
}