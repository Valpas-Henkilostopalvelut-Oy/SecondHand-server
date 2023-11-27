using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SecondHand.Application.Dtos
{
    public class AuthResult
    {
        public string? Token { get; set; }
        public string? ErrorMessage { get; set; }
    }
    public enum UserRefreshTokenResult
    {
        Success,
        InvalidToken,
        InvalidRefreshToken
    }
    public enum DeleteDTO
    {
        Success,
        InvalidToken,
        InvalidRefreshToken,
        InvalidId
    }
}