using System.Security.Cryptography;
using System.Text;

namespace FrameSequenceManager {

    public static class Password {

        public static string GenerateSalt() {
            using var rng = RandomNumberGenerator.Create();
            byte[] salt = new byte[16];
            rng.GetBytes(salt);
            return Convert.ToBase64String(salt);
        }

        public static string HashPassword(string password, string salt) {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password + salt));
            return Convert.ToBase64String(bytes);
        }

        public static bool VerifyPassword(string password, string salt, string HashedPassword) {
            string hashToVerify = HashPassword(password, salt);
            return hashToVerify == HashedPassword;
        }
    }
}
