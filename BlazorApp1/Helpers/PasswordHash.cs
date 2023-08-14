using Microsoft.AspNetCore.Identity;
using BCrypt;
using NUnit.Framework;

namespace BCrypt.Net
{
    public class PasswordHasher<TUser> : IPasswordHasher<TUser> where TUser : class
    {
        public string HashPassword(TUser user, string password)
        {
            var hashedPassword = BCrypt.HashPassword(password);
            return hashedPassword;
        }

        public PasswordVerificationResult VerifyHashedPassword(TUser user, string hashedPassword, string providedPassword)
        {
            var result = BCrypt.Verify(providedPassword, hashedPassword);
            if (result.Success)
            {
                return PasswordVerificationResult.Success;
            } else if (result.Failed)
            {
                return PasswordVerificationResult.Failed;
            }
        }
    }
}