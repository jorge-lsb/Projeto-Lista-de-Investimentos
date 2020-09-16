using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    // InvestmentFunds Esta herdando propriedades da classe Investments
    public class InvestmentFunds : Investments
    {
        public string Manager { get; set; }

        public double QuotaPrice { get; set; }

        public string TypeInvestmentFund { get; set; }

        // Contrutor Vazio
        //public InvestmentFunds()
        //{

        //}


    }
}
