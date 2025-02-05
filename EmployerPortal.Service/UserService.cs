
using EmployerPortal.Data.Abstractions;
using EmployerPortal.Entities;
using EmployerPortal.Entities.DTO;
using EmployerPortal.Service.Abstractions;
using Mapster;

namespace EmployerPortal.Services;

public class UserService(IUserRepository userRepository) : IUserService
{
    public async Task<UserDto> GetUserByName(string userName, CancellationToken cancellationToken)
    {
        if (string.Empty == userName)
        {
            throw new ArgumentNullException(nameof(userName));
        }

        User user = await userRepository.GetUserByName(userName, cancellationToken);

        return user.Adapt<UserDto>();

    }
}
