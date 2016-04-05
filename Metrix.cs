using LeagueSharp;
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
        private static readonly String prefix = "<font color = '#FF0000' > MetrixSharp: </font>";

        public static void PrintChat(String format)
        {
            Game.PrintChat(prefix + format);
        }

        public static void PrintChat(String format, params object[] @params)
        {
            Game.PrintChat(prefix + format, @params);
        }
    }
}
