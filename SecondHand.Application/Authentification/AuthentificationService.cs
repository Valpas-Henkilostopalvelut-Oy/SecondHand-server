using Microsoft.Extensions.Options;
using SecondHand.Application.Dtos;
using SecondHand.Application.Interfaces;
using SecondHand.Domain.Entities;
using SecondHand.Domain.Interfaces;

namespace SecondHand.Application.Authentification
{
    public class AuthentificationService : IAuthentificationService
    {
        private readonly ICustomers _customers;
        private readonly JwtGenerator _jwtGenerator;
        private readonly JwtVerifier _jwtVerifier;

        public AuthentificationService(ICustomers customers, JwtGenerator jwtGenerator, JwtVerifier jwtVerifier)
        {
            _customers = customers;
            _jwtGenerator = jwtGenerator;
            _jwtVerifier = jwtVerifier;
        }

        public async Task<bool> CheckTokenValidityAsync(string token)
        {
            return _jwtVerifier.VerifyToken(token);
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

            var token = _jwtGenerator.GenerateToken(customer);

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

            var token = _jwtGenerator.GenerateToken(customer);

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

            var token = _jwtGenerator.GenerateToken(customer);

            return new AuthResult
            {
                Token = token,
                ErrorMessage = null
            };
        }
    }
}
