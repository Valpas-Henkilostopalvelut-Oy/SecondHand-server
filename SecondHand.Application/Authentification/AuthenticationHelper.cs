using System;
using System.Security.Cryptography;
using System.Text;

namespace SecondHand.Application.Authentification
{
    public class AuthenticationHelper
    {
        const int iterations = 10000; // Количество итераций PBKDF2 (рекомендуется использовать значение не менее 10,000)
        const int saltSize = 16;      // Размер соли (в байтах)
        const int hashSize = 32;      // Размер хеша (в байтах)
        public static byte[] GenerateSalt()
        {
            using (var rng = new RNGCryptoServiceProvider())
            {
                byte[] salt = new byte[saltSize];
                rng.GetBytes(salt);
                return salt;
            }
        }
        public static string HashPassword(string password, out byte[] salt)
        {
            salt = new byte[saltSize];
            using (var rng = new RNGCryptoServiceProvider())
            {
                rng.GetBytes(salt);
            }

            using (var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations, HashAlgorithmName.SHA256))
            {
                byte[] hashBytes = pbkdf2.GetBytes(hashSize);
                return Convert.ToBase64String(hashBytes);
            }
        }
        public static bool VerifyPassword(string enteredPassword, string storedHash, byte[] storedSalt)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(enteredPassword, storedSalt, iterations, HashAlgorithmName.SHA256))
            {
                byte[] enteredHashBytes = pbkdf2.GetBytes(hashSize);
                string enteredHash = Convert.ToBase64String(enteredHashBytes);
                return enteredHash == storedHash;
            }
        }
    }
}