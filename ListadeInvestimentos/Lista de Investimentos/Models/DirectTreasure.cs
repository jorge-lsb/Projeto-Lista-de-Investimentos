    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    // DirectTreasure Esta herdando propriedades da classe Investments
    public class DirectTreasure : Investments
    {
        //Criando Propriedades de DirectTreasure

        public DateTime Duedate { get; set; }

        public string IncomeTaxType { get; set; }

        public double Price { get; set; }

        public string TypeDirectTreasure { get; set; }

        public DirectTreasure()
        {

        }
    }
}
