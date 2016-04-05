using LeagueSharp;
using LeagueSharp.Common;
using MetrixScript.Cores;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixScript
{
    class Program
    {
        static void Main(string[] args)
        {
            Game.PrintChat(Color.Gray + "MetrixScript Actived");
            Game.PrintChat(Color.Gray + "Champion: " + Color.Green + Player.Champion.ChampionName);
        }

        static void GenerateMenu()
        {
            try
            {
                Menu menu = new Menu("Metrix Script", "MetrixScript", true);
                menu.AddToMainMenu();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
