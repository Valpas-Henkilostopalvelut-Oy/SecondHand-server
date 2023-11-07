using SecondHand.Application.Interfaces;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Authentification
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly ICustomers _customers;
        public Task<UserAuthentificationResult> LoginAsync(string email, string password)
        {
            throw new NotImplementedException();
        }

        public Task<UserRefreshTokenResult> RefreshTokenAsync(string token, string refreshToken)
        {
            throw new NotImplementedException();
        }

        public Task<UserRegistrationResult> RegisterAsync(string email, string password, string name)
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdatePasswordResult> UpdatePasswordAsync(string email, string oldPassword, string newPassword)
        {
            throw new NotImplementedException();
        }
    }
}