using NUnit.Framework;
using SecureUserLib;

namespace SecureUserLib.Tests
{
    public class AuthServiceTests
    {
        [Test]
        public void Register_ShouldHashPassword()
        {
            // Arrange
            var authService = new AuthService();

            // Act
            var user = authService.Register("testuser", "password123");

            // Assert
            Assert.AreNotEqual("password123", user.HashedPassword);
        }

        [Test]
        public void Login_ShouldReturnTrue_ForCorrectPassword()
        {
            // Arrange
            var authService = new AuthService();
            var user = authService.Register("testuser", "password123");

            // Act
            bool result = authService.Login(user, "password123");

            // Assert
            Assert.IsTrue(result);
        }

        [Test]
        public void Encryption_ShouldEncryptAndDecryptCorrectly()
        {
            // Arrange
            var encryption = new EncryptionService();
            string originalText = "SensitiveData";

            // Act
            byte[] encrypted = encryption.Encrypt(originalText);
            string decrypted = encryption.Decrypt(encrypted);

            // Assert
            Assert.AreEqual(originalText, decrypted);
        }
    }
}
