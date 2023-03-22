using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DotnetCoreCryptography
{
    public class RSAEncryption
    {
        public static byte[] EncryptBytes(byte[] DataToEncrypt, RSAParameters RSAKeyInfo)
        {
            try
            {
                byte[] encryptedData;
                using (var rsa = RSA.Create())
                {

                    rsa.ImportParameters(RSAKeyInfo);

                    encryptedData = rsa.Encrypt(DataToEncrypt, RSAEncryptionPadding.OaepSHA512);
                }
                return encryptedData;
            }

            catch (CryptographicException e)
            {
                Console.WriteLine(e.Message);

                return null;
            }
        }

       public static byte[] DecryptBytes(byte[] DataToDecrypt, RSAParameters RSAKeyInfo)
        {
            try
            {
                byte[] decryptedData;

                using (var rsa = RSA.Create())
                {

                    rsa.ImportParameters(RSAKeyInfo);

                    decryptedData = rsa.Decrypt(DataToDecrypt, RSAEncryptionPadding.OaepSHA512);
                }
                return decryptedData;
            }

            catch (CryptographicException e)
            {
                Console.WriteLine(e.ToString());

                return null;
            }
        }
    }
}
