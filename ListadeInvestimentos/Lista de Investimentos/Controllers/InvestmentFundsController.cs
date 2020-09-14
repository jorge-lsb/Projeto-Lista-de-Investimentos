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
        [HttpGet]
        //Get para pegar as propriedades e atribuir valores e exibilos
       public InvestmentFundsList Get()
       {
            //Nova instancia Lista de fundo de investimentos
            InvestmentFundsList investmentFundsList = new InvestmentFundsList();

            //Gerando 6 fundos de investimentos com suas propridades
            for (int i = 0; i < 6; i++)
            {
                InvestmentFunds investmentFunds = new InvestmentFunds();
                investmentFunds.Name = $"Teste{i}";
                investmentFunds.MonthlyProfitability = 21;
                investmentFunds.Manager = $"Gestor{i}";
                investmentFunds.Description = "Teste Descrição";
                investmentFunds.QuotaPrice = 118;
                investmentFunds.TypeInvestmentFund = "RENDA VARIAVEL";
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
