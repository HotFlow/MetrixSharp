using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Champions.SummonerSpells
{
    public class Heal : SummonerSpell
    {
        public long GetCooldown()
        {
            return 240L;
        }

        public long GetRange()
        {
            return 850L;
        }
    }
}
