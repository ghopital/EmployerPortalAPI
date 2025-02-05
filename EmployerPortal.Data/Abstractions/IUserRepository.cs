
using EmployerPortal.Entities;

namespace EmployerPortal.Data.Abstractions;

public interface IUserRepository
{
    Task<User> GetUserByName(string username, CancellationToken cancellationToken = default);
}
