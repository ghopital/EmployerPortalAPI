using EmployerPortal.Entities.DTO;

namespace EmployerPortal.Service.Abstractions;

public interface IUserService
{
    Task<UserDto> GetUserByName(string userName, CancellationToken cancellationToken = default);
}
