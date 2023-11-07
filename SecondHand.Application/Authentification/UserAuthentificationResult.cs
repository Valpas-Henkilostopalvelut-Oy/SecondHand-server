namespace SecondHand.Application.Authentification
{
    public enum UserAuthentificationResult
    {
        Success,
        InvalidEmail,
        InvalidPassword,
        InvalidCredentials
    }
    public enum UserRegistrationResult
    {
        Success,
        InvalidEmail,
        InvalidPassword,
        EmailAlreadyExists
    }
    public enum UserUpdatePasswordResult
    {
        Success,
        InvalidEmail,
        InvalidPassword,
        InvalidNewPassword,
        InvalidOldPassword
    }
    public enum UserRefreshTokenResult
    {
        Success,
        InvalidToken,
        InvalidRefreshToken
    }
}