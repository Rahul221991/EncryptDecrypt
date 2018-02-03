using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EncryptDecrypt
{
    class Program
    {
        static void Main(string[] args)
        {
            string encrypt = CryptoEngine.Encrypt("a", "sblw-3hn8-sqoy19");
            Console.WriteLine(encrypt);
            string decrypt = CryptoEngine.Decrypt(encrypt, "sblw-3hn8-sqoy19");
            Console.WriteLine(decrypt);
            Console.ReadLine();
        }
    }
}
