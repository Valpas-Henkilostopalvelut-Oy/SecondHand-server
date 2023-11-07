using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Application.Authentification;

namespace SecondHand.Application.Interfaces
{
    public interface IAuthentificationService
    {
        Task<UserRegistrationResult> RegisterAsync(string email, string password, string name);
        Task<UserAuthentificationResult> LoginAsync(string email, string password);
        Task<UserRefreshTokenResult> RefreshTokenAsync(string token, string refreshToken);
        Task<UserUpdatePasswordResult> UpdatePasswordAsync(string email, string oldPassword, string newPassword);
    }
}