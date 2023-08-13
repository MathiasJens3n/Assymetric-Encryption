using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Diagnostics;
using System.Security.Cryptography.Xml;

namespace RSAReciever
{
    internal class RSAEncryption : IEncrypter
    {
        public byte[] DecryptData(RSA rsa, byte[] encryptedData)
        {
            return rsa.Decrypt(encryptedData, RSAEncryptionPadding.OaepSHA256);
        }
    }
}
