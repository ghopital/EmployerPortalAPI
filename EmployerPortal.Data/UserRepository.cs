using EmployerPortal.Data.Abstractions;
using EmployerPortal.Data.Contexts;
using EmployerPortal.Entities;
using Microsoft.EntityFrameworkCore;

namespace EmployerPortal.Data;
public class UserRepository(DataContext context) : IUserRepository
{

    public async Task<User> GetUserByName(string username, CancellationToken cancellationToken)
    {
        return await context.Users.Where(u => u.UserName == username).FirstOrDefaultAsync(cancellationToken);
    }
}
