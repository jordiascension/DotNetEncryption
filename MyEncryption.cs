using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCoreCryptography
{
    public class MyEncryption
    {
        public static byte[] EncryptBytes(byte[] plainBytes, byte[] Key, byte[] IV)
        {
            byte[] encrypted;

            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using MemoryStream msEncrypt = new();
                using CryptoStream csEncrypt = new(msEncrypt, encryptor, CryptoStreamMode.Write);

                csEncrypt.Write(plainBytes, 0, plainBytes.Length);
                csEncrypt.Close();
                csEncrypt.Flush();

                encrypted = msEncrypt.ToArray();
            }

            return encrypted;
        }

        public static byte[] DecryptBytes(byte[] encrypted, byte[] Key, byte[] IV)
        {
            using (var aesAlg = Aes.Create())
            {
                aesAlg.Key = Key;
                aesAlg.IV = IV;

                ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

                using MemoryStream msDecrypt = new(encrypted);
                using CryptoStream csDecrypt = new(msDecrypt, decryptor, CryptoStreamMode.Read);
                using MemoryStream msDestination = new();

                csDecrypt.CopyTo(msDestination);

                return msDestination.ToArray();
            }
        }
    }
}
