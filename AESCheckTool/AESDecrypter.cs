using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Json;

namespace AESCheckTool
{
    internal static class AESDecrypter
    {
        /// <summary>
		/// 先頭16byteをIVとみなし、AES256で復号する
		/// </summary>
		private static string Decrypt(byte[] aesKey, byte[] encrypted)
        {
            var iv = encrypted.Take(16).ToArray();
            var data = encrypted.Skip(16).ToArray();

            using (var aes = Aes.Create())
            {
                aes.Padding = PaddingMode.PKCS7;
                aes.KeySize = 256;
                aes.Key = aesKey;
                aes.IV = iv;
                using (var decryptor = aes.CreateDecryptor())
                {
                    return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(data, 0, data.Length));
                }
            }
        }

        public static string DecryptAuthenticationInfo(string cookieValue, string encryptionKey)
        {
            var aesKey = Convert.FromBase64String(encryptionKey);
            var encrypted = Convert.FromBase64String(cookieValue);
            try
            {
                var decrypted = Decrypt(aesKey, encrypted);
                var json = JsonSerializer.Deserialize<object>(decrypted);
                return JsonSerializer.Serialize(json, new JsonSerializerOptions
                {
                    WriteIndented = true
                });
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
