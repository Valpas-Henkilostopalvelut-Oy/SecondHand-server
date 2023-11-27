using SecondHand.Application.Authentification;
using SecondHand.Application.Dtos;

namespace SecondHand.Application.Interfaces
{
    public interface IAuthentificationService
    {
        Task<AuthResult> RegisterAsync(string email, string password, string name);
        Task<AuthResult> LoginAsync(string email, string password);
        Task<UserRefreshTokenResult> RefreshTokenAsync(string token, string refreshToken);
        Task<AuthResult> UpdatePasswordAsync(string email, string oldPassword, string newPassword);
    }
}