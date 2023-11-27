using Microsoft.Extensions.Configuration;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
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

        public async Task<AuthResult> LoginAsync(string email, string password)
        {
            var customer = await _customers.GetOneByEmail(email);
            if (customer == null)
            {
                return new AuthResult
                {
                    Token = null,
                    ErrorMessage = "User with this email not found"
                };
            }

            if (!AuthenticationHelper.VerifyPassword(password, customer.Password, customer.Salt))
            {
                return new AuthResult
                {
                    Token = null,
                    ErrorMessage = "Invalid password"
                };
            }

            var token = new JWTHelper(_configuration).GenerateToken(customer.Id.ToString());

            return new AuthResult
            {
                Token = token,
                ErrorMessage = null
            };
        }

        public Task<UserRefreshTokenResult> RefreshTokenAsync(string token, string refreshToken)
        {
            throw new NotImplementedException();
        }

        public async Task<AuthResult> RegisterAsync(string email, string password, string name)
        {
            var salt = AuthenticationHelper.GenerateSalt();
            var isEmailExist = _customers.GetOneByEmail(email).Result != null;

            if (isEmailExist)
            {
                return new AuthResult
                {
                    Token = null,
                    ErrorMessage = "User with this email already exist"
                };
            }

            var hashedPassword = AuthenticationHelper.HashPassword(password, out salt);

            var customer = new Customers
            {
                Email = email,
                Password = hashedPassword,
                Salt = salt,
                Name = name,
                CreatedAt = DateTime.UtcNow,
                IsDeleted = false,
                RowVersion = new byte[0],
                Version = 0
            };

            await _customers.Create(customer);

            var token = new JWTHelper(_configuration).GenerateToken(customer.Id.ToString());

            return new AuthResult
            {
                Token = token,
                ErrorMessage = null
            };
        }

        public async Task<AuthResult> UpdatePasswordAsync(string email, string oldPassword, string newPassword)
        {
            var customer = await _customers.GetOneByEmail(email);

            if (customer == null)
            {
                return new AuthResult
                {
                    Token = null,
                    ErrorMessage = "User with this email not found"
                };
            }

            if (!AuthenticationHelper.VerifyPassword(oldPassword, customer.Password, customer.Salt))
            {
                return new AuthResult
                {
                    Token = null,
                    ErrorMessage = "Invalid password"
                };
            }

            var salt = AuthenticationHelper.GenerateSalt();
            var hashedPassword = AuthenticationHelper.HashPassword(newPassword, out salt);

            customer.Password = hashedPassword;

            await _customers.Update(customer);

            var token = new JWTHelper(_configuration).GenerateToken(customer.Id.ToString());

            return new AuthResult
            {
                Token = token,
                ErrorMessage = null
            };
        }
    }
}