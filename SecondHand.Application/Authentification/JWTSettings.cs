using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Authentification
{
    public class JWTSettings
    {
        public required string Secret { get; set; }
        public required string Issuer { get; set; }
        public required string Audience { get; set; }
        public required double AccessTokenExpiration { get; set; }
    }
    public class JWTToken
    {
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
    public class AuthSettings
    {
        public required int Iteration { get; set; }
        public required int SaltSize { get; set; }
        public required int HashSize { get; set; }
    }
}