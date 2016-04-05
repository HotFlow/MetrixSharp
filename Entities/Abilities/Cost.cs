using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetrixSharp.Entities.Abilities
{
    public class Cost
    {
        protected CostType m_type { get; }
        protected int m_value { get; }

        public Cost(CostType type,int value)
        {
            this.m_type = type;
            this.m_value = value;
        }

        public CostType GetCostType()
        {
            return this.m_type;
        }

        public int GetValue()
        {
            return this.m_value;
        }
    }
}
