using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bigrace games = new Bigrace();

            string[] teams = { "Россия", "Франция", "Китай", "Казахстан" };

            foreach (var team in teams)
            {
                games.PlayGames(team);
            }
        }
    }
}
