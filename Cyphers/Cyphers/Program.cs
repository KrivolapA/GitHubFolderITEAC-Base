using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyphers
{
    class Program
    {
        static void Main(string[] args)
        {
            IEncryptor cypher = new ComplexCypher();
                EncryptedMessage mess = new EncryptedMessage("Text", cypher);
            Console.WriteLine(mess.DecryptWith(cypher));
            Console.ReadLine();
        }
    }
}
