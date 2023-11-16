using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Fishing:Game
    {
        public override void Play(string tname)
        {
            Console.WriteLine("Игра в рыбалку " + tname);
        }
    }
}
