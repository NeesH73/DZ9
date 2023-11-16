using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Mousetrap:Game
    {
        public override void Play(string name)
        {
            Console.WriteLine("Игра в мышеловку " + name);
        }
    }
}
