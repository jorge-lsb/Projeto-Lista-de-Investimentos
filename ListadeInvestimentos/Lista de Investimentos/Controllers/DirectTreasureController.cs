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
    public class DirectTreasureController : Controller
    {
        [HttpGet]
        //Get para pegar as propriedades atribuir valores e mostrar depois
        public InvestimentList<DirectTreasure> Get()
        {
            //Nova instancia de lista de tesouro direto
            var directTreasureList = new InvestimentList<DirectTreasure>();

            //Intanciando radom para valores aleatorios
            Random random = new Random();

            //Gerando 6 tesouro direto
            for (int i = 0; i < 6; i++)
            {
                var valuesinitials = Enum.GetNames(typeof(InitialsTypeDirectTreasure));
                var type = Enum.GetNames(typeof(TypeDirectTreasure));

                //Nova instancia de tesouro direto
                DirectTreasure directTreasure = new DirectTreasure();
                directTreasure.Name = $"Tesouro direto{i + 1}";
                directTreasure.Description = $"Descrição teste{i + 1}";
                directTreasure.MonthlyProfitability = random.Next(1,45);
                directTreasure.Initials = valuesinitials[random.Next(valuesinitials.Length)];
                directTreasure.Price = random.NextDouble() * 200;
                directTreasure.TypeDirectTreasure = type[random.Next(type.Length)];
                directTreasureList.SetInvestment(directTreasure);
            }
            //Retornando a lista
            return directTreasureList;
        }

        [HttpPost]
        public InvestimentList<DirectTreasure> Set(InvestimentList<DirectTreasure> directTreasureList)
        {
            return directTreasureList;
        }
    }
}
