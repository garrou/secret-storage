using System.Security.Cryptography;
using System.Text;

namespace SecretStorage.src.utils
{
    /// <summary>
    /// Encrypt utils class to manage the encryption
    /// </summary>
    public class EncryptUtils
    {
        /// <summary>
        /// Encrypt the given string
        /// </summary>
        /// <param name="toEncrypt">String to encrypt</param>
        /// <returns>Return encryption string</returns>
        public static string Encrypt(string toEncrypt)
        {
            byte[] data = Encoding.ASCII.GetBytes(toEncrypt);
            data = new SHA256Managed().ComputeHash(data);
            return Encoding.ASCII.GetString(data);
        }
    }
}
