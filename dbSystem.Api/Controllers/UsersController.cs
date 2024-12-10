using Microsoft.AspNetCore.Mvc;
using dbSystem.Application.UseCases.Users;

namespace dbSystem.API.Controllers;

[ApiController]
[Route("api/users")]
public class UsersController : ControllerBase
{
    private readonly GetUserByEmailUseCase _getUserByEmailUseCase;

    public UsersController(GetUserByEmailUseCase getUserByEmailUseCase)
    {
        _getUserByEmailUseCase = getUserByEmailUseCase;
    }

    [HttpGet("email/{email}")]
    public async Task<IActionResult> GetByEmail(string email)
    {
        var user = await _getUserByEmailUseCase.ExecuteAsync(email);
        if (user == null)
            return NotFound();

        return Ok(user);
    }
}
