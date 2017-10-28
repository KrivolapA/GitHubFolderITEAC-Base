using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cyphers
{
    class EncryptedMessage
    {
        string message;        
        IEncryptor cypher;
        public EncryptedMessage(string message, IEncryptor cypher)
        {
            this.cypher = cypher;
            this.message = cypher.encrypt(message);
        }
        public string DecryptWith(IEncryptor cypher)
        {
            return cypher.decrypt(message);
        }
    }
}
