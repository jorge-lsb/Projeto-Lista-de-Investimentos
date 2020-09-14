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
        // Vetor de sligas de investimentos 
        private static readonly string[] initials = new[]
        {
            "LTN", "NTN-F", "LFT", "NTN-B"
        };

        // Vetor de Tipo de investimentos 
        private static readonly string[] type = new[]
        {
            "POS-FIXADO", "PRÉ-FIXADO"
        };

        [HttpGet]
        //Get para pegar as propriedades atribuir valores e mostrar depois
        public DirectTreasureList Get()
        {
            //Nova instancia de lista de tesouro direto
            DirectTreasureList directTreasureList = new DirectTreasureList();

            //Intanciando radom para valores aleatorios
            Random random = new Random();

            //Gerando 6 tesouro direto
            for (int i = 0; i < 6; i++)
            {
                //Nova instancia de tesouro direto
                DirectTreasure directTreasure = new DirectTreasure();
                directTreasure.Name = $"Tesouro direto{i + 1}";
                directTreasure.Description = $"Descrição teste{i + 1}";
                directTreasure.MonthlyProfitability = random.Next(1,45);
                directTreasure.Initials = initials[random.Next(initials.Length)];
                directTreasure.Price = random.NextDouble() * 200;
                directTreasure.TypeDirectTreasure = type[random.Next(type.Length)];
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
