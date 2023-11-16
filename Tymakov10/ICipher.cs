using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov10
{
    internal interface ICipher
    {
        string Encode(string letters);
        string Decode(string letters);

    }
}
