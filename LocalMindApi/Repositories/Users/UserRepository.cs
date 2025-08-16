using System.Linq;
using System.Threading.Tasks;
using LocalMindApi.Data;
using LocalMindApi.Models.Users;
using Microsoft.EntityFrameworkCore;

namespace LocalMindApi.Repositories;

public class UserRepository: IUserRepository
{
    private readonly ApplicationDbContex contex;

    public UserRepository(ApplicationDbContex contex)
    {
        this.contex = contex;
    }

    public async ValueTask<User> InsertUserAsync(User user)
    {
        await contex.Users.AddAsync(user);
        await contex.SaveChangesAsync();
        return user;
    }

    public IQueryable<User> SelectAllUsers() =>
        this.contex.Users
            .Include(u => u.UserAdditionalDetails);
}