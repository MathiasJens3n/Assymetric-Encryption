using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSAReciever
{
    internal class EncryptionManager
    {
        RSAEncryption rsaEncryption;
        public EncryptionManager()
        {
            rsaEncryption = new RSAEncryption();

        }
        public byte[] Decrypt(RSA rsa, byte[] encryptedData)
        {
            return rsaEncryption.DecryptData(rsa, encryptedData);
        }
    }
}
