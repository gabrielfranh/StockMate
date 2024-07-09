using UserAPI.Dtos;

namespace UserAPI.Services.Interfaces;

public interface IUserService
{
    Task<bool> RegisterUserAsync(UserDto model);
    Task<string> AuthenticateUserAsync(LoginDto model);
}