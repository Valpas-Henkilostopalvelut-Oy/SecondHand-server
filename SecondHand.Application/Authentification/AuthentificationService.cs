using Microsoft.Extensions.Configuration;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Authentification
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly ICustomers _customers;
        private readonly IConfiguration _configuration; // Используется для доступа к настройкам конфигурации
        private readonly AuthenticationHelper _authHelper;

        public AuthentificationService(ICustomers customers, IConfiguration configuration)
        {
            _customers = customers;
            _configuration = configuration;
            _authHelper = new AuthenticationHelper();
        }

        public async Task<UserAuthentificationResult> LoginAsync(string email, string password)
        {
            // Проверка наличия пользователя с указанным email
            var customer = await _customers.GetOneByEmail(email);
            if (customer == null)
            {
                return UserAuthentificationResult.InvalidEmail;
            }

            // Проверка пароля
            if (!AuthenticationHelper.VerifyPassword(password, customer.Password, customer.Salt))
            {
                return UserAuthentificationResult.InvalidPassword;
            }

            // Генерация токена
            var token = JWTHelper.GenerateToken(customer.Id.ToString());

            // Генерация refresh-токена
            var refreshToken = JWTHelper.GenerateRefreshToken();
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