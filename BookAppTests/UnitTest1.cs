using System;
using NUnit.Framework;
using BlazorApp1.Data;
using MySqlX.XDevAPI.Common;

namespace BlazorApp1.Tests
{
    [TestFixture]
    public class PasswordValidationTests
    {
        [Test]
        public void ValidatePassword_TooShort_ReturnsError()
        { 
            var userService = new UserService();
            var passwordLengthRange = new UserService.Range(8, 20);
            string result = userService.ValidatePassword("test", passwordLengthRange);

            Assert.AreEqual(result, "Password out of range");
        }

        [Test]
        public void ValidatePassword_TooLong_ReturnsError()
        {
            var userService = new UserService();
            var passwordLengthRange = new UserService.Range(8, 20);
            string result = userService.ValidatePassword("professorstinksalotthethird", passwordLengthRange);
            
            Assert.AreEqual(result, "Password out of range");
        }
    }
}
