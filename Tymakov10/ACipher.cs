using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov10
{
    internal class ACipher: ICipher
    {
        public string Encode(string letters)
        {
            string encoded = "";
            foreach (char c in letters) 
            { 
            encoded += (char)(c+1);
            }
            return encoded;
        }
        public string Decode(string letters) 
        {
            string decoded = "";
            foreach (char c in letters) 
            {
                decoded += (char)(c-1);
            }
            return decoded;
        }
    }
}
