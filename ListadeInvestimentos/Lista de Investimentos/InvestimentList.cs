using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    // Gerando Uma classe de lista de investimentos
    public class InvestimentList<T> where T : Investments
    {
        //Criando uma lista de investimentos
        public List<T> Investments { get; set; }

        //Classe InvestmentList recebe uma nova lista
        public InvestimentList()
        {
            Investments = new List<T>();
        }

        // Criando metodo de adicionar investimentos a lista
        public virtual void SetInvestment(T investments)
        {
            Investments.Add(investments);
        }
    }
}
