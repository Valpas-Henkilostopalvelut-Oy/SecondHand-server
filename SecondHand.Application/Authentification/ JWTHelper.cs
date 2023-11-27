using Microsoft.IdentityModel.Tokens;
using Microsoft.Extensions.Configuration;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SecondHand.Application.Authentification
{
    public class JWTHelper
    {
        private readonly IConfiguration _configuration;
        private readonly SymmetricSecurityKey _key;

        public JWTHelper(IConfiguration configuration)
        {
            _configuration = configuration;
            _key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
        }

        public string GenerateToken(string userId)
        {
            // Генерация токена, включая информацию о сроке действия
            DateTime expiration = DateTime.UtcNow.AddHours(168); // Например, токен действителен в течение 1 часа
            var claims = new List<Claim>
        {
            new Claim(ClaimTypes.Name, userId),
            new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(expiration).ToUnixTimeSeconds().ToString())
        };

            var creds = new SigningCredentials(_key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                _configuration["Jwt:Issuer"],
                _configuration["Jwt:Audience"],
                claims,
                expires: expiration,
                signingCredentials: creds
            );

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public bool VerifyToken(string token)
        {
            try
            {
                var tokenHandler = new JwtSecurityTokenHandler();

                tokenHandler.ValidateToken(token, new TokenValidationParameters
                {
                    ValidateIssuer = false,
                    ValidateAudience = false,
                    IssuerSigningKey = _key
                }, out SecurityToken validatedToken);

                var jwtToken = (JwtSecurityToken)validatedToken;

                // Проверка срока действия токена
                var expiration = jwtToken.ValidTo;
                if (expiration < DateTime.UtcNow)
                {
                    // Токен истек
                    return false;
                }

                return true;
            }
            catch
            {
                // Токен недействителен
                return false;
            }
        }
    }
}