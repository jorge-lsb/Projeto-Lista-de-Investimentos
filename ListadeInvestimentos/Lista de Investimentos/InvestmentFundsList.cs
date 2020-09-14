using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    // Gerando Uma classe de lista de Fundo de investimentos
    public class InvestmentFundsList
    {
        //Gerando nova instancia de lista de fundo de investimentos
        public List<InvestmentFunds> InvestmentFunds { get; set; }

        //Gerando nova lista de fundo de investimentos
        public InvestmentFundsList()
        {
            InvestmentFunds = new List<InvestmentFunds>();
        }

        // Metodo adicionando novos fundos a lista
        public virtual void SetInvestmentFunds(InvestmentFunds investmentFunds)
        {
            InvestmentFunds.Add(investmentFunds);
        }
    }
}
