using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace task3
{
    internal class HMAC
    {
        public static byte[] GenerateSecureKey()
        {
            byte[] salt = new byte[32];
            var generator = RandomNumberGenerator.Create();
            generator.GetBytes(salt);
            return salt;
        }

        public static byte[] ComputeHMAC(byte[] key, string message)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(message);
            var hash = new HMACSHA256(key);
            return hash.ComputeHash(bytes);
        }

    }
}
