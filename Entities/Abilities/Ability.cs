using MetrixSharp.Entities.Champions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Abilities
{
    public interface Ability
    {
        Slot GetSlot();

        String GetName();

        int GetLevel();

        Cost GetCost();

        int GetCD();

        float GetDamageToChampion(Champion champion);

        DamageType GetDamageType();

        ArchetType GetArchetType();

        AbilityType GetAbilityType();
    }
}
