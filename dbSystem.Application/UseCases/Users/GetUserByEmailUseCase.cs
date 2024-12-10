namespace dbSystem.Application.UseCases.Users;

using dbSystem.Application.Interfaces;
using dbSystem.Domain.Entities;

public class GetUserByEmailUseCase
{
    private readonly IUserRepository _userRepository;

    public GetUserByEmailUseCase(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<User?> ExecuteAsync(string email)
    {
        return await _userRepository.GetByEmailAsync(email);
    }
}