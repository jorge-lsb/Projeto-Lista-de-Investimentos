using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    // DirectTreasure Esta herdando propriedades da classe Investments
    public class StockExchangeShares : Investments
    {                
        public double SharePrice { get; set; }

        public double Pl { get; set; }

        public double Roe { get; set; }

        public string TypeStockExchangeShares { get; set; }

    }
}
