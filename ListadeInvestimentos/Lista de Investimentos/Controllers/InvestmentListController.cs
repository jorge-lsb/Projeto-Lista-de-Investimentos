using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lista_de_Investimentos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestmentListController : Controller
    {
        // Vetor de sligas de investimentos 
        private static readonly string[] initials1 = new[]
         {
            "BIDI4", "ABEV3", "PETZ3", "PETR4", "FLRY4", "MOVI3"
        };

        // Vetor de sligas de investimentos 
        private static readonly string[] initials = new[]
        {
            "LTN", "NTN-F", "LFT", "NTN-B"
        };


        // Pegando Informações para exibir
        [HttpGet]
        public InvestimentList Get()
        {
            // Intancia de uma nova lista de investimentos (InvestimentList)
            InvestimentList investimentList = new InvestimentList();

            // Intanciando a classe Random para gerar valores de rentabilidade aleatorios e siglas aleatorias;
            Random random = new Random();

            //Gerando nova lista de investimentos com 6
            for (int i = 0; i < 6; i++)
            {
                //Intanciando classes de investimentos
                DirectTreasure directTreasure = new DirectTreasure();
                InvestmentFunds investmentFunds = new InvestmentFunds();
                StockExchangeShares stockExchangeShares = new StockExchangeShares();
                
                //Adicionando suas caracteristicas

                stockExchangeShares.Name = $"Ação{i}";
                stockExchangeShares.MonthlyProfitability = random.Next(10, 50);
                stockExchangeShares.Initials = initials1[random.Next(initials1.Length)];
                stockExchangeShares.Description = "Ação teste";


                investmentFunds.Name = $"Fundo de Investimento{i + 1}";
                investmentFunds.MonthlyProfitability = 21;
                investmentFunds.Description = "Teste Descrição";                             
                investmentFunds.Initials = "SLA";


                directTreasure.Name = $"Tesouro direto{i + 1}";
                directTreasure.Description = $"Descrição teste{i + 1}";
                directTreasure.MonthlyProfitability = random.Next(1, 45);
                directTreasure.Initials = initials[random.Next(initials.Length)];

                investimentList.SetInvestment(stockExchangeShares);
                investimentList.SetInvestment(directTreasure);
                investimentList.SetInvestment(investmentFunds);
            }

            return investimentList;
        }
        [HttpPost]
        public InvestimentList Set(InvestimentList investimentList)
        {
            return investimentList;
        }
    }
}
