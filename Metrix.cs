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
    public class Metrix
    {
        private static readonly String m_prefix = "<font color = '#FF0000' > MetrixSharp: </font>";

        public static void PrintChat(String format)
        {
            Game.PrintChat(m_prefix + format);
        }

        public static void PrintChat(String format, params object[] @params)
        {
            Game.PrintChat(m_prefix + format, @params);
        }

        public static void Initializ()
        {
            Metrix.PrintChat("Actived");
            Metrix.PrintChat("Playing Champion " + Player.Champion.ChampionName);
        }

        public static void GenerateMenu()
        {
            try
            {
                Menu menu = new Menu("MetrixSharp", "MetrixSharp", true);
                menu.AddToMainMenu();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
