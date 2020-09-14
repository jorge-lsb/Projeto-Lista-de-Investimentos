using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    public class InvestmentFundsList
    {
        public List<InvestmentFunds> InvestmentFunds { get; set; }

        public InvestmentFundsList()
        {
            InvestmentFunds = new List<InvestmentFunds>();
        }

        public virtual void SetInvestmentFunds(InvestmentFunds investmentFunds)
        {
            InvestmentFunds.Add(investmentFunds);
        }
    }
}
