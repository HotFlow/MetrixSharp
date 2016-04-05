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
        private static readonly String prefix = "<font color = '#4876FF' > MetrixScript:</font>";

        public static void PrintChat(String format)
        {
            Game.PrintChat(prefix + format);
        }

        public static void PrintChat(String format, params object[] @params)
        {
            Game.PrintChat(prefix + format, @params);
        }

        public static void PrintChat(Color color, String format)
        {
            String rgb = color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            Metrix.PrintChat("<font color='#{0}'>{1}</font>", rgb, format);
        }

        public static void PrintChat(Color color, String format, params object[] @params)
        {
            String rgb = color.R.ToString("X2") + color.G.ToString("X2") + color.B.ToString("X2");
            Metrix.PrintChat("<font color='#" + rgb + "'>" + format + "</font>", @params);
        }
    }
}
