﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Champions.SummonerSpells
{
    public class Barrier : SummonerSpell
    {
        public long GetCooldown()
        {
            return 210L;
        }

        public long GetRange()
        {
            return 0L;
        }
    }
}
