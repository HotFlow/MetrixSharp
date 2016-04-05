using LeagueSharp;
using LeagueSharp.Common;
using MetrixSharp.Cores;
using SharpDX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Metrix.PrintChat(Color.Gray + "MetrixScript Actived");
            Metrix.PrintChat(Color.Gray + "Champion: " + Color.Green + Player.Champion.ChampionName);
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
