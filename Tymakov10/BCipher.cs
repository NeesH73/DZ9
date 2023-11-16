using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tymakov10
{
    internal class BCipher : ICipher
    {
        public string Encode(string letters)
        {
            char[] en = new char[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLower(letters[i]))
                {
                    en[i] = (char)('я' - (letters[i] - 'а'));
                }
                else if (char.IsUpper(letters[i]))
                {
                    en[i] = (char)('Я' - (letters[i] - 'А'));
                }
                else
                {
                    en[i] = letters[i];
                }
            }
            string ene = "";
            for (int i = 0; i < en.Length; i++)
            {
                ene += en[i];
            }
            return ene;
            
        }

        public string Decode(string letters)
        {
            char[] de = new char[letters.Length];

            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsLower(letters[i]))
                {
                    de[i] = (char)('я' - (letters[i] + 'а'));
                }
                else if (char.IsUpper(letters[i]))
                {
                    de[i] = (char)('Я' - (letters[i] + 'А'));
                }
                else
                {
                    de[i] = letters[i];
                }
            }
            string dee="";
            for (int i = 0;i<de.Length;i++)
            {
                dee += de[i];
            }
            return dee;

        }
    }

}
