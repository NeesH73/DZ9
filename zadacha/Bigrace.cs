using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha
{
    internal class Bigrace
    {
       Game[] games = new Game[]{new Beach(),new Mousetrap(),new HideandSeek(),new Fishing(),new Slide(),new Postmen(),new Sea()};
       public void PlayGames(string team)
       {
           foreach (var game in games)
           {
                game.Play(team);
           }
       }
    }
}
