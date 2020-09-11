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
        private static readonly string[] initials = new[]
        {
            "BIDI4", "ABEV3", "FIA", "FIC", "LTN", "LFT"
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
                Investments investments = new Investments();
                investments.Name = $"Nome{i + 1}";
                investments.MonthlyProfitability = random.Next(10, 60);
                investments.Description = $"Descrição{i + 1}";
                investments.Initials = initials[random.Next(initials.Length)];
                investimentList.SetInvestment(investments);
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
