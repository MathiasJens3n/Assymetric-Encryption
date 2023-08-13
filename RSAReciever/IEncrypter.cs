using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace RSAReciever
{
    internal interface IEncrypter
    {
        public byte[] DecryptData(RSA rsa, byte[] encryptedData);
    }
}
