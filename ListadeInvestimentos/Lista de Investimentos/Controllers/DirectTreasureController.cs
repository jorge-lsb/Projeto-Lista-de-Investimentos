using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lista_de_Investimentos.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DirectTreasureController : Controller
    {
        [HttpGet]
        //Get para pegar as propriedades atribuir valores e mostrar depois
        public DirectTreasureList Get()
        {
            //Nova instancia de lista de tesouro direto
            DirectTreasureList directTreasureList = new DirectTreasureList();

            //Gerando 6 tesouro direto
            for (int i = 0; i < 6; i++)
            {
                //Nova instancia de tesouro direto
                DirectTreasure directTreasure = new DirectTreasure();
                directTreasure.Name = $"Teste{i}";
                directTreasure.Description = "Descrição teste";
                directTreasure.MonthlyProfitability = 10;
                directTreasure.Initials = "TESTE!";
                directTreasure.Price = 100;
                directTreasure.TypeDirectTreasure = "POS-FIXADO";
                directTreasureList.SetDirectTreasure(directTreasure);
            }
            //Retornando a lista
            return directTreasureList;
        }

        [HttpPost]
        public DirectTreasureList Set(DirectTreasureList directTreasureList)
        {
            return directTreasureList;
        }
    }
}
