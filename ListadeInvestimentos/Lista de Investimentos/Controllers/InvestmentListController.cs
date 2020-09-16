using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lista_de_Investimentos.Enums;
using Microsoft.AspNetCore.Mvc;

namespace Lista_de_Investimentos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestmentListController : Controller
    {
        // Pegando Informações para exibir
        [HttpGet]
        public InvestimentList<Investments> Get()
        {
            // Intancia de uma nova lista de investimentos (InvestimentList)
            var investimentList = new InvestimentList<Investments>();

            // Intanciando a classe Random para gerar valores de rentabilidade aleatorios e siglas aleatorias;
            Random random = new Random();

            //Gerando nova lista de investimentos com 6
            for (int i = 0; i < 6; i++)
            {
                //Intanciando classes de investimentos
                var directTreasure = new DirectTreasure();
                var investmentFunds = new InvestmentFunds();
                var stockExchangeShares = new StockExchangeShares();


                //Adicionando suas caracteristicas

                var initialsStockEx = Enum.GetNames(typeof(InitialsStockExchangeShare));
                stockExchangeShares.Name = $"Ação{i}";
                stockExchangeShares.MonthlyProfitability = random.Next(10, 50);
                stockExchangeShares.Initials = initialsStockEx[random.Next(initialsStockEx.Length)];
                stockExchangeShares.Description = "Ação teste";


                investmentFunds.Name = $"Fundo de Investimento{i + 1}";
                investmentFunds.MonthlyProfitability = 21;
                investmentFunds.Description = "Teste Descrição";                             
                investmentFunds.Initials = "SLA";


                var valuesinitials = Enum.GetNames(typeof(InitialsTypeDirectTreasure));
                directTreasure.Name = $"Tesouro direto{i + 1}";
                directTreasure.Description = $"Descrição teste{i + 1}";
                directTreasure.MonthlyProfitability = random.Next(1, 45);
                directTreasure.Initials = valuesinitials[random.Next(valuesinitials.Length)];

                investimentList.SetInvestment(stockExchangeShares);
                investimentList.SetInvestment(directTreasure);
                investimentList.SetInvestment(investmentFunds);
            }

            return investimentList;
        }
        [HttpPost]
        public InvestimentList<Investments> Set(InvestimentList<Investments> investimentList)
        {
            return investimentList;
        }
    }
}
