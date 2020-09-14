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
        public DirectTreasureList Get()
        {
            DirectTreasureList directTreasureList = new DirectTreasureList();

            for (int i = 0; i < 6; i++)
            {
                DirectTreasure directTreasure = new DirectTreasure();
                directTreasure.Name = $"Teste{i}";
                directTreasure.Description = "Descrição teste";
                directTreasure.MonthlyProfitability = 10;
                directTreasure.Initials = "TESTE!";
                directTreasure.Price = 100;
                directTreasure.TypeDirectTreasure = "POS-FIXADO";
                directTreasureList.SetDirectTreasure(directTreasure);
            }
            return directTreasureList;
        }
        [HttpPost]
        public DirectTreasureList Set(DirectTreasureList directTreasureList)
        {
            return directTreasureList;
        }
    }
}
