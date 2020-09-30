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
    public class StockExchangeShareController : Controller
    {
        [HttpGet]
       public InvestimentList<StockExchangeShares> Get()
        {
            //Nova intancia de lista de ações
            var stockExchangeSharesList = new InvestimentList<StockExchangeShares>();

            //intancia de classe random para valores aleatorios
            Random random = new Random();

            // For para gerar novas ações
            for (int i = 0; i < 6; i++)
            {
                var initialsStockEx = Enum.GetNames(typeof(InitialsStockExchangeShare));

                //Nova instancia de ação atribuindo dados a ela
                var stockExchangeShares = new StockExchangeShares();
                stockExchangeShares.Name = $"Teste{i}";
                stockExchangeShares.Pl = random.NextDouble() * 10;
                stockExchangeShares.Roe = random.NextDouble() * 10;
                stockExchangeShares.SharePrice = random.NextDouble() * 100;
                stockExchangeShares.MonthlyProfitability = random.Next(10,50);
                stockExchangeShares.Initials = initialsStockEx[random.Next(initialsStockEx.Length)];
                stockExchangeShares.Description = "Ação teste";
                stockExchangeShares.TypeStockExchangeShares = "on";
                stockExchangeSharesList.SetInvestment(stockExchangeShares);
            }
            return stockExchangeSharesList;
        }
        [HttpPost]
        public InvestimentList<StockExchangeShares> Set(InvestimentList<StockExchangeShares> stockExchangeSharesList)
        {
            return stockExchangeSharesList;
        }
    }
}
