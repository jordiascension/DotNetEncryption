using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCoreCryptography
{
    public class HashEncryption
    {
        public static byte[] ComputeHash(byte[] data)
        {
            using var sha256 = SHA256.Create();
            return sha256.ComputeHash(data);
        }

        public static bool VerifyHash(byte[] original, byte[] hash)
        {
            using var sha256 = SHA256.Create();
            var newHash = sha256.ComputeHash(original);
            return newHash.SequenceEqual(hash);
        }
    }
}
