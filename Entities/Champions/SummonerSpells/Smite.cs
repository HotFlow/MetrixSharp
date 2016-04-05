using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Champions.SummonerSpells
{
    public class Smite : SummonerSpell
    {
        public long GetCooldown()
        {
            return 75L;
        }

        public long GetRange()
        {
            return 500L;
        }
    }
}
