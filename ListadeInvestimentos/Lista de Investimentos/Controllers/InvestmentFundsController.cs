using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lista_de_Investimentos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class InvestmentFundsController : Controller
    {
        private static readonly string[] managers = new[]
        {
            "Caio", "alfredo","guilherme","Heloisa","jorge","anderson"
        };

        private static readonly string[] typesfunds = new[]
       {
            "Renda-Fixa", "Ações","Cambiais","Multimercados","Divida-Externa","Referenciados"
        };


        [HttpGet]
        //Get para pegar as propriedades e atribuir valores e exibilos
       public InvestmentFundsList Get()
       {
            //Nova instancia Lista de fundo de investimentos
            InvestmentFundsList investmentFundsList = new InvestmentFundsList();

            // Classe radom para valores aleatorios
            Random random = new Random();

            //Gerando 6 fundos de investimentos com suas propridades
            for (int i = 0; i < 6; i++)
            {
                InvestmentFunds investmentFunds = new InvestmentFunds();
                investmentFunds.Name = $"Teste{i}";
                investmentFunds.MonthlyProfitability = 21;
                investmentFunds.Manager = managers[random.Next(managers.Length)];
                investmentFunds.Description = "Teste Descrição";
                investmentFunds.QuotaPrice = random.NextDouble() * 200;
                investmentFunds.TypeInvestmentFund = typesfunds[random.Next(typesfunds.Length)];
                investmentFunds.Initials = "SLA";
                investmentFundsList.SetInvestmentFunds(investmentFunds);
            }
            // retornando a lista de fundo de investimento
            return investmentFundsList;
       }

        [HttpPost]
        public InvestmentFundsList Set(InvestmentFundsList investmentFundsList)
        {
            return investmentFundsList;
        }
    }
}
