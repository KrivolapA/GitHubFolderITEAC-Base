using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyphers
{
    interface IEncryptor
    {
        string encrypt(string text);
        string decrypt(string text);
    }
}
