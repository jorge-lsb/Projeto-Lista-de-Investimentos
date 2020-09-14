using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    //Gerando nova classe de lista de tesouro direto
    public class DirectTreasureList
    {

        //Gerando propriedade de lista 
        public List<DirectTreasure> DirectTreasure { get; set; }

        //Gerando uma nova lista de tesouro direto
        public DirectTreasureList()
        {
            DirectTreasure = new List<DirectTreasure>();
        }

        //Metodo adicionando novo tesouro direto a lista
        public virtual void SetDirectTreasure(DirectTreasure directTreasure)
        {
            DirectTreasure.Add(directTreasure);
        }
    }
}
