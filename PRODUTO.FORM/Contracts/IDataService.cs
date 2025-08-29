using PRODUTO.FORM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRODUTO.FORM.Contracts
{
    public interface IDataService
    {
        List<Produto> CarregarProdutos();
        void SalvarProdutos(List<Produto> produtos);
    }
}
