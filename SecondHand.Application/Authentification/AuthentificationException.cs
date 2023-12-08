namespace SecondHand.Application.Authentification
{
    public class AuthentificationException : Exception
    {
        public int StatusCode { get; set; }
        public string ErrorMessage { get; set; }
        public AuthentificationException(int statusCode, string errorMessage)
        {
            StatusCode = statusCode;
            ErrorMessage = errorMessage;
        }
    }
}