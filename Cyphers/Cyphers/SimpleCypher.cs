using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyphers
{
    class SimpleCypher:IEncryptor
    {
        public string encrypt(string st)
        {
            return st;
        }
        public string decrypt(string st)
        {
            return st;
        }
    }
}
