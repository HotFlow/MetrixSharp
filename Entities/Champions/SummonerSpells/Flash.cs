using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Champions.SummonerSpells
{
    public class Flash : SummonerSpell
    {
        public long GetCooldown()
        {
            return 300L;
        }

        public long GetRange()
        {
            return 425L;
        }
    }
}
