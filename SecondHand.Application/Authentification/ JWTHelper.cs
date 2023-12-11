using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using SecondHand.Domain.Entities;

namespace SecondHand.Application.Authentification
{
    public class JwtGenerator
    {
        private readonly JWTSettings _jwtSettings;

        public JwtGenerator(IOptions<JWTSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        public string GenerateToken(Customers customer)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            // Ensure the key is at least 16 bytes long
            var keyBytes = Encoding.UTF8.GetBytes("wadssswaaswwfdxveS11wwdcjdieiw2-dwisjsjjw2");
            var key = new SymmetricSecurityKey(keyBytes);
            var signingCredentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha256Signature);



            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, customer.Id.ToString()),
                new Claim(ClaimTypes.Name, customer.Name),
                new Claim(ClaimTypes.Email, customer.Email),
                new Claim(ClaimTypes.Role, customer.Role.ToString())
            };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                SigningCredentials = signingCredentials,
                Issuer = "r4nd0m1ssu3rk3y", // Set Issuer here
                Audience = "r4nd0m4ud13nc3" // Set Audience here
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }

    public class JwtVerifier
    {
        private readonly JWTSettings _jwtSettings;

        public JwtVerifier(IOptions<JWTSettings> jwtSettings)
        {
            _jwtSettings = jwtSettings.Value;
        }

        public bool VerifyToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            // Ensure the key is at least 16 bytes long
            var keyBytes = Encoding.UTF8.GetBytes("wadssswaaswwfdxveS11wwdcjdieiw2-dwisjsjjw2");
            var key = new SymmetricSecurityKey(keyBytes);


            var tokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = key,
                ValidateIssuer = true, // Enable Issuer validation
                ValidIssuer = _jwtSettings.Issuer, // Set valid Issuer here
                ValidateAudience = true, // Enable Audience validation
                ValidAudience = _jwtSettings.Audience // Set valid Audience here
            };

            try
            {
                tokenHandler.ValidateToken(token, tokenValidationParameters, out _);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
