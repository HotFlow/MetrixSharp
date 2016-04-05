using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Champions.SummonerSpells
{
    public class Teleport : SummonerSpell
    {
        public long GetCooldown()
        {
            return 300L;
        }

        public long GetRange()
        {
            return 99999L;
        }
    }
}
