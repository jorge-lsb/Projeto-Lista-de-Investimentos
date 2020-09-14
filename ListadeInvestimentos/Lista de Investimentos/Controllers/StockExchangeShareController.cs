using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lista_de_Investimentos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StockExchangeShareController : Controller
    {
        private static readonly string[] initials = new[]
       {
            "BIDI4", "ABEV3", "PETZ3", "PETR4", "FLRY4", "MOVI3"
        };
        [HttpGet]
       public StockExchangeSharesList Get()
        {
            //Nova intancia de lista de ações
            StockExchangeSharesList stockExchangeSharesList = new StockExchangeSharesList();

            //intancia de classe random para valores aleatorios
            Random random = new Random();

            // For para gerar novas ações
            for (int i = 0; i < 6; i++)
            {
                //Nova instancia de ação atribuindo dados a ela
                StockExchangeShares stockExchangeShares = new StockExchangeShares();
                stockExchangeShares.Name = $"Teste{i}";
                stockExchangeShares.Pl = random.NextDouble() * 10;
                stockExchangeShares.Roe = random.NextDouble() * 10;
                stockExchangeShares.SharePrice = random.NextDouble() * 100;
                stockExchangeShares.MonthlyProfitability = random.Next(10,50);
                stockExchangeShares.Initials = initials[random.Next(initials.Length)];
                stockExchangeShares.Description = "Ação teste";
                stockExchangeShares.TypeStockExchangeShares = "on";
                stockExchangeSharesList.SetStockExchangeShares(stockExchangeShares);
            }
            return stockExchangeSharesList;
        }

        [HttpPost]
        public StockExchangeSharesList Set(StockExchangeSharesList stockExchangeSharesList)
        {
            return stockExchangeSharesList;
        }
    }
}
