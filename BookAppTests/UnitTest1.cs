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
        public void ValidatePassword_CheckIfTooShort_ReturnsError()
        { 
            var userService = new UserService();
            string result = userService.ValidatePassword("shortp");

            Assert.AreEqual(result, "Password out of range");
        }

        [Test]
        public void ValidatePassword_CheckBlankPassword_ReturnsError()
        {
            var userService = new UserService();
            string result = userService.ValidatePassword("");
            
            Assert.AreEqual(result, "No password entered.");
        }

        [Test]
        public void ValidatePassword_CheckIfTooLong_ReturnError()
        {
            var userService = new UserService();
            string result = userService.ValidatePassword("thisisthelongestpasswordintheworld");

            Assert.AreEqual(result, "Password out of range");
        }
    }
}
