using LeagueSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixScript.Cores
{
    public static class Player
    {
        public static Obj_AI_Hero Champion
        {
            get
            {
                return ObjectManager.Player;
            }
        }

        
    }
}
