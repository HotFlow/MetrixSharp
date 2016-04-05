using MetrixSharp.Entities.Abilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Champions
{
    public interface Champion : Entity
    {
        ChampionType GetChampionClass();

        ChampionAdvancedAttribute[] GetChampionAdvancedAttributes();

        ChampionSecondaryAttribute[] GetChampionSecondaryAttribute();

        Ability[] GetAbilities();
    }
}
