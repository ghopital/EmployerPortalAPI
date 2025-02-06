using EmployerPortal.Service.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace EmployerPortal.Controllers
{
    [Route("api/user")]
    public class UserController(IUserService userService) : ControllerBase
    {
        [HttpGet]
        [Route("")]
        public async Task<IActionResult> Get(string userName, CancellationToken cancellationToken)
        {
            var result = await userService.GetUserByName(userName, cancellationToken);
            if (result == null)
            {
                return NotFound();
            }
            return Ok(result);
        }

    }
}
