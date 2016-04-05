using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixScript.Entities.Champions.Abilities
{
    public interface Ability
    {
        int getSlot();

        String getName();

        int getLevel();

        int getMana();

        int getCD();

        int getDamageToChampion(Champion champion);

        AbilityType getAbilityType();
    }
}
