using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SecondHand.Application.Authentification;



namespace SecondHand.Application.Interfaces
{
    public interface IAuthentificationService
    {
        Task<AuthResult> RegisterAsync(string email, string password, string name);
        Task<AuthResult> LoginAsync(string email, string password);
        Task<UserRefreshTokenResult> RefreshTokenAsync(string token, string refreshToken);
        Task<AuthResult> UpdatePasswordAsync(string email, string oldPassword, string newPassword);
    }

    public class AuthResult
    {
        public string Token { get; set; }
        public string ErrorMessage { get; set; }
    }

}