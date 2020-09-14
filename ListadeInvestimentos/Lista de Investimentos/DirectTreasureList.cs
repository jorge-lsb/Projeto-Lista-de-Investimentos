using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    public class DirectTreasureList
    {
        public List<DirectTreasure> DirectTreasure { get; set; }

        public DirectTreasureList()
        {
            DirectTreasure = new List<DirectTreasure>();
        }

        public virtual void SetDirectTreasure(DirectTreasure directTreasure)
        {
            DirectTreasure.Add(directTreasure);
        }
    }
}
