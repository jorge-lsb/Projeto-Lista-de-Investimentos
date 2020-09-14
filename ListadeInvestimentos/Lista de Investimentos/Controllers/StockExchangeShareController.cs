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
       [HttpGet]
       public StockExchangeSharesList Get()
        {
            StockExchangeSharesList stockExchangeSharesList = new StockExchangeSharesList();

            for (int i = 0; i < 6; i++)
            {
                StockExchangeShares stockExchangeShares = new StockExchangeShares();
                stockExchangeShares.Name = $"Teste{1}";
                stockExchangeShares.Pl = 10;
                stockExchangeShares.Roe = 10;
                stockExchangeShares.SharePrice = 12.96;
                stockExchangeShares.MonthlyProfitability = 21;
                stockExchangeShares.Initials = "Teste";
                stockExchangeShares.Description = "Ação teste";
                stockExchangeShares.TypeStockExchangeShares = "on";
                stockExchangeSharesList.SetStockExchangeShares(stockExchangeShares);


            }
            return stockExchangeSharesList;
        }
    }
}
