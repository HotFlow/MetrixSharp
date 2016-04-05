using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities
{
    public interface Entity
    {
        float GetBaseHealth();

        float GetBaseHealthRegen();

        float GetBaseAttackDamage();

        float GetBaseArmor();

        float GetBaseAttackSpeed();

        float GetBaseMagicResist();

        float GetBaseMovementSpeed();
    }
}
