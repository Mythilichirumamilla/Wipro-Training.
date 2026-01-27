using System.Security.Cryptography;
using System.Text;

namespace SecureUserLib
{
    public class EncryptionService
    {
        private readonly byte[] key = Encoding.UTF8.GetBytes("1234567890123456");
        private readonly byte[] iv = Encoding.UTF8.GetBytes("1234567890123456");

        public byte[] Encrypt(string data)
        {
            using Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;

            using var encryptor = aes.CreateEncryptor();
            return encryptor.TransformFinalBlock(
                Encoding.UTF8.GetBytes(data), 0, data.Length);
        }

        public string Decrypt(byte[] encryptedData)
        {
            using Aes aes = Aes.Create();
            aes.Key = key;
            aes.IV = iv;

            using var decryptor = aes.CreateDecryptor();
            byte[] result = decryptor.TransformFinalBlock(
                encryptedData, 0, encryptedData.Length);

            return Encoding.UTF8.GetString(result);
        }
    }
}
