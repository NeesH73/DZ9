using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Beach:Game
    {
        public override void Play(string name)
        {
            Console.WriteLine("Игра на пляже " + name);
        }
    }
}
