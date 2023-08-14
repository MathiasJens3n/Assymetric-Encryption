using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSASender
{
    internal class RSAEncryption
    {
        public byte[] EncryptData(RSA rsa, byte[] plainText)
        {
            return rsa.Encrypt(plainText, RSAEncryptionPadding.OaepSHA256);
        }
    }
}
