using PRODUTO.FORM.Contracts;
using PRODUTO.FORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODUTO.FORM.DesignTime
{
    public class DesignTimeDataService : IDataService
    {
        public List<Produto> CarregarProdutos()
        {
            return new List<Produto>
            {
                new Produto { Id = 1, Nome = "Design Time Produto 1", Codigo= "SKU123", Preco = 19.99m, Estoque = 15, Descricao = "Descrição do produto exemplo 1" },
                new Produto { Id = 2, Nome = "Design Time Produto 2", Codigo= "SKU234", Preco = 29.99m, Estoque = 8, Descricao = "Descrição do produto exemplo 2" },
                new Produto { Id = 3, Nome = "Design Time Produto 3", Codigo= "SKU345", Preco = 39.99m, Estoque = 20, Descricao = "Descrição do produto exemplo 3" }
            };
        }

        public void SalvarProdutos(List<Produto> produtos)
        {
            // Não faz nada em design-time
        }
    }
}
