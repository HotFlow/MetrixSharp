using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Champions.SummonerSpells
{
    public interface SummonerSpell
    {
        long GetCooldown();

        long GetRange();
    }
}
