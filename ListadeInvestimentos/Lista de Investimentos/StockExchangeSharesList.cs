using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_de_Investimentos
{
    // Gerando uma classe listaa de ações
    public class StockExchangeSharesList 
    {

        // Criando uma lista de ação
        public List<StockExchangeShares> StockExchangeShares { get; set; }

        //Classe StockExchangeSharesList recebe uma nova lista
        public StockExchangeSharesList()
        {
            StockExchangeShares = new List<StockExchangeShares>();
        }
        // Criando metodo de adicionar Ações a lista
        public virtual void SetStockExchangeShares(StockExchangeShares stockExchangeShares)
        {
            StockExchangeShares.Add(stockExchangeShares);
        }
    }   
}
